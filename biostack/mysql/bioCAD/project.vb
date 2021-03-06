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
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `project`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `project` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `user_id` int(11) NOT NULL,
'''   `name` varchar(64) DEFAULT NULL,
'''   `description` tinytext,
'''   `type` int(11) NOT NULL DEFAULT '-1',
'''   `workspace` varchar(256) NOT NULL,
'''   `create_time` datetime NOT NULL,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("project", Database:="biocad", SchemaSQL:="
CREATE TABLE `project` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `name` varchar(64) DEFAULT NULL,
  `description` tinytext,
  `type` int(11) NOT NULL DEFAULT '-1',
  `workspace` varchar(256) NOT NULL,
  `create_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class project: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "64"), Column(Name:="name")> Public Property name As String
    <DatabaseField("description"), DataType(MySqlDbType.Text), Column(Name:="description")> Public Property description As String
    <DatabaseField("type"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="type")> Public Property type As Long
    <DatabaseField("workspace"), NotNull, DataType(MySqlDbType.VarChar, "256"), Column(Name:="workspace")> Public Property workspace As String
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `project` (`user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `project` (`id`, `user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `project` (`user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `project` (`id`, `user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `project` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `project` SET `id`='{0}', `user_id`='{1}', `name`='{2}', `description`='{3}', `type`='{4}', `workspace`='{5}', `create_time`='{6}' WHERE `id` = '{7}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `project` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `project` (`id`, `user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time))
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `project` (`id`, `user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time))
        Else
        Return String.Format(INSERT_SQL, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time))
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{user_id}', '{name}', '{description}', '{type}', '{workspace}', '{create_time}')"
        Else
            Return $"('{user_id}', '{name}', '{description}', '{type}', '{workspace}', '{create_time}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `project` (`id`, `user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time))
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `project` (`id`, `user_id`, `name`, `description`, `type`, `workspace`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time))
        Else
        Return String.Format(REPLACE_SQL, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time))
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `project` SET `id`='{0}', `user_id`='{1}', `name`='{2}', `description`='{3}', `type`='{4}', `workspace`='{5}', `create_time`='{6}' WHERE `id` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, name, description, type, workspace, MySqlScript.ToMySqlDateTimeString(create_time), id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As project
                         Return DirectCast(MyClass.MemberwiseClone, project)
                     End Function
End Class


End Namespace
