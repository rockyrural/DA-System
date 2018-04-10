Public Class CouncilVoting

    Private Sub CouncilDeterminedBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouncilDeterminedBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CouncilDeterminedBindingSource.EndEdit()
        Me.CouncilDeterminedTableAdapter.Update(Me.CouncilVotingDataSet.CouncilDetermined)

    End Sub

    Private Sub CouncilVoting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CouncilVotingDataSet.CouncilDetermined' table. You can move, or remove it, as needed.


        Dim ThomsonFDec As New ArrayList
        With ThomsonFDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboThomsonF
            .DataSource = ThomsonFDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim VardonCDec As New ArrayList
        With VardonCDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboVardonC
            .DataSource = VardonCDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim BrownADec As New ArrayList
        With BrownADec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboBrownA
            .DataSource = BrownADec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim BrownLDec As New ArrayList
        With BrownLDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboBrownL
            .DataSource = BrownLDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim DanceKDec As New ArrayList
        With DanceKDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboDanceK
            .DataSource = DanceKDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim KowalCDec As New ArrayList
        With KowalCDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboKowalC
            .DataSource = KowalCDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim MortonADec As New ArrayList
        With MortonADec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboMortonA
            .DataSource = MortonADec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim PollockRDec As New ArrayList
        With PollockRDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboPollockR
            .DataSource = PollockRDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Dim ScobieGDec As New ArrayList
        With ScobieGDec
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
            .Add(New YesNoAnswer("Absent", "A"))
        End With

        With cboScobieG
            .DataSource = ScobieGDec
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With

        Me.CouncilDeterminedTableAdapter.Fill(Me.CouncilVotingDataSet.CouncilDetermined)
    End Sub

    Private Sub btnDAAppNotDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeetingDt.Click
        RetrieveDate(MeetingDt)
    End Sub

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .GetTheDate = datefield.Text
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        'If TheNewDate <> String.Empty Then datefield.Text = TheNewDate
        datefield.Text = TheNewDate
    End Sub

End Class