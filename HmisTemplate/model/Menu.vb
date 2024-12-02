Namespace model

    Public Class Menu

        Public menuId As Integer
        Public menuText As String
        Public parentId As Integer

    End Class

    Public Class TCode

        Public Shared ID_TCODE As String = "id"
        Public Id As Integer

        Public Shared MENU_CAPTION As String = "menu_caption"
        Public MenuCaption As String

        Public Shared PROCESS_ID As String = "process_id"
        Public ProcessId As Integer

        Public Shared MENU_ID As String = "menu_id"
        Public MenuId As Integer

        Public Shared PROCESS_NAME As String = "process_name"
        Public ProcessName As String

        Public Shared DLL_NAME As String = "dll_name"
        Public DllName As String

        Public Shared UC_NAME As String = "uc_name"
        Public UcName As String

        Public Shared TRANS_CODE As String = "trans_code"
        Public TransCode As String

    End Class

End Namespace

