﻿' Instat+R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.


Public Class RSyntax
    Public clsBaseFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Public bUseBaseFunction As Boolean = False
    Public bUseBaseOperator As Boolean = False
    Public iCallType As Integer = 0
    Public strScript As String
    Public i As Integer
    Public bExcludeAssignedFunctionOutput As Boolean = True

    Public Sub SetFunction(strFunctionName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.SetRCommand(strFunctionName)
        bUseBaseFunction = True
        bUseBaseOperator = False
    End Sub

    Public Sub SetBaseRFunction(clsFunction As RFunction)
        clsBaseFunction = clsFunction
        bUseBaseFunction = True
        bUseBaseOperator = False
    End Sub

    Public Sub SetOperation(strOp As String, Optional bBracketTemp As Boolean = True)
        clsBaseOperator.SetOperation(strOp, bBracketTemp)
        bUseBaseFunction = False
        bUseBaseOperator = True
    End Sub

    Public Sub SetAssignTo(strAssignToName As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False)
        If bUseBaseOperator Then
            clsBaseOperator.SetAssignTo(strTemp:=strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames)
        End If
        If bUseBaseFunction Then
            clsBaseFunction.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames)
        End If
    End Sub

    Public Sub RemoveAssignTo()
        If bUseBaseOperator Then
            clsBaseOperator.RemoveAssignTo()
        End If
        If bUseBaseFunction Then
            clsBaseFunction.RemoveAssignTo()
        End If
    End Sub

    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing)
        clsBaseFunction.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter)
    End Sub

    Public Sub AddParameter(clsRParam As RParameter)
        clsBaseFunction.AddParameter(clsRParam)
    End Sub

    Public Function GetParameter(strName As String) As RParameter
        If bUseBaseFunction Then
            Return clsBaseFunction.GetParameter(strName)
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.GetParameter(strName)
        End If
        Return Nothing
    End Function

    Public Sub SetOperatorParameter(bSetFirst As Boolean, Optional strParameterName As String = "", Optional strValue As String = "", Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing)
        clsBaseOperator.SetParameter(bSetFirst, strParameterName, strValue, clsParam, clsRFunc, clsOp)
    End Sub

    Public Sub AddOperatorParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing)
        clsBaseOperator.AddAdditionalParameter(strParameterName, strParameterValue, clsRFunc, clsOp)
    End Sub

    Public Sub RemoveParameter(strParameterName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.RemoveParameterByName(strParameterName)
    End Sub

    Public Sub RemoveOperatorParameter(strParameterName As String)
        clsBaseOperator.RemoveParameterByName(strParameterName)
    End Sub

    Public Sub ClearParameters(Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If

        clsFunction.ClearParameters()
    End Sub

    Public Function GetScript(Optional ByRef clsFunction As RFunction = Nothing) As String

        Dim strTemp As String = ""

        If IsNothing(clsFunction) Then
            If bUseBaseFunction Then
                clsFunction = clsBaseFunction
                strTemp = clsBaseFunction.ToScript(strScript)
            End If
            If bUseBaseOperator Then
                strTemp = clsBaseOperator.ToScript(strScript)
            End If
        Else
            strTemp = clsFunction.ToScript(strScript)
        End If
        If bUseBaseFunction Then
            If bExcludeAssignedFunctionOutput And clsFunction.bIsAssigned Then
                Return strScript
                Exit Function
            End If
        End If
        Return strScript & strTemp

    End Function

End Class