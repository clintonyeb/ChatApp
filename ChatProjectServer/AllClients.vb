Public Class AllClients
    Inherits System.Collections.ObjectModel.KeyedCollection(Of String, Client)

    Protected Overrides Function GetKeyForItem(item As Client) As String
        Return item.id
    End Function
End Class
