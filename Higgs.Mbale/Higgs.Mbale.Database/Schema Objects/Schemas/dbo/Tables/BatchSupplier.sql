CREATE TABLE [dbo].[BatchSupplier]
(
	[BatchId] BIGINT NOT NULL,
	[SupplierId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.BatchSupplier] PRIMARY KEY CLUSTERED 
(
	[BatchId] ASC,
	[SupplierId] ASC
) 
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[BatchSupplier]  ADD  CONSTRAINT [FK_dbo.BatchSupplier_dbo.Batch_BatchId] FOREIGN KEY([BatchId])
REFERENCES [dbo].[Batch] ([BatchId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BatchSupplier] CHECK CONSTRAINT [FK_dbo.BatchSupplier_dbo.Batch_BatchId]
GO

ALTER TABLE [dbo].[BatchSupplier]  ADD  CONSTRAINT [FK_dbo.BatchSupplier_dbo.AspNetUsers_Id] FOREIGN KEY([SupplierId])
REFERENCES  [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[BatchSupplier] CHECK CONSTRAINT [FK_dbo.BatchSupplier_dbo.AspNetUsers_Id]
GO
