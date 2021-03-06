REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/8/6 15:35:35


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports System.Xml.Serialization

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `visitor_stat`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `visitor_stat` (
'''   `uid` int(11) NOT NULL AUTO_INCREMENT,
'''   `time` datetime NOT NULL,
'''   `ip` varchar(45) NOT NULL,
'''   `url` tinytext NOT NULL COMMENT 'Url that going to visit this web site',
'''   `success` int(11) NOT NULL,
'''   `method` varchar(45) DEFAULT NULL COMMENT 'GET/POST/PUT.....',
'''   `ua` varchar(1024) DEFAULT NULL COMMENT 'User agent',
'''   `ref` mediumtext COMMENT 'reference url, Referer',
'''   `data` mediumtext COMMENT 'additional data notes',
'''   `app` int(11) NOT NULL COMMENT '用户所访问的url所属的app的编号',
'''   PRIMARY KEY (`ip`,`time`,`app`),
'''   UNIQUE KEY `uid_UNIQUE` (`uid`),
'''   KEY `fk_visitor_stat_app1_idx` (`app`),
'''   CONSTRAINT `fk_visitor_stat_app1` FOREIGN KEY (`app`) REFERENCES `app` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping events for database 'smrucc-cloud'
''' --
''' 
''' --
''' -- Dumping routines for database 'smrucc-cloud'
''' --
''' /*!50003 DROP FUNCTION IF EXISTS `task_expired` */;
''' /*!50003 SET @saved_cs_client      = @@character_set_client */ ;
''' /*!50003 SET @saved_cs_results     = @@character_set_results */ ;
''' /*!50003 SET @saved_col_connection = @@collation_connection */ ;
''' /*!50003 SET character_set_client  = utf8 */ ;
''' /*!50003 SET character_set_results = utf8 */ ;
''' /*!50003 SET collation_connection  = utf8_general_ci */ ;
''' /*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
''' /*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
''' DELIMITER ;;
''' CREATE DEFINER=`root`@`localhost` FUNCTION `task_expired`(time_complete datetime) RETURNS tinyint(1)
''' BEGIN
''' 
'''    /* 
'''     * 用户的任务执行结果数据只保存24个小时，则在这个函数之中需要进行判断的是
'''     * 任务的完成时间和现在的时间差是否大于24个小时？ 
'''     *
'''     * 如果是，则说明任务已经过期了，则会返回true删除数据
'''     * 如果不是，则返回false
'''     */
'''    DECLARE val integer;
''' 
'''    SET val = TIMESTAMPDIFF(HOUR, time_complete, now()) ;
'''    RETURN NOT val &lt;= 24;
''' 
''' END ;;
''' DELIMITER ;
''' /*!50003 SET sql_mode              = @saved_sql_mode */ ;
''' /*!50003 SET character_set_client  = @saved_cs_client */ ;
''' /*!50003 SET character_set_results = @saved_cs_results */ ;
''' /*!50003 SET collation_connection  = @saved_col_connection */ ;
''' /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
''' 
''' /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
''' /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
''' /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
''' /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
''' /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
''' /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
''' /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
''' 
''' -- Dump completed on 2017-05-28  3:12:56
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("visitor_stat", Database:="smrucc-cloud", SchemaSQL:="
CREATE TABLE `visitor_stat` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `time` datetime NOT NULL,
  `ip` varchar(45) NOT NULL,
  `url` tinytext NOT NULL COMMENT 'Url that going to visit this web site',
  `success` int(11) NOT NULL,
  `method` varchar(45) DEFAULT NULL COMMENT 'GET/POST/PUT.....',
  `ua` varchar(1024) DEFAULT NULL COMMENT 'User agent',
  `ref` mediumtext COMMENT 'reference url, Referer',
  `data` mediumtext COMMENT 'additional data notes',
  `app` int(11) NOT NULL COMMENT '用户所访问的url所属的app的编号',
  PRIMARY KEY (`ip`,`time`,`app`),
  UNIQUE KEY `uid_UNIQUE` (`uid`),
  KEY `fk_visitor_stat_app1_idx` (`app`),
  CONSTRAINT `fk_visitor_stat_app1` FOREIGN KEY (`app`) REFERENCES `app` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class visitor_stat: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid")> Public Property uid As Long
    <DatabaseField("time"), PrimaryKey, NotNull, DataType(MySqlDbType.DateTime), Column(Name:="time"), XmlAttribute> Public Property time As Date
    <DatabaseField("ip"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="ip"), XmlAttribute> Public Property ip As String
''' <summary>
''' Url that going to visit this web site
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("url"), NotNull, DataType(MySqlDbType.Text), Column(Name:="url")> Public Property url As String
    <DatabaseField("success"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="success")> Public Property success As Long
''' <summary>
''' GET/POST/PUT.....
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("method"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="method")> Public Property method As String
''' <summary>
''' User agent
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("ua"), DataType(MySqlDbType.VarChar, "1024"), Column(Name:="ua")> Public Property ua As String
''' <summary>
''' reference url, Referer
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("ref"), DataType(MySqlDbType.Text), Column(Name:="ref")> Public Property ref As String
''' <summary>
''' additional data notes
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("data"), DataType(MySqlDbType.Text), Column(Name:="data")> Public Property data As String
''' <summary>
''' 用户所访问的url所属的app的编号
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("app"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app"), XmlAttribute> Public Property app As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `visitor_stat` (`time`, `ip`, `url`, `success`, `method`, `ua`, `ref`, `data`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `visitor_stat` (`time`, `ip`, `url`, `success`, `method`, `ua`, `ref`, `data`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `visitor_stat` WHERE `ip`='{0}' and `time`='{1}' and `app`='{2}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `visitor_stat` SET `uid`='{0}', `time`='{1}', `ip`='{2}', `url`='{3}', `success`='{4}', `method`='{5}', `ua`='{6}', `ref`='{7}', `data`='{8}', `app`='{9}' WHERE `ip`='{10}' and `time`='{11}' and `app`='{12}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `visitor_stat` WHERE `ip`='{0}' and `time`='{1}' and `app`='{2}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, ip, DataType.ToMySqlDateTimeString(time), app)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `visitor_stat` (`time`, `ip`, `url`, `success`, `method`, `ua`, `ref`, `data`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, DataType.ToMySqlDateTimeString(time), ip, url, success, method, ua, ref, data, app)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{time}', '{ip}', '{url}', '{success}', '{method}', '{ua}', '{ref}', '{data}', '{app}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `visitor_stat` (`time`, `ip`, `url`, `success`, `method`, `ua`, `ref`, `data`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, DataType.ToMySqlDateTimeString(time), ip, url, success, method, ua, ref, data, app)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `visitor_stat` SET `uid`='{0}', `time`='{1}', `ip`='{2}', `url`='{3}', `success`='{4}', `method`='{5}', `ua`='{6}', `ref`='{7}', `data`='{8}', `app`='{9}' WHERE `ip`='{10}' and `time`='{11}' and `app`='{12}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, DataType.ToMySqlDateTimeString(time), ip, url, success, method, ua, ref, data, app, ip, DataType.ToMySqlDateTimeString(time), app)
    End Function
#End Region
Public Function Clone() As visitor_stat
                  Return DirectCast(MyClass.MemberwiseClone, visitor_stat)
              End Function
End Class


End Namespace
