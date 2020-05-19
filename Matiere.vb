Public Class Matiere
    Dim nom As String
    Dim oral As Boolean
    Dim ecrit As Boolean


    Sub New(ByVal nom As String, ByVal oral As Boolean, ByVal ecrit As Boolean)

    End Sub

    Public Property Oral()
        Get
            Return Oral
        End Get
        Set(ByVal value)
        End Set
    End Property

End Class
