Public Class NumericTextBox
    Inherits TextBox
    Private SpaceOK As Boolean = False

    ' Restricts the entry of characters to digits (including hex),
    ' the negative sign, the e decimal point, and editing keystrokes (backspace).
    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)

        Dim decimalSeparator As String = "."
        Dim groupSeparator As String = ","
        Dim negativeSign As String = "-"

        Dim keyInput As String = e.KeyChar.ToString()

        If [Char].IsDigit(e.KeyChar) Then
            ' Digits are OK
        ElseIf keyInput.Equals(decimalSeparator) OrElse keyInput.Equals(groupSeparator) OrElse keyInput.Equals(negativeSign) Then
            ' Decimal separator is OK
        ElseIf e.KeyChar = vbBack Then
            ' Backspace key is OK
            '    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            '    {
            '     // Let the edit control handle control and alt key combinations
            '    }
        ElseIf Me.SpaceOK AndAlso e.KeyChar = " "c Then

        Else
            ' Consume this invalid key and beep.
            e.Handled = True
        End If

    End Sub


    Public ReadOnly Property IntValue() As Integer
        Get
            Return Int32.Parse(Me.Text)
        End Get
    End Property


    Public ReadOnly Property DecimalValue() As Decimal
        Get
            Return [Decimal].Parse(Me.Text)
        End Get
    End Property


    Public Property AllowSpace() As Boolean

        Get
            Return Me.SpaceOK
        End Get
        Set(ByVal value As Boolean)
            Me.SpaceOK = value
        End Set
    End Property

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class

