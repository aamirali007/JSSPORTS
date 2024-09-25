using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SportsOrderApp.Entities;

namespace SportsOrderApp.Data
{
    public partial class JSDBContext : DbContext
    {
        public JSDBContext()
        {
        }

        public JSDBContext(DbContextOptions<JSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<JsTblCategory> JsTblCategories { get; set; } = null!;
        public virtual DbSet<JsTblFabricType> JsTblFabricTypes { get; set; } = null!;
        public virtual DbSet<JsTblInventoryItem> JsTblInventoryItems { get; set; } = null!;
        public virtual DbSet<JsTblInventoryItemCategory> JsTblInventoryItemCategories { get; set; } = null!;
        public virtual DbSet<JsTblMainCategory> JsTblMainCategories { get; set; } = null!;
        public virtual DbSet<JsTblMockup> JsTblMockups { get; set; } = null!;
        public virtual DbSet<JsTblMockupAttachment> JsTblMockupAttachments { get; set; } = null!;
        public virtual DbSet<JsTblMockupDesignStep> JsTblMockupDesignSteps { get; set; } = null!;
        public virtual DbSet<JsTblMockupDesignStepUserRight> JsTblMockupDesignStepUserRights { get; set; } = null!;
        public virtual DbSet<JsTblMockupDesignStepsName> JsTblMockupDesignStepsNames { get; set; } = null!;
        public virtual DbSet<JsTblMockupLog> JsTblMockupLogs { get; set; } = null!;
        public virtual DbSet<JsTblNeckStyle> JsTblNeckStyles { get; set; } = null!;
        public virtual DbSet<JsTblOrderDesignStep> JsTblOrderDesignSteps { get; set; } = null!;
        public virtual DbSet<JsTblOrderDesignStepUserRight> JsTblOrderDesignStepUserRights { get; set; } = null!;
        public virtual DbSet<JsTblOrderDesignStepsName> JsTblOrderDesignStepsNames { get; set; } = null!;
        public virtual DbSet<JsTblPriceList> JsTblPriceLists { get; set; } = null!;
        public virtual DbSet<JsTblProduct> JsTblProducts { get; set; } = null!;
        public virtual DbSet<JsTblProductSizeList> JsTblProductSizeLists { get; set; } = null!;
        public virtual DbSet<JsTblProductSizePriceDetail> JsTblProductSizePriceDetails { get; set; } = null!;
        public virtual DbSet<JsTblProductSizePriceMaster> JsTblProductSizePriceMasters { get; set; } = null!;
        public virtual DbSet<JsTblRole> JsTblRoles { get; set; } = null!;
        public virtual DbSet<JsTblSubCategory> JsTblSubCategories { get; set; } = null!;
        public virtual DbSet<JsTblSupplier> JsTblSuppliers { get; set; } = null!;
        public virtual DbSet<JsTblUser> JsTblUsers { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-H0EFBJV\\AAMIRALI;Database=JSSPORTS;User Id=sports;Password=abc123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.Property(e => e.CityId).HasColumnName("CITY_ID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("CITY_NAME");

                entity.Property(e => e.StateId).HasColumnName("STATE_ID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__CITY__STATE_ID__173876EA");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("COUNTRY");

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .HasColumnName("COUNTRY_NAME");
            });

            modelBuilder.Entity<JsTblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("JS_TBL_CATEGORY");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreadtedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREADTED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.MainCategoryId).HasColumnName("MAIN_CATEGORY_ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.MainCategory)
                    .WithMany(p => p.JsTblCategories)
                    .HasForeignKey(d => d.MainCategoryId)
                    .HasConstraintName("FK_JS_TBL_CATEGORY_JS_TBL_MAIN_CATEGORY");
            });

