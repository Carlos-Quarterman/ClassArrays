Public Class Form1
    'Joseph Clark
    'April 28, 2016
    'Class Array Extra Credit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Lastname() As String = {"Broomfield", "Brown", "Campbell", "Canteen", "Cason", "Clark", "Clemons", "Collins", "Craig", "Dalmida", "Daniel", "Harris", "Hunter", "Kemp", "King", "Mcclendon", "Mesamours", "Mitchell", "Quarterman", "Rouse", "Suggs", "West", "Whitaker", "White", "Williams"}
        Dim Firstname() As String = {"Lawrence", "Mesha", "Michelle", "Alayah", "Jenae", "Joseph", "Travis", "Melody", "Cedric", "Joel", "Jasmine", "Robert", "Anthony", "Dexter", "Julious", "Kevin", "Rolwilde", "Kyle", "Carlos", "Bry'on", "Janika", "Keyonna", "Jaron", "Robbie", "Eric"}

        Dim Lastname1() As String = {"Brown", "Campbell", "Williams", "Quarterman", "King", "Rouse", "Mitchell", "Hunter", "Kemp", "Craig", "Clark", "Broomfield", "Dalmida", "Suggs", "West", "Collins", "Mesamours", "McClendon", "Harris", "Cason", "White", "Clemons", "Daniel", "Whitaker"}
        Dim Firstname1() As String = {"Mesha", "Michelle", "Eric", "Carlos", "Julious", "Bry'On", "Kyle", "Anthony", "Dexter", "Cedric", "Joseph", "Lawrence", "Joel", "Janika", "Keyona", "Melody", "Rolwilde", "Kevin", "Robert", "Jenae", "Robbie", "Travis", "Jasmine", "Jaron"}

        Dim temp As String
        Dim temp10 As String
        Dim counter As Integer = 0
        Dim counter1 As Integer = 0


        ListBox1.Items.Add("Sorted")
        ListBox1.Items.Add("")

        For h As Integer = 0 To 23
            counter = counter + 1
            ListBox1.Items.Add(counter & "." & Firstname(h) & "    " & vbTab & Lastname(h))
            'ListBox1.Items.Add("")
        Next
        For i = 23 To 0 Step -1
            For h = 0 To i
                If Lastname(h) < Lastname(h + 1) Then
                    temp = Lastname(h)
                    Lastname(h) = Lastname(h + 1)
                    Lastname(h + 1) = temp

                    temp10 = Firstname(h)
                    Firstname(h) = Firstname(h + 1)
                    Firstname(h + 1) = temp10

                End If
            Next
        Next

        ListBox2.Items.Add("UnSorted")
        ListBox2.Items.Add("")
        For h As Integer = 0 To 23
            counter1 = counter1 + 1
            ListBox2.Items.Add(counter1 & "." & Firstname1(h) & "    " & vbTab & Lastname1(h))
            'ListBox2.Items.Add("")
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()
    End Sub

  
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
End Class
