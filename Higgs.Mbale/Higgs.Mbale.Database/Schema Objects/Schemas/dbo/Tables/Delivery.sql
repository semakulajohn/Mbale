CREATE TABLE [dbo].[Delivery]
(
	[DeliveryId] BIGINT IDENTITY(1,1) NOT NULL,	
	[CustomerId] BIGINT not NULL,
	[DriverName]   FLOAT NOT NULL,
	[ProductId]    BIGINT NOT NULL,
	[VehicleNumber] [nvarchar](128) NOT NULL,
	[MediaId]     BIGINT NOT NULL,
	[BranchId]  BIGINT NOT NULL,
	[Location]   [nvarchar](max) not null,
	[Deleted]	[bit] NULL,
	[CreatedBy] [nvarchar](128) NULL, 
    [UpdatedBy] [nvarchar](128) NULL,     
    [DeletedBy] [nvarchar](128) NULL,
	[CreatedOn]	[datetime] NULL,
	[TimeStamp]	[datetime] NOT NULL DEFAULT GETDATE(),	
	[DeletedOn]	[datetime] NULL,

    CONSTRAINT [PK_dbo.Delivery] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
),
CONSTRAINT [FK_Delivery_CustomerId] FOREIGN KEY([CustomerId]) REFERENCES [dbo].[Customer](CustomerId),
CONSTRAINT [FK_Delivery_ProductId] FOREIGN KEY([ProductId]) REFERENCES [dbo].[Product](ProductId),
CONSTRAINT [FK_Delivery_BranchId] FOREIGN KEY([BranchId]) REFERENCES [dbo].[Branch](BranchId),
CONSTRAINT [FK_Delivery_CreatedBy] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_Delivery_UpdatedBy] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_Delivery_DeletedBy] FOREIGN KEY ([DeletedBy]) REFERENCES [dbo].[AspNetUsers](Id),
)ON [PRIMARY]

