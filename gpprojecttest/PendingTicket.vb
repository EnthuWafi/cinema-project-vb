Public Class PendingTicket
    Public intSeatNumber, intShowtimeID, intPriceID As Integer
    Public age_category As String
    Public decPrice, decDiscount As Decimal
    Public isOKU As Boolean

    Public movie As Movie

    Public Sub New()
        'default int seat is -1 (aka not chosen)
        intSeatNumber = -1
        decDiscount = 0
        isOKU = False
    End Sub


End Class
