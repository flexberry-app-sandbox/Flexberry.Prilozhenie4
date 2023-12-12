




CREATE TABLE СпрКонтрАг (
 primaryKey UUID NOT NULL,
 Код INT NULL,
 Наименование VARCHAR(255) NULL,
 ИНН INT NULL,
 КПП INT NULL,
 КодПоОКПО INT NULL,
 ОГРН INT NULL,
 КодОКВЭД INT NULL,
 Телефон INT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE ТЧПлЗаНаД (
 primaryKey UUID NOT NULL,
 СтЗатрат VARCHAR(255) NULL,
 ОбъемРаботы VARCHAR(255) NULL,
 ОбГруз REAL NULL,
 КолЧасРаб REAL NULL,
 ВрПрибытия VARCHAR(255) NULL,
 ДатПрибыт TIMESTAMP(3) NULL,
 СпрНомен UUID NOT NULL,
 СпрТранспСр UUID NOT NULL,
 СпрКонтрАг UUID NOT NULL,
 СпрТипТрансСр UUID NOT NULL,
 СпрВидыРаб UUID NOT NULL,
 СпрЕдИзмер UUID NOT NULL,
 ДокПланЗаНаД UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрТипТрансСр (
 primaryKey UUID NOT NULL,
 Описание VARCHAR(255) NULL,
 ВместВКубМ REAL NULL,
 Наименование VARCHAR(255) NULL,
 Код INT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрПользов (
 primaryKey UUID NOT NULL,
 Код INT NULL,
 Должность VARCHAR(255) NULL,
 ФИО VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрВидыРаб (
 primaryKey UUID NOT NULL,
 Код INT NULL,
 Наименование VARCHAR(255) NULL,
 СпрЕдИзмер UUID NOT NULL,
 СпрТипТрансСр UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрОбъектСтр (
 primaryKey UUID NOT NULL,
 Наименование VARCHAR(255) NULL,
 Код INT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрНомен (
 primaryKey UUID NOT NULL,
 Описание VARCHAR(255) NULL,
 Код INT NULL,
 Наименование VARCHAR(255) NULL,
 СпрЕдИзмер UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрЕдИзмер (
 primaryKey UUID NOT NULL,
 Код INT NULL,
 Наименование VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE СпрТранспСр (
 primaryKey UUID NOT NULL,
 ГрузПодъемВТон VARCHAR(255) NULL,
 ГосНомер VARCHAR(255) NULL,
 ВидПеревоз VARCHAR(255) NULL,
 Марка VARCHAR(255) NULL,
 Код INT NULL,
 ЛицеКартНомер INT NULL,
 Наименование VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE ДокПланЗаНаД (
 primaryKey UUID NOT NULL,
 Время VARCHAR(255) NULL,
 Номер INT NULL,
 Дата TIMESTAMP(3) NULL,
 СпрПользов UUID NOT NULL,
 СпрОбъектСтр UUID NOT NULL,
 СпрКонтрАг UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMNETLOCKDATA (
 LockKey VARCHAR(300) NOT NULL,
 UserName VARCHAR(300) NOT NULL,
 LockDate TIMESTAMP(3) NULL,
 PRIMARY KEY (LockKey));


CREATE TABLE STORMSETTINGS (
 primaryKey UUID NOT NULL,
 Module VARCHAR(1000) NULL,
 Name VARCHAR(255) NULL,
 Value TEXT NULL,
 "User" VARCHAR(255) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMAdvLimit (
 primaryKey UUID NOT NULL,
 "User" VARCHAR(255) NULL,
 Published BOOLEAN NULL,
 Module VARCHAR(255) NULL,
 Name VARCHAR(255) NULL,
 Value TEXT NULL,
 HotKeyData INT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMFILTERSETTING (
 primaryKey UUID NOT NULL,
 Name VARCHAR(255) NOT NULL,
 DataObjectView VARCHAR(255) NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMWEBSEARCH (
 primaryKey UUID NOT NULL,
 Name VARCHAR(255) NOT NULL,
 "Order" INT NOT NULL,
 PresentView VARCHAR(255) NOT NULL,
 DetailedView VARCHAR(255) NOT NULL,
 FilterSetting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMFILTERDETAIL (
 primaryKey UUID NOT NULL,
 Caption VARCHAR(255) NOT NULL,
 DataObjectView VARCHAR(255) NOT NULL,
 ConnectMasterProp VARCHAR(255) NOT NULL,
 OwnerConnectProp VARCHAR(255) NULL,
 FilterSetting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE STORMFILTERLOOKUP (
 primaryKey UUID NOT NULL,
 DataObjectType VARCHAR(255) NOT NULL,
 Container VARCHAR(255) NULL,
 ContainerTag VARCHAR(255) NULL,
 FieldsToView VARCHAR(255) NULL,
 FilterSetting_m0 UUID NOT NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE UserSetting (
 primaryKey UUID NOT NULL,
 AppName VARCHAR(256) NULL,
 UserName VARCHAR(512) NULL,
 UserGuid UUID NULL,
 ModuleName VARCHAR(1024) NULL,
 ModuleGuid UUID NULL,
 SettName VARCHAR(256) NULL,
 SettGuid UUID NULL,
 SettLastAccessTime TIMESTAMP(3) NULL,
 StrVal VARCHAR(256) NULL,
 TxtVal TEXT NULL,
 IntVal INT NULL,
 BoolVal BOOLEAN NULL,
 GuidVal UUID NULL,
 DecimalVal DECIMAL(20,10) NULL,
 DateTimeVal TIMESTAMP(3) NULL,
 PRIMARY KEY (primaryKey));


CREATE TABLE ApplicationLog (
 primaryKey UUID NOT NULL,
 Category VARCHAR(64) NULL,
 EventId INT NULL,
 Priority INT NULL,
 Severity VARCHAR(32) NULL,
 Title VARCHAR(256) NULL,
 Timestamp TIMESTAMP(3) NULL,
 MachineName VARCHAR(32) NULL,
 AppDomainName VARCHAR(512) NULL,
 ProcessId VARCHAR(256) NULL,
 ProcessName VARCHAR(512) NULL,
 ThreadName VARCHAR(512) NULL,
 Win32ThreadId VARCHAR(128) NULL,
 Message VARCHAR(2500) NULL,
 FormattedMessage TEXT NULL,
 PRIMARY KEY (primaryKey));



 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FKcc62c38c0cdff523c0366e72da751025462499e3 FOREIGN KEY (СпрНомен) REFERENCES СпрНомен; 
CREATE INDEX Indexcc62c38c0cdff523c0366e72da751025462499e3 on ТЧПлЗаНаД (СпрНомен); 

 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FK3e786e3534f470fe6146229ba9fa9e7ae2787211 FOREIGN KEY (СпрТранспСр) REFERENCES СпрТранспСр; 
CREATE INDEX Index3e786e3534f470fe6146229ba9fa9e7ae2787211 on ТЧПлЗаНаД (СпрТранспСр); 

 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FK5d0eeb1fff63175b0b409900162e72a34bd71ba4 FOREIGN KEY (СпрКонтрАг) REFERENCES СпрКонтрАг; 
CREATE INDEX Index5d0eeb1fff63175b0b409900162e72a34bd71ba4 on ТЧПлЗаНаД (СпрКонтрАг); 

 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FK448e079c896c563ffb414460b67feecd81463b92 FOREIGN KEY (СпрТипТрансСр) REFERENCES СпрТипТрансСр; 
CREATE INDEX Index448e079c896c563ffb414460b67feecd81463b92 on ТЧПлЗаНаД (СпрТипТрансСр); 

 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FK262db856a216a00cd21dfa5eacdc2e39a5aab74e FOREIGN KEY (СпрВидыРаб) REFERENCES СпрВидыРаб; 
CREATE INDEX Index262db856a216a00cd21dfa5eacdc2e39a5aab74e on ТЧПлЗаНаД (СпрВидыРаб); 

 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FK4f18f1ab604498a0c7e4f28bf6942b067f2b570e FOREIGN KEY (СпрЕдИзмер) REFERENCES СпрЕдИзмер; 
CREATE INDEX Index4f18f1ab604498a0c7e4f28bf6942b067f2b570e on ТЧПлЗаНаД (СпрЕдИзмер); 

 ALTER TABLE ТЧПлЗаНаД ADD CONSTRAINT FK370a9e4734699234300fae8b2b55e9dc94168d74 FOREIGN KEY (ДокПланЗаНаД) REFERENCES ДокПланЗаНаД; 
CREATE INDEX Index370a9e4734699234300fae8b2b55e9dc94168d74 on ТЧПлЗаНаД (ДокПланЗаНаД); 

 ALTER TABLE СпрВидыРаб ADD CONSTRAINT FK105cacd2a93f6230c3c135143070c3ef1c4dd0c1 FOREIGN KEY (СпрЕдИзмер) REFERENCES СпрЕдИзмер; 
CREATE INDEX Index105cacd2a93f6230c3c135143070c3ef1c4dd0c1 on СпрВидыРаб (СпрЕдИзмер); 

 ALTER TABLE СпрВидыРаб ADD CONSTRAINT FKa7034f7bceece13908821312b7a842afbbddb0e3 FOREIGN KEY (СпрТипТрансСр) REFERENCES СпрТипТрансСр; 
CREATE INDEX Indexa7034f7bceece13908821312b7a842afbbddb0e3 on СпрВидыРаб (СпрТипТрансСр); 

 ALTER TABLE СпрНомен ADD CONSTRAINT FK840c81fedf20e0a82183dd6fd7f6953d4bf35c43 FOREIGN KEY (СпрЕдИзмер) REFERENCES СпрЕдИзмер; 
CREATE INDEX Index840c81fedf20e0a82183dd6fd7f6953d4bf35c43 on СпрНомен (СпрЕдИзмер); 

 ALTER TABLE ДокПланЗаНаД ADD CONSTRAINT FK81fbb905ae7456eaeeaa1838ff132654ebc92ff2 FOREIGN KEY (СпрПользов) REFERENCES СпрПользов; 
CREATE INDEX Index81fbb905ae7456eaeeaa1838ff132654ebc92ff2 on ДокПланЗаНаД (СпрПользов); 

 ALTER TABLE ДокПланЗаНаД ADD CONSTRAINT FKffa0aecf8e314e28f0eadc399661f74c23f443d7 FOREIGN KEY (СпрОбъектСтр) REFERENCES СпрОбъектСтр; 
CREATE INDEX Indexffa0aecf8e314e28f0eadc399661f74c23f443d7 on ДокПланЗаНаД (СпрОбъектСтр); 

 ALTER TABLE ДокПланЗаНаД ADD CONSTRAINT FK312a63ff4426c60c29aa41a1e1582c94c0bcc09a FOREIGN KEY (СпрКонтрАг) REFERENCES СпрКонтрАг; 
CREATE INDEX Index312a63ff4426c60c29aa41a1e1582c94c0bcc09a on ДокПланЗаНаД (СпрКонтрАг); 

 ALTER TABLE STORMWEBSEARCH ADD CONSTRAINT FKc4378e39870eb056aec84088683297a01d2a6200 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERDETAIL ADD CONSTRAINT FK921d16269835017e2a0d0e29ad6fb175454a70d0 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERLOOKUP ADD CONSTRAINT FKce38ef0db3f01a53acaa49fed8853fb941ad47ba FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

