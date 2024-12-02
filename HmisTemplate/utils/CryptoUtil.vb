Imports System.Diagnostics
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO


Public Class CryptoUtil

    '8 bytes randomly selected for both the Key and the Initialization Vector
    'the IV is used to encrypt the first block of text so that any repetitive 
    'patterns are not apparent
    Private Shared KEY_64() As Byte = {42, 16, 93, 156, 78, 4, 218, 32}
    Private Shared IV_64() As Byte = {55, 103, 246, 79, 36, 99, 167, 3}

    '24 byte or 192 bit key and IV for TripleDES
    Private Shared KEY_192() As Byte = {42, 16, 93, 156, 78, 4, 218, 32, _
            15, 167, 44, 80, 26, 250, 155, 112, _
            2, 94, 11, 204, 119, 35, 184, 197}
    Private Shared IV_192() As Byte = {55, 103, 246, 79, 36, 99, 167, 3, _
            42, 5, 62, 83, 184, 7, 209, 13, _
            145, 23, 200, 58, 173, 10, 121, 222}

    'Standard DES encryption
    Friend Shared Function Encrypt(ByVal value As String) As String
        If value <> "" Then
            Dim cryptoProvider As DESCryptoServiceProvider = _
                New DESCryptoServiceProvider()
            Dim ms As MemoryStream = New MemoryStream()
            Dim cs As CryptoStream = _
                New CryptoStream(ms, cryptoProvider.CreateEncryptor(KEY_64, IV_64), _
                    CryptoStreamMode.Write)
            Dim sw As StreamWriter = New StreamWriter(cs)

            sw.Write(value)
            sw.Flush()
            cs.FlushFinalBlock()
            ms.Flush()

            'convert back to a string
            Return Convert.ToBase64String(ms.GetBuffer(), 0, ms.Length)
        End If
    End Function


    'Standard DES decryption
    Friend Shared Function Decrypt(ByVal value As String) As String
        If value <> "" Then
            Dim cryptoProvider As DESCryptoServiceProvider = _
                New DESCryptoServiceProvider()

            'convert from string to byte array
            Dim buffer As Byte() = Convert.FromBase64String(value)
            Dim ms As MemoryStream = New MemoryStream(buffer)
            Dim cs As CryptoStream = _
                New CryptoStream(ms, cryptoProvider.CreateDecryptor(KEY_64, IV_64), _
                    CryptoStreamMode.Read)
            Dim sr As StreamReader = New StreamReader(cs)

            Return sr.ReadToEnd()
        End If
    End Function

    'TRIPLE DES encryption
    Friend Shared Function EncryptTripleDES(ByVal value As String) As String
        If value <> "" Then
            Dim cryptoProvider As TripleDESCryptoServiceProvider = _
                New TripleDESCryptoServiceProvider()
            Dim ms As MemoryStream = New MemoryStream()
            Dim cs As CryptoStream = _
                New CryptoStream(ms, cryptoProvider.CreateEncryptor(KEY_192, IV_192), _
                    CryptoStreamMode.Write)
            Dim sw As StreamWriter = New StreamWriter(cs)

            sw.Write(value)
            sw.Flush()
            cs.FlushFinalBlock()
            ms.Flush()

            'convert back to a string
            Return Convert.ToBase64String(ms.GetBuffer(), 0, ms.Length)
        End If
    End Function


    'TRIPLE DES decryption
    Friend Shared Function DecryptTripleDES(ByVal value As String) As String
        If value <> "" Then
            Dim cryptoProvider As TripleDESCryptoServiceProvider = _
                New TripleDESCryptoServiceProvider()

            'convert from string to byte array
            Dim buffer As Byte() = Convert.FromBase64String(value)
            Dim ms As MemoryStream = New MemoryStream(buffer)
            Dim cs As CryptoStream = _
                New CryptoStream(ms, cryptoProvider.CreateDecryptor(KEY_192, IV_192), _
                    CryptoStreamMode.Read)
            Dim sr As StreamReader = New StreamReader(cs)

            Return sr.ReadToEnd()
        End If
    End Function

    ' Hash an input string and return the hash as
    ' a 32 character hexadecimal string.
    Friend Shared Function getMd5Hash(ByVal input As String) As String
        ' Create a new instance of the MD5 object.
        Dim md5Hasher As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function


End Class
