CREATE TABLE [dbo].[Factory]
(
	[FactoryId] BIGINT IDENTITY(1,1) NOT NULL,	
	[Name] [nvarchar](128) not NULL,
	[BranchId]   BIGINT NOT NULL,
	[Deleted]	[bit] NULL,
	[CreatedBy] [nvarchar](128) NULL, 
    [UpdatedBy] [nvarchar](128) NULL,     
    [DeletedBy] [nvarchar](128) NULL,
	[CreatedOn]	[datetime] NULL,
	[TimeStamp]	[datetime] NOT NULL DEFAULT GETDATE(),	
	[DeletedOn]	[datetime] NULL,

    CONSTRAINT [PK_dbo.Factory] PRIMARY KEY CLUSTERED 
(
	[FactoryId] ASC
),
CONSTRAINT [FK_Factory_BranchId] FOREIGN KEY([BranchId]) REFERENCES [dbo].[Branch](BranchId),
CONSTRAINT [FK_Factory_CreatedBy] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_Factory_UpdatedBy] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_Factory_DeletedBy] FOREIGN KEY ([DeletedBy]) REFERENCES [dbo].[AspNetUsers](Id),
)ON [PRIMARY]