            modelBuilder.Entity<JsTblFabricType>(entity =>
            {
                entity.HasKey(e => e.FabricTypeId)
                    .HasName("PK__FABRIC_T__9234619E25C51383");

                entity.ToTable("JS_TBL_FABRIC_TYPE");

                entity.Property(e => e.FabricTypeId).HasColumnName("FABRIC_TYPE_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FabricTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("FABRIC_TYPE_NAME");
            });

            modelBuilder.Entity<JsTblInventoryItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__ITEM__ADFD89A074E4DC17");

                entity.ToTable("JS_TBL_INVENTORY_ITEM");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Attribute1).HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11).HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12).HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13).HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14).HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15).HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute2).HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute3).HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4).HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5).HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.Brand).HasColumnName("BRAND");

                entity.Property(e => e.Color).HasColumnName("COLOR");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("COST_PRICE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Dimensions).HasColumnName("DIMENSIONS");

                entity.Property(e => e.ItemCategoryId).HasColumnName("ITEM_CATEGORY_ID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .HasColumnName("ITEM_NAME");

                entity.Property(e => e.Model).HasColumnName("MODEL");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.SellingPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SELLING_PRICE");

                entity.Property(e => e.Size).HasColumnName("SIZE");

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.Upc).HasColumnName("UPC");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("WEIGHT");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.JsTblInventoryItems)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("FK__ITEM__ITEM_CATEG__1BFD2C07");
            });

            modelBuilder.Entity<JsTblInventoryItemCategory>(entity =>
            {
                entity.HasKey(e => e.ItemCategoryId)
                    .HasName("PK__ITEM_CAT__46B09944F7E852CD");

                entity.ToTable("JS_TBL_INVENTORY_ITEM_CATEGORY");

                entity.Property(e => e.ItemCategoryId).HasColumnName("ITEM_CATEGORY_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Attribute1).HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11).HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12).HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13).HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14).HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15).HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute2).HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute3).HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4).HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5).HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.ItemCategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("ITEM_CATEGORY_NAME");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");
            });

            modelBuilder.Entity<JsTblMainCategory>(entity =>
            {
                entity.HasKey(e => e.MainCategoryId);

                entity.ToTable("JS_TBL_MAIN_CATEGORY");

                entity.Property(e => e.MainCategoryId).HasColumnName("MAIN_CATEGORY_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreadtedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREADTED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<JsTblMockup>(entity =>
            {
                entity.HasKey(e => e.MockupId);

                entity.ToTable("JS_TBL_MOCKUP");

                entity.Property(e => e.MockupId).HasColumnName("MOCKUP_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BackDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BACK_DESCRIPTION");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.FabricTypeId).HasColumnName("FABRIC_TYPE_ID");

                entity.Property(e => e.FrontDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_DESCRIPTION");

                entity.Property(e => e.LeftSleeveDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LEFT_SLEEVE_DESC");

                entity.Property(e => e.MainCategoryId).HasColumnName("MAIN_CATEGORY_ID");

                entity.Property(e => e.MockupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOCKUP_CODE");

                entity.Property(e => e.MockupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOCKUP_NAME");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NeckStyleId).HasColumnName("NECK_STYLE_ID");

                entity.Property(e => e.OnlyDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ONLY_DESC");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.RightSleeveDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RIGHT_SLEEVE_DESC");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB_CATEGORY_ID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEAM_NAME");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_CATEGORY");

                entity.HasOne(d => d.FabricType)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.FabricTypeId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_FABRIC_TYPE");

                entity.HasOne(d => d.MainCategory)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.MainCategoryId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_MAIN_CATEGORY");

                entity.HasOne(d => d.NeckStyle)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.NeckStyleId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_NECK_STYLE");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_PRODUCT");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_SUB_CATEGORY");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JsTblMockups)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_JS_TBL_USER");
            });

            modelBuilder.Entity<JsTblMockupAttachment>(entity =>
            {
                entity.HasKey(e => e.MockupAttachmentId);

                entity.ToTable("JS_TBL_MOCKUP_ATTACHMENTS");

                entity.Property(e => e.MockupAttachmentId).HasColumnName("MOCKUP_ATTACHMENT_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BackImageData)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("BACK_IMAGE_DATA");

                entity.Property(e => e.BackImagePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BACK_IMAGE_PATH");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.FrontImageData)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_IMAGE_DATA");

                entity.Property(e => e.FrontImagePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_IMAGE_PATH");

                entity.Property(e => e.LeftSleeveImageData)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("LEFT_SLEEVE_IMAGE_DATA");

                entity.Property(e => e.LeftSleeveImagePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEFT_SLEEVE_IMAGE_PATH");

                entity.Property(e => e.MockupId).HasColumnName("MOCKUP_ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.RightSleeveImageData)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("RIGHT_SLEEVE_IMAGE_DATA");

                entity.Property(e => e.RightSleeveImagePath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RIGHT_SLEEVE_IMAGE_PATH");

                entity.Property(e => e.Side)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIDE");

                entity.HasOne(d => d.Mockup)
                    .WithMany(p => p.JsTblMockupAttachments)
                    .HasForeignKey(d => d.MockupId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_ATTACHMENTS_JS_TBL_MOCKUP");
            });

            modelBuilder.Entity<JsTblMockupDesignStep>(entity =>
            {
                entity.HasKey(e => e.MockupStepsId)
                    .HasName("PK_JS_TBL_MOCKUP_DESIGN_STEPS_1");

                entity.ToTable("JS_TBL_MOCKUP_DESIGN_STEPS");

                entity.Property(e => e.MockupStepsId).HasColumnName("MOCKUP_STEPS_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.FromMockupDesignStepId).HasColumnName("FROM_MOCKUP_DESIGN_STEP_ID");

                entity.Property(e => e.IsDesign).HasColumnName("IS_DESIGN");

                entity.Property(e => e.IsMockup).HasColumnName("IS_MOCKUP");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ToMockupDesignStepId).HasColumnName("TO_MOCKUP_DESIGN_STEP_ID");

                entity.HasOne(d => d.FromMockupDesignStep)
                    .WithMany(p => p.JsTblMockupDesignStepFromMockupDesignSteps)
                    .HasForeignKey(d => d.FromMockupDesignStepId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_DESIGN_STEPS_JS_TBL_MOCKUP_DESIGN_STEPS_NAME");

                entity.HasOne(d => d.ToMockupDesignStep)
                    .WithMany(p => p.JsTblMockupDesignStepToMockupDesignSteps)
                    .HasForeignKey(d => d.ToMockupDesignStepId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_DESIGN_STEPS_JS_TBL_MOCKUP_DESIGN_STEPS_NAME1");
            });

            modelBuilder.Entity<JsTblMockupDesignStepUserRight>(entity =>
            {
                entity.HasKey(e => e.MockupDesignStepRightId);

                entity.ToTable("JS_TBL_MOCKUP_DESIGN_STEP_USER_RIGHT");

                entity.Property(e => e.MockupDesignStepRightId).HasColumnName("MOCKUP_DESIGN_STEP_RIGHT_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.MockupStepsId).HasColumnName("MOCKUP_STEPS_ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.MockupSteps)
                    .WithMany(p => p.JsTblMockupDesignStepUserRights)
                    .HasForeignKey(d => d.MockupStepsId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_DESIGN_STEP_USER_RIGHT_JS_TBL_MOCKUP_DESIGN_STEPS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JsTblMockupDesignStepUserRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_DESIGN_STEP_USER_RIGHT_JS_TBL_USER");
            });

            modelBuilder.Entity<JsTblMockupDesignStepsName>(entity =>
            {
                entity.HasKey(e => e.MockupDesignStepId)
                    .HasName("PK_JS_TBL_MOCKUP_DESIGN_STEPS");

                entity.ToTable("JS_TBL_MOCKUP_DESIGN_STEPS_NAME");

                entity.Property(e => e.MockupDesignStepId).HasColumnName("MOCKUP_DESIGN_STEP_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ButtonDisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUTTON_DISPLAY_NAME");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.IsDesgin).HasColumnName("IS_DESGIN");

                entity.Property(e => e.IsMockup).HasColumnName("IS_MOCKUP");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<JsTblMockupLog>(entity =>
            {
                entity.HasKey(e => e.MockupLogId);

                entity.ToTable("JS_TBL_MOCKUP_LOG");

                entity.Property(e => e.MockupLogId).HasColumnName("MOCKUP_LOG_ID");

                entity.Property(e => e.ClientUserId).HasColumnName("CLIENT_USER_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.HostUserId).HasColumnName("HOST_USER_ID");

                entity.Property(e => e.LogDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LOG_DATE_TIME");

                entity.Property(e => e.MockupId).HasColumnName("MOCKUP_ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.JsTblMockupLogClientUsers)
                    .HasForeignKey(d => d.ClientUserId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_LOG_JS_TBL_USER");

                entity.HasOne(d => d.HostUser)
                    .WithMany(p => p.JsTblMockupLogHostUsers)
                    .HasForeignKey(d => d.HostUserId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_LOG_JS_TBL_USER1");

                entity.HasOne(d => d.Mockup)
                    .WithMany(p => p.JsTblMockupLogs)
                    .HasForeignKey(d => d.MockupId)
                    .HasConstraintName("FK_JS_TBL_MOCKUP_LOG_JS_TBL_MOCKUP");
            });

            modelBuilder.Entity<JsTblNeckStyle>(entity =>
            {
                entity.HasKey(e => e.NeckStyleId)
                    .HasName("PK__NECK_STY__DADE11C4C880D8BA");

                entity.ToTable("JS_TBL_NECK_STYLE");

                entity.Property(e => e.NeckStyleId).HasColumnName("NECK_STYLE_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.NeckStyleName)
                    .HasMaxLength(100)
                    .HasColumnName("NECK_STYLE_NAME");
            });

            modelBuilder.Entity<JsTblOrderDesignStep>(entity =>
            {
                entity.HasKey(e => e.OrderStepsId);

                entity.ToTable("JS_TBL_ORDER_DESIGN_STEPS");

                entity.Property(e => e.OrderStepsId).HasColumnName("ORDER_STEPS_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.FromOrderDesignStepId).HasColumnName("FROM_ORDER_DESIGN_STEP_ID");

                entity.Property(e => e.IsDesign).HasColumnName("IS_DESIGN");

                entity.Property(e => e.IsMockup).HasColumnName("IS_MOCKUP");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ToOrderDesignStepId).HasColumnName("TO_ORDER_DESIGN_STEP_ID");

                entity.HasOne(d => d.FromOrderDesignStep)
                    .WithMany(p => p.JsTblOrderDesignStepFromOrderDesignSteps)
                    .HasForeignKey(d => d.FromOrderDesignStepId)
                    .HasConstraintName("FK_JS_TBL_ORDER_DESIGN_STEPS_JS_TBL_ORDER_DESIGN_STEPS_NAME");

                entity.HasOne(d => d.ToOrderDesignStep)
                    .WithMany(p => p.JsTblOrderDesignStepToOrderDesignSteps)
                    .HasForeignKey(d => d.ToOrderDesignStepId)
                    .HasConstraintName("FK_JS_TBL_ORDER_DESIGN_STEPS_JS_TBL_ORDER_DESIGN_STEPS_NAME1");
            });

            modelBuilder.Entity<JsTblOrderDesignStepUserRight>(entity =>
            {
                entity.HasKey(e => e.OrderDesignStepRightId);

                entity.ToTable("JS_TBL_ORDER_DESIGN_STEP_USER_RIGHT");

                entity.Property(e => e.OrderDesignStepRightId).HasColumnName("ORDER_DESIGN_STEP_RIGHT_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.OrderStepsId).HasColumnName("ORDER_STEPS_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JsTblOrderDesignStepUserRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_JS_TBL_ORDER_DESIGN_STEP_USER_RIGHT_JS_TBL_USER");
            });

            modelBuilder.Entity<JsTblOrderDesignStepsName>(entity =>
            {
                entity.HasKey(e => e.OrderDesignStepId);

                entity.ToTable("JS_TBL_ORDER_DESIGN_STEPS_NAME");

                entity.Property(e => e.OrderDesignStepId).HasColumnName("ORDER_DESIGN_STEP_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ButtonDisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUTTON_DISPLAY_NAME");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.IsDesgin).HasColumnName("IS_DESGIN");

                entity.Property(e => e.IsMockup).HasColumnName("IS_MOCKUP");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<JsTblPriceList>(entity =>
            {
                entity.HasKey(e => e.PriceListId);

                entity.ToTable("JS_TBL_PRICE_LIST");

                entity.Property(e => e.PriceListId).HasColumnName("PRICE_LIST_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DISCOUNT");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFECTIVE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.RushAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RUSH_AMOUNT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.JsTblPriceLists)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_JS_TBL_PRICE_LIST_JS_TBL_PRODUCT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JsTblPriceLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_JS_TBL_PRICE_LIST_JS_TBL_USER");
            });

            modelBuilder.Entity<JsTblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("JS_TBL_PRODUCT");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BackImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BACK_IMAGE");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FrontImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_IMAGE");

                entity.Property(e => e.IsBackDesc).HasColumnName("IS_BACK_DESC");

                entity.Property(e => e.IsBackImage).HasColumnName("IS_BACK_IMAGE");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.IsFrontDesc).HasColumnName("IS_FRONT_DESC");

                entity.Property(e => e.IsFrontImage).HasColumnName("IS_FRONT_IMAGE");

                entity.Property(e => e.IsLeftSleeveDesc).HasColumnName("IS_LEFT_SLEEVE_DESC");

                entity.Property(e => e.IsLeftSleeveImage).HasColumnName("IS_LEFT_SLEEVE_IMAGE");

                entity.Property(e => e.IsNeck).HasColumnName("IS_NECK");

                entity.Property(e => e.IsOnlyDesc).HasColumnName("IS_ONLY_DESC");

                entity.Property(e => e.IsRightSleeveDesc).HasColumnName("IS_RIGHT_SLEEVE_DESC");

                entity.Property(e => e.IsRightSleeveImage).HasColumnName("IS_RIGHT_SLEEVE_IMAGE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB_CATEGORY_ID");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.JsTblProducts)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_JS_TBL_PRODUCT_JS_TBL_SUB_CATEGORY");
            });

            modelBuilder.Entity<JsTblProductSizeList>(entity =>
            {
                entity.HasKey(e => e.ProductSizeId);

                entity.ToTable("JS_TBL_PRODUCT_SIZE_LIST");

                entity.Property(e => e.ProductSizeId).HasColumnName("PRODUCT_SIZE_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IsOverSize).HasColumnName("IS_OVER_SIZE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<JsTblProductSizePriceDetail>(entity =>
            {
                entity.HasKey(e => e.SizePriceId);

                entity.ToTable("JS_TBL_PRODUCT_SIZE_PRICE_DETAIL");

                entity.Property(e => e.SizePriceId).HasColumnName("SIZE_PRICE_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DISCOUNT");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ProductSizeId).HasColumnName("PRODUCT_SIZE_ID");

                entity.Property(e => e.SizePriceHeaderId).HasColumnName("SIZE_PRICE_HEADER_ID");

                entity.HasOne(d => d.ProductSize)
                    .WithMany(p => p.JsTblProductSizePriceDetails)
                    .HasForeignKey(d => d.ProductSizeId)
                    .HasConstraintName("FK_JS_TBL_PRODUCT_SIZE_PRICE_DETAIL_JS_TBL_PRODUCT_SIZE_LIST");

                entity.HasOne(d => d.SizePriceHeader)
                    .WithMany(p => p.JsTblProductSizePriceDetails)
                    .HasForeignKey(d => d.SizePriceHeaderId)
                    .HasConstraintName("FK_JS_TBL_PRODUCT_SIZE_PRICE_DETAIL_JS_TBL_PRODUCT_SIZE_PRICE_MASTER");
            });

            modelBuilder.Entity<JsTblProductSizePriceMaster>(entity =>
            {
                entity.HasKey(e => e.SizePriceHeaderId);

                entity.ToTable("JS_TBL_PRODUCT_SIZE_PRICE_MASTER");

                entity.Property(e => e.SizePriceHeaderId).HasColumnName("SIZE_PRICE_HEADER_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFECTIVE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.JsTblProductSizePriceMasters)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_JS_TBL_PRODUCT_SIZE_PRICE_MASTER_JS_TBL_PRODUCT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JsTblProductSizePriceMasters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_JS_TBL_PRODUCT_SIZE_PRICE_MASTER_JS_TBL_USER");
            });

            modelBuilder.Entity<JsTblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("JS_TBL_ROLE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<JsTblSubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId);

                entity.ToTable("JS_TBL_SUB_CATEGORY");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB_CATEGORY_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.JsTblSubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_JS_TBL_SUB_CATEGORY_JS_TBL_CATEGORY");
            });

            modelBuilder.Entity<JsTblSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK__SUPPLIER__88565CC1AD478C29");

                entity.ToTable("JS_TBL_SUPPLIER");

                entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESS1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESS2");

                entity.Property(e => e.Attribute1).HasColumnName("ATTRIBUTE1");

                entity.Property(e => e.Attribute10)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE10");

                entity.Property(e => e.Attribute11).HasColumnName("ATTRIBUTE11");

                entity.Property(e => e.Attribute12).HasColumnName("ATTRIBUTE12");

                entity.Property(e => e.Attribute13).HasColumnName("ATTRIBUTE13");

                entity.Property(e => e.Attribute14).HasColumnName("ATTRIBUTE14");

                entity.Property(e => e.Attribute15).HasColumnName("ATTRIBUTE15");

                entity.Property(e => e.Attribute2).HasColumnName("ATTRIBUTE2");

                entity.Property(e => e.Attribute3).HasColumnName("ATTRIBUTE3");

                entity.Property(e => e.Attribute4).HasColumnName("ATTRIBUTE4");

                entity.Property(e => e.Attribute5).HasColumnName("ATTRIBUTE5");

                entity.Property(e => e.Attribute6)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE6");

                entity.Property(e => e.Attribute7)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE7");

                entity.Property(e => e.Attribute8)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE8");

                entity.Property(e => e.Attribute9)
                    .HasMaxLength(50)
                    .HasColumnName("ATTRIBUTE9");

                entity.Property(e => e.CityId).HasColumnName("CITY_ID");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("COMPANY_NAME");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT_NAME");

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT_TITLE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL2");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILE_NO");

                entity.Property(e => e.MobileNo2)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILE_NO2");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NtnNo)
                    .HasMaxLength(50)
                    .HasColumnName("NTN_NO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE2");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .HasColumnName("STREET");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.JsTblSuppliers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__SUPPLIER__CITY_I__24927208");
            });

            modelBuilder.Entity<JsTblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("JS_TBL_USER");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ApiKey)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("API_KEY");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.IdCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_CARD_NO");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_2");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NATIONALITY");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_2");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.Salt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SALT");

                entity.Property(e => e.Sso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSO");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_TYPE");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.JsTblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_JS_TBL_USER_JS_TBL_ROLE");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("STATE");

                entity.Property(e => e.StateId).HasColumnName("STATE_ID");

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .HasColumnName("STATE_NAME");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__STATE__COUNTRY_I__145C0A3F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
