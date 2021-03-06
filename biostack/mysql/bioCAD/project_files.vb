REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/18/2018 5:37:20 PM


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports MySqlScript = Oracle.LinuxCompatibility.MySQL.Scripting.Extensions

Namespace MySql.bioCAD

''' <summary>
''' ```SQL
''' 分析项目和文件池之中的文件的关联关系
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `project_files`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `project_files` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `user_id` int(11) NOT NULL,
'''   `project_id` int(11) NOT NULL,
'''   `file_id` int(11) NOT NULL,
'''   `join_time` datetime NOT NULL COMMENT '将用户的项目和文件这两个实体之间建立起关联的时间',
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='分析项目和文件池之中的文件的关联关系';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("project_files", Database:="biocad", SchemaSQL:="
CREATE TABLE `project_files` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL,
  `file_id` int(11) NOT NULL,
  `join_time` datetime NOT NULL COMMENT '将用户的项目和文件这两个实体之间建立起关联的时间',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='分析项目和文件池之中的文件的关联关系';")>
Public Class project_files: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("project_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project_id")> Public Property project_id As Long
    <DatabaseField("file_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="file_id")> Public Property file_id As Long
''' <summary>
''' 将用户的项目和文件这两个实体之间建立起关联的时间
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("join_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="join_time")> Public Property join_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `project_files` (`user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `project_files` (`user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `project_files` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `project_files` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `file_id`='{3}', `join_time`='{4}' WHERE `id` = '{5}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `project_files` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
        Else
        Return String.Format(INSERT_SQL, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{user_id}', '{project_id}', '{file_id}', '{join_time}')"
        Else
            Return $"('{user_id}', '{project_id}', '{file_id}', '{join_time}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
        Else
        Return String.Format(REPLACE_SQL, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `project_files` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `file_id`='{3}', `join_time`='{4}' WHERE `id` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time), id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As project_files
                         Return DirectCast(MyClass.MemberwiseClone, project_files)
                     End Function
End Class


End Namespace
