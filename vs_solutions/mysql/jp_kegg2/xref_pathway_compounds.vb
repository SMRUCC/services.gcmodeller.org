REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @5/1/2017 1:11:27 PM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 代谢途径之中所包含有的代谢物的列表
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `xref_pathway_compounds`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `xref_pathway_compounds` (
'''   `pathway` int(11) NOT NULL,
'''   `compound` int(11) NOT NULL COMMENT '``data_compounds``表之中的唯一数字编号',
'''   `KEGG` varchar(45) NOT NULL COMMENT 'KEGG compound id.(KEGG代谢物的编号)',
'''   `name` varchar(45) DEFAULT NULL COMMENT '代谢物的名称',
'''   PRIMARY KEY (`pathway`,`compound`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='代谢途径之中所包含有的代谢物的列表';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("xref_pathway_compounds", Database:="jp_kegg2", SchemaSQL:="
CREATE TABLE `xref_pathway_compounds` (
  `pathway` int(11) NOT NULL,
  `compound` int(11) NOT NULL COMMENT '``data_compounds``表之中的唯一数字编号',
  `KEGG` varchar(45) NOT NULL COMMENT 'KEGG compound id.(KEGG代谢物的编号)',
  `name` varchar(45) DEFAULT NULL COMMENT '代谢物的名称',
  PRIMARY KEY (`pathway`,`compound`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='代谢途径之中所包含有的代谢物的列表';")>
Public Class xref_pathway_compounds: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("pathway"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="pathway")> Public Property pathway As Long
''' <summary>
''' ``data_compounds``表之中的唯一数字编号
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("compound"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="compound")> Public Property compound As Long
''' <summary>
''' KEGG compound id.(KEGG代谢物的编号)
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("KEGG"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="KEGG")> Public Property KEGG As String
''' <summary>
''' 代谢物的名称
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `xref_pathway_compounds` (`pathway`, `compound`, `KEGG`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `xref_pathway_compounds` (`pathway`, `compound`, `KEGG`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `xref_pathway_compounds` WHERE `pathway`='{0}' and `compound`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `xref_pathway_compounds` SET `pathway`='{0}', `compound`='{1}', `KEGG`='{2}', `name`='{3}' WHERE `pathway`='{4}' and `compound`='{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `xref_pathway_compounds` WHERE `pathway`='{0}' and `compound`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, pathway, compound)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `xref_pathway_compounds` (`pathway`, `compound`, `KEGG`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, pathway, compound, KEGG, name)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{pathway}', '{compound}', '{KEGG}', '{name}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `xref_pathway_compounds` (`pathway`, `compound`, `KEGG`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, pathway, compound, KEGG, name)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `xref_pathway_compounds` SET `pathway`='{0}', `compound`='{1}', `KEGG`='{2}', `name`='{3}' WHERE `pathway`='{4}' and `compound`='{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, pathway, compound, KEGG, name, pathway, compound)
    End Function
#End Region
Public Function Clone() As xref_pathway_compounds
                  Return DirectCast(MyClass.MemberwiseClone, xref_pathway_compounds)
              End Function
End Class


End Namespace
