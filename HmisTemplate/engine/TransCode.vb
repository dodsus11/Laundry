Public Class TransCode

    Public Sub SetAutoCompleteText(ByVal txt As ToolStripTextBox, ByVal frm As Form)

        Dim source As New AutoCompleteStringCollection()
        source.AddRange(New String() _
                        {
                            "ADMISI/IRJA",
                            "ADMISI/IRNA",
                            "ADMISI/IRDA",
                            "IRJA/INTDMK",
                            "IRJA/INLAB",
                            "IRJA/INRAD",
                            "DOKTER"
                        })

        With txt

            .AutoCompleteCustomSource = source
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            '.Location = New Point(20, 20)
            .Width = frm.ClientRectangle.Width - 40
            .Visible = True

        End With

    End Sub


    Public Sub SetAutoCompleteText(ByVal txt As ToolStripTextBox,
                                   ByVal tcList As List(Of model.TCode),
                                   ByVal frm As Form)

        Dim source As New AutoCompleteStringCollection()

        For Each tc As model.TCode In tcList
            source.Add(tc.TransCode)
        Next

        'source.AddRange(New String() _
        '                {
        '                    "ADMISI/IRJA",
        '                    "ADMISI/IRNA",
        '                    "ADMISI/IRDA",
        '                    "IRJA/INTDMK",
        '                    "IRJA/INLAB",
        '                    "IRJA/INRAD",
        '                    "DOKTER"
        '                })

        With txt

            .AutoCompleteCustomSource = source
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            '.Location = New Point(20, 20)
            .Width = frm.ClientRectangle.Width - 40
            .Visible = True

        End With

    End Sub

End Class
