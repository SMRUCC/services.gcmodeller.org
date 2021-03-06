REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/3/2017 9:51:53 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' Enzyme in other external database
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `link_enzymes`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `link_enzymes` (
'''   `enzyme` int(11) NOT NULL,
'''   `EC` varchar(45) DEFAULT NULL,
'''   `database` varchar(45) DEFAULT NULL,
'''   `ID` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`enzyme`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Enzyme in other external database';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("link_enzymes", Database:="jp_kegg2", SchemaSQL:="
CREATE TABLE `link_enzymes` (
  `enzyme` int(11) NOT NULL,
  `EC` varchar(45) DEFAULT NULL,
  `database` varchar(45) DEFAULT NULL,
  `ID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`enzyme`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Enzyme in other external database';")>
Public Class link_enzymes: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("enzyme"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="enzyme")> Public Property enzyme As Long
    <DatabaseField("EC"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="EC")> Public Property EC As String
    <DatabaseField("database"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="database")> Public Property database As String
    <DatabaseField("ID"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="ID")> Public Property ID As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `link_enzymes` (`enzyme`, `EC`, `database`, `ID`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `link_enzymes` (`enzyme`, `EC`, `database`, `ID`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `link_enzymes` WHERE `enzyme` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `link_enzymes` SET `enzyme`='{0}', `EC`='{1}', `database`='{2}', `ID`='{3}' WHERE `enzyme` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `link_enzymes` WHERE `enzyme` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, enzyme)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `link_enzymes` (`enzyme`, `EC`, `database`, `ID`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, enzyme, EC, database, ID)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{enzyme}', '{EC}', '{database}', '{ID}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `link_enzymes` (`enzyme`, `EC`, `database`, `ID`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, enzyme, EC, database, ID)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `link_enzymes` SET `enzyme`='{0}', `EC`='{1}', `database`='{2}', `ID`='{3}' WHERE `enzyme` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, enzyme, EC, database, ID, enzyme)
    End Function
#End Region
Public Function Clone() As link_enzymes
                  Return DirectCast(MyClass.MemberwiseClone, link_enzymes)
              End Function
End Class


End Namespace
