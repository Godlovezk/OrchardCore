using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Data Protection (Azure Storage)",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0",
    Description = "Provides tenant-aware data protection services that targets Azure Blob Storage.",
    Category = "Security",
    Dependencies = new [] {"OrchardCore.DataProtection"}
)]