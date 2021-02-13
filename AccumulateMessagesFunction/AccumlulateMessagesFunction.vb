'Tori Gomez
'RCET0265
'Spring 2021
'Accumulate Messages Function


Option Explicit On
Option Strict On

Module AccumlulateMessagesFunction

    Sub Main()
        Dim userInput As String

        Console.WriteLine("Name:")
        userInput = Console.ReadLine()
        UserInputCheck(userInput)

        Console.WriteLine("Age:")
        userInput = Console.ReadLine()
        UserInputCheck(userInput)

        MsgBox(UserMessages("", False))
        Console.Read()

    End Sub

    Function UserInputCheck(ByVal userInput As String) As String
        If userInput = "" Then
            Return UserMessages(($"{userInput}"), True)
        Else
            Return UserMessages(($"{userInput}"), False)
        End If
    End Function
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static messages As String
        If Not clear Then
            messages &= newMessage & vbNewLine
        Else
            messages = ""
        End If
        Return messages
    End Function
End Module
