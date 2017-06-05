'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity.Core.Objects.DataClasses
Imports System.Linq

Namespace AdvancedPatternsVB

    Partial Friend Class AdvancedPatternsModelFirstContext
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=AdvancedPatternsModelFirstContext")
            MyBase.Configuration.LazyLoadingEnabled = False
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Property Employees() As DbSet(Of EmployeeMf)
        Public Property Offices() As DbSet(Of OfficeMf)
        Public Property Buildings() As DbSet(Of BuildingMf)
        Friend Property MailRooms() As DbSet(Of MailRoomMf)
        Public Property Whiteboards() As DbSet(Of WhiteboardMf)
        Public Property BuildingDetails() As DbSet(Of BuildingDetailMf)
        Public Property WorkOrders() As DbSet(Of WorkOrderMf)
    
        Public Overridable Function AllOfficesStoredProc() As ObjectResult(Of OfficeMf)
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of OfficeMf)("AllOfficesStoredProc")
        End Function
    
        Public Overridable Function AllOfficesStoredProc(mergeOption As MergeOption) As ObjectResult(Of OfficeMf)
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of OfficeMf)("AllOfficesStoredProc", mergeOption)
        End Function
    
        Public Overridable Function EmployeeIdsInOfficeStoredProc(officeNumber As String, buildingId As Nullable(Of System.Guid)) As ObjectResult(Of Nullable(Of Integer))
            Dim officeNumberParameter As ObjectParameter = If(officeNumber IsNot Nothing, New ObjectParameter("OfficeNumber", officeNumber), New ObjectParameter("OfficeNumber", GetType(String)))
    
            Dim buildingIdParameter As ObjectParameter = If(buildingId.HasValue, New ObjectParameter("BuildingId", buildingId), New ObjectParameter("BuildingId", GetType(System.Guid)))
    
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("EmployeeIdsInOfficeStoredProc", officeNumberParameter, buildingIdParameter)
        End Function
    
        Public Overridable Function OfficesInBuildingStoredProc(buildingId As Nullable(Of System.Guid)) As ObjectResult(Of OfficeMf)
            Dim buildingIdParameter As ObjectParameter = If(buildingId.HasValue, New ObjectParameter("BuildingId", buildingId), New ObjectParameter("BuildingId", GetType(System.Guid)))
    
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of OfficeMf)("OfficesInBuildingStoredProc", buildingIdParameter)
        End Function
    
        Public Overridable Function OfficesInBuildingStoredProc(buildingId As Nullable(Of System.Guid), mergeOption As MergeOption) As ObjectResult(Of OfficeMf)
            Dim buildingIdParameter As ObjectParameter = If(buildingId.HasValue, New ObjectParameter("BuildingId", buildingId), New ObjectParameter("BuildingId", GetType(System.Guid)))
    
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of OfficeMf)("OfficesInBuildingStoredProc", mergeOption, buildingIdParameter)
        End Function
    
        Public Overridable Function SkimOffLeaveBalanceStoredProc(first As String, last As String) As Integer
            Dim firstParameter As ObjectParameter = If(first IsNot Nothing, New ObjectParameter("First", first), New ObjectParameter("First", GetType(String)))
    
            Dim lastParameter As ObjectParameter = If(last IsNot Nothing, New ObjectParameter("Last", last), New ObjectParameter("Last", GetType(String)))
    
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("SkimOffLeaveBalanceStoredProc", firstParameter, lastParameter)
        End Function
    
        Public Overridable Function AllSiteInfoStoredProc() As ObjectResult(Of SiteInfoMf)
            Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SiteInfoMf)("AllSiteInfoStoredProc")
        End Function
    
    End Class

End Namespace
