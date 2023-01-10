Public Class PendingTicket
    Public intSeatNumber, intTicketID As Integer
    Public age_category As String
    Public decPrice As Decimal

    Public Sub New()
        'default int seat is -1 (aka not chosen)
        intSeatNumber = -1

    End Sub
End Class
