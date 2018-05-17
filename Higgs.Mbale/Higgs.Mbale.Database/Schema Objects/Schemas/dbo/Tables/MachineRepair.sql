CREATE TABLE [dbo].[MachineRepair]
(
	[MachineRepairId] BIGINT IDENTITY(1,1) NOT NULL,	
	[NameOfRepair] [nvarchar](128) not NULL,
	[Amount] FLOAT NOT NULL,
	[DateRepaired]	[datetime] NOT NULL,
	[MediaId] BIGINT NOT NULL,
	[Quantity] INT NOT NULL,
	[BranchId]   BIGINT NOT NULL,
	[Deleted]	[bit] NULL,
	[CreatedBy] [nvarchar](128) NULL, 
    [UpdatedBy] [nvarchar](128) NULL,     
    [DeletedBy] [nvarchar](128) NULL,
	[CreatedOn]	[datetime] NULL,
	[TimeStamp]	[datetime] NOT NULL DEFAULT GETDATE(),	
	[DeletedOn]	[datetime] NULL,

    CONSTRAINT [PK_dbo.MachineRepair] PRIMARY KEY CLUSTERED 
(
	[MachineRepairId] ASC
),

CONSTRAINT [FK_MachineRepair_MediaId] FOREIGN KEY([MediaId]) REFERENCES [dbo].[Media](MediaId),
CONSTRAINT [FK_MachineRepair_BranchId] FOREIGN KEY([BranchId]) REFERENCES [dbo].[Branch](BranchId),
CONSTRAINT [FK_MachineRepair_CreatedBy] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_MachineRepair_UpdatedBy] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_MachineRepair_DeletedBy] FOREIGN KEY ([DeletedBy]) REFERENCES [dbo].[AspNetUsers](Id),
)ON [PRIMARY]

