# AirCodeGeneration
### Air代码生成工具
使用AirCodeGeneration可以根据你的模型类生成相应的数据库建表脚本。

### 支持平台
> Framework

> .NetCore

### 支持的数据库

> SQL Server

### 使用方式
1、Framework平台引用Air.Data,NetCore和NET Standard引用Air.Data.Core
2、模型类的代码请参考下面代码
```
  [DataBaseTableRule(IsCreateGnore = false)]
    public class CoreTest
    {

        [DataBaseFieldRule(DataType = "Int", IdentityValue = "Identity(1,1)", IsPramaryKey = true, Remark = "主键")]
        public int Id { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", Remark = "编码")]
        public int Code { get; set; }

        [DataBaseFieldRule(DataType = "Varchar(20)", Constraint = "Not Null")]
        public string Name { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", DefaultValue = "0")]
        public bool IsDelete { get; set; }

        [DataBaseFieldRule(DataType = "DateTime", Constraint = "Not Null", DefaultValue = "GetDate()")]
        public DateTime CreateTime { get; set; }
    }
```
3、打开AirCodeGeneration.exe，点击[选择DLL]打开包含模型类的DLL,在表格空间中选择你需要生成的模型后点击[生成SQL脚本]即可。

详细案例可参考源码中的Air.Code.Generation.Sample项目

### TODO
> 可对指定模型生成Alter脚本

### 编写初衷
目前实际工作中有很多项目没有使用Microsoft.Entity Framework,项目中还是由开发人员在数据库里建模后再到代码中编写模型类。使用AirCodeGeneration可以在编写完模型类后直接生成数据库建表脚本，省去枯燥无味的建表工作。