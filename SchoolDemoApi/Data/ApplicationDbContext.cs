using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolDemoApi.Data.Models;

namespace SchoolDemoApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AnnBemiscode>(entity =>
            {
                entity.HasKey(e => e.Bemisid)
                    .HasName("PK_AnnualBEMISCodes");

                entity.ToTable("AnnBEMISCodes");

                entity.Property(e => e.Bemisid).HasColumnName("BEMISID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VerifiedBy).HasMaxLength(50);

                entity.Property(e => e.VisitorName).HasMaxLength(50);
            });

            modelBuilder.Entity<AnnBemiscodeDetail>(entity =>
            {
                entity.HasKey(e => e.AnnualBemiscodeDetailId)
                    .HasName("PK_BEMISDetail");

                entity.ToTable("AnnBEMISCodeDetails");

                entity.Property(e => e.AnnualBemiscodeDetailId).HasColumnName("AnnualBEMISCodeDetailID");

                entity.Property(e => e.Bemiscode)
                    .HasMaxLength(50)
                    .HasColumnName("BEMISCode");

                entity.Property(e => e.Bemisid).HasColumnName("BEMISID");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            });

            modelBuilder.Entity<AnnEnrollment>(entity =>
            {
                entity.HasKey(e => e.AnnualEnrolId)
                    .HasName("PK_AnnulErollments");

                entity.Property(e => e.AnnualEnrolId).HasColumnName("AnnualEnrolID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PhotoRegAdmissionWtd).HasColumnName("PhotoRegAdmissionWTD");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VerifiedBy).HasMaxLength(50);

                entity.Property(e => e.VisitorName).HasMaxLength(50);
            });

            modelBuilder.Entity<AnnEnrollmentDetail>(entity =>
            {
                entity.HasKey(e => e.AnnualEnrollmentDetails)
                    .HasName("PK_AnnualClasses");

                entity.Property(e => e.AnnualEnrolId).HasColumnName("AnnualEnrolID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("AppUser");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BLteacher>(entity =>
            {
                entity.ToTable("bLTeachers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updatedDate")
                    .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Bl)
                    .WithMany(p => p.BLteachers)
                    .HasForeignKey(d => d.Blid)
                    .HasConstraintName("FK_BLTeachers_Baselines_BLID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.BLteachers)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_BLTeachers_TeacherPosts_PostID");
            });

            modelBuilder.Entity<Baseline>(entity =>
            {
                entity.HasKey(e => e.Blid);

                entity.Property(e => e.Blid)
                    .ValueGeneratedNever()
                    .HasColumnName("BLID");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.IsLecFormed)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsLecFunctional)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsLecTrained)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsOwnBuilding)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsPtsmc)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsSpace)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsSpacePlayArea)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsSpaceVertical)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.NextLevelDistance).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.PtsmcContact).HasDefaultValueSql("(N'')");

                entity.Property(e => e.PtsmcName).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ptsmcmembers).HasColumnName("PTSMCMembers");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.TeacherContact).HasDefaultValueSql("(N'')");

                entity.Property(e => e.TeacherName).HasDefaultValueSql("(N'')");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updatedDate")
                    .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Verified)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.VerifiedDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.VisitDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.VisitorContact).HasDefaultValueSql("(N'')");

                entity.Property(e => e.VisitorName).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Within3kmHigh).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.Within3kmMiddle).HasDefaultValueSql("(CONVERT([smallint],(0)))");
            });

            modelBuilder.Entity<BaselineEss>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("BaselineEss");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.Laboratory).HasColumnName("laboratory");

                entity.Property(e => e.LandownerAgreedVld).HasColumnName("LandownerAgreedVLD");

                entity.Property(e => e.SchoolSid).HasColumnName("SchoolSID");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.Property(e => e.VisitDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.SchoolS)
                    .WithMany(p => p.BaselineEsses)
                    .HasForeignKey(d => d.SchoolSid);
            });

            modelBuilder.Entity<BaselinePst>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK_BaselinePst1");

                entity.ToTable("BaselinePst");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.BoundaryWallImgTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.BuildingImgTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ClassroomsImgTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.CrackSlabToilet).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.DistanceOfMainPipeline).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DoesViptoilet).HasColumnName("DoesVIPToilet");

                entity.Property(e => e.IsAdditionalItlab).HasColumnName("IsAdditionalITLab");

                entity.Property(e => e.IsEcroom).HasColumnName("IsECRoom");

                entity.Property(e => e.IsItlab).HasColumnName("IsITLab");

                entity.Property(e => e.IsMhmstorageAvailable).HasColumnName("IsMHMStorageAvailable");

                entity.Property(e => e.IsProvideSolarSystem)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsRequiredAdditionalClassRoom)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.IsSolarSystem)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LengthOfBoundaryWall).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PlayAreaImgTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.SiteArea).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SiteLength).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SiteWidth).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ToiletsImgTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ToiletsNeedRepair).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.TotalTgirderRoom).HasColumnName("TotalTGirderRoom");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.Property(e => e.WashImgTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.WaterSourceDistance).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.BaselinePst)
                    .HasForeignKey<BaselinePst>(d => d.Sid);
            });

            modelBuilder.Entity<BaselinePstOld>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK_BaselinePst");

                entity.ToTable("BaselinePstOld");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.Access)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AccessToHandWashArea)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CheckedDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.ConditionOfExistingBoundaryWall)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DismantleRoomsNum).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.DismantleRoomsQty).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.DismentleBoundaryWall).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.DismentleToiletNum).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.DismentleToiletQty).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.DistanceOfMainPipeline).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistanceOfMainWaterConnectionPipeline)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DoesExistingSchoolHaveWaterConnection)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DoesViptoilet).HasColumnName("DoesVIPToilet");

                entity.Property(e => e.DryPitToiletForProposed)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExistingMainGate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalDryPitToilet)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalDryPitToiletForBoys)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalDryPitToiletForGirls)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalPourFlushToilet)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalPourFlushToiletForBoys)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalPourFlushToiletForGirls)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FunctionalViptoilet)
                    .HasMaxLength(10)
                    .HasColumnName("FunctionalVIPToilet")
                    .IsFixedLength();

                entity.Property(e => e.FunctionalViptoiletForBoys)
                    .HasMaxLength(10)
                    .HasColumnName("FunctionalVIPToiletForBoys")
                    .IsFixedLength();

                entity.Property(e => e.FunctionalViptoiletForGirls)
                    .HasMaxLength(10)
                    .HasColumnName("FunctionalVIPToiletForGirls")
                    .IsFixedLength();

                entity.Property(e => e.GateSizeHeight)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GateSizeWidth)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsAdditionalItlab).HasColumnName("IsAdditionalITLab");

                entity.Property(e => e.IsAdditionalPrincipalRoom)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsAdditionalStaffRoom)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsCrackSlabToilet)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDryPitToiletOnRaisedPlatform)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsEcroom).HasColumnName("IsECRoom");

                entity.Property(e => e.IsFlooringForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsHandRailRequiredForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsItlab).HasColumnName("IsITLab");

                entity.Property(e => e.IsLevelingRequiredForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsMhmstorageAvailable).HasColumnName("IsMHMStorageAvailable");

                entity.Property(e => e.IsNearWaterConnectionLocation)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPaintRequiredForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPipelineNearTheSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPlantationAreaRequiredRepairing)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPlasterRequiredForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPourFlushToiletOnRaisedPlatform)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPtclcablePass)
                    .HasMaxLength(10)
                    .HasColumnName("IsPTCLCablePass")
                    .IsFixedLength();

                entity.Property(e => e.IsRainWaterDrain)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsRampRequiredForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsRoofScreedingRequiredForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSeparateDryPitToilets)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSeparatePourFlushToilets)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSeparateViptoilets)
                    .HasMaxLength(10)
                    .HasColumnName("IsSeparateVIPToilets")
                    .IsFixedLength();

                entity.Property(e => e.IsSewerageInPourFlush)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSewerageInVip)
                    .HasMaxLength(10)
                    .HasColumnName("IsSewerageInVIP")
                    .IsFixedLength();

                entity.Property(e => e.IsSewerageOnProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSoakageForProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Latitute).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LengthOfBoundaryWall).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LevelOfProposedSite)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NonFunctionalDryPitToilet)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalDryPitToiletForBoys)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalDryPitToiletForGirls)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalPourFlushToilet)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalPourFlushToiletForBoys)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalPourFlushToiletForGirls)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalViptoilet)
                    .HasMaxLength(10)
                    .HasColumnName("NonFunctionalVIPToilet")
                    .IsFixedLength();

                entity.Property(e => e.NonFunctionalViptoiletForBoys)
                    .HasMaxLength(10)
                    .HasColumnName("NonFunctionalVIPToiletForBoys")
                    .IsFixedLength();

                entity.Property(e => e.SchoolSid).HasColumnName("SchoolSID");

                entity.Property(e => e.SiteArea).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SiteLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SiteWidth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Test).HasColumnName("test");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.Property(e => e.WaterSourceDistance).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SchoolS)
                    .WithMany(p => p.BaselinePstOlds)
                    .HasForeignKey(d => d.SchoolSid)
                    .HasConstraintName("FK_BaselinePst_Schools_SchoolSID");
            });

            modelBuilder.Entity<BaselinePstRoom>(entity =>
            {
                entity.HasKey(e => e.Srid)
                    .HasName("PK_BaselinePstRoom_1");

                entity.ToTable("BaselinePstRoom");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.RoomHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RoomLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RoomWidth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SchoolSid).HasColumnName("SchoolSID");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.SchoolS)
                    .WithMany(p => p.BaselinePstRooms)
                    .HasForeignKey(d => d.SchoolSid);
            });

            modelBuilder.Entity<BlbuildingFacility>(entity =>
            {
                entity.HasKey(e => e.Blid);

                entity.ToTable("BLbuildingFacilities");

                entity.Property(e => e.Blid)
                    .ValueGeneratedNever()
                    .HasColumnName("BLID");

                entity.Property(e => e.DoorsRepair)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.GateRepair)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RoomsKachaFunction).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.RoomsKachaNeedRepair).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.RoomsKachaNonFunction).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.RoomsKachaTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ToiletsBoysFunction).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ToiletsBoysNeedConstruct).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ToiletsBoysNeedRepair).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ToiletsBoysNonFunction).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ToiletsBoysTotal).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.Property(e => e.WindowRepair)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Bl)
                    .WithOne(p => p.BlbuildingFacility)
                    .HasForeignKey<BlbuildingFacility>(d => d.Blid);
            });

            modelBuilder.Entity<BleceComputerLab>(entity =>
            {
                entity.HasKey(e => e.Blid);

                entity.ToTable("BLEceComputerLabs");

                entity.Property(e => e.Blid)
                    .ValueGeneratedNever()
                    .HasColumnName("BLID");

                entity.Property(e => e.ReaLoadShedding)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReaNoComputer)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReaNoElectric)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReaNoTeacher)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReaNoUsingCondition)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReqElectrification)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReqFurniture)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReqNewComputer)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReqRepairLab)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ReqSolarSystem)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.HasOne(d => d.Bl)
                    .WithOne(p => p.BleceComputerLab)
                    .HasForeignKey<BleceComputerLab>(d => d.Blid);
            });

            modelBuilder.Entity<Blenrollment>(entity =>
            {
                entity.ToTable("BLEnrollments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Blid).HasColumnName("BLID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updatedDate")
                    .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Bl)
                    .WithMany(p => p.Blenrollments)
                    .HasForeignKey(d => d.Blid);
            });

            modelBuilder.Entity<BllibraryFurniture>(entity =>
            {
                entity.HasKey(e => e.Blid);

                entity.ToTable("BLLibraryFurnitures");

                entity.Property(e => e.Blid)
                    .ValueGeneratedNever()
                    .HasColumnName("BLID");

                entity.Property(e => e.GilamEce).HasColumnName("GilamECE");

                entity.Property(e => e.GilamEceneeded).HasColumnName("GilamECENeeded");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.HasOne(d => d.Bl)
                    .WithOne(p => p.BllibraryFurniture)
                    .HasForeignKey<BllibraryFurniture>(d => d.Blid);
            });

            modelBuilder.Entity<EssSiting>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("EssSiting");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.HasOne(d => d.SidNavigation)
                    .WithOne(p => p.EssSiting)
                    .HasForeignKey<EssSiting>(d => d.Sid);
            });

            modelBuilder.Entity<Essconstruction>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("ESSConstruction");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.IsEsmpguidelines).HasColumnName("IsESMPGuidelines");

                entity.Property(e => e.IsRiskGbv).HasColumnName("IsRiskGBV");

                entity.Property(e => e.SchoolSid).HasColumnName("SchoolSID");

                entity.Property(e => e.UpdatedDate).HasColumnName("updatedDate");

                entity.HasOne(d => d.SchoolS)
                    .WithMany(p => p.Essconstructions)
                    .HasForeignKey(d => d.SchoolSid);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SID");

                entity.Property(e => e.Bemis).HasColumnName("BEMIS");

                entity.Property(e => e.Blstep)
                    .HasColumnName("BLStep")
                    .HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.ClusterBemis).HasColumnName("ClusterBEMIS");

                entity.Property(e => e.IsIctlab)
                    .IsRequired()
                    .HasColumnName("IsICTLab")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsProjectFocused)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsScienceLab)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsSolar)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Uc).HasColumnName("UC");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");
            });

            modelBuilder.Entity<TeacherPost>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.Property(e => e.PostId)
                    .ValueGeneratedNever()
                    .HasColumnName("PostID");
            });

            modelBuilder.Entity<Tool5>(entity =>
            {
                entity.HasKey(e => new { e.SchoolId, e.Quarter });

                entity.ToTable("Tool5");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.SchoolSid).HasColumnName("SchoolSID");

                entity.HasOne(d => d.SchoolS)
                    .WithMany(p => p.Tool5s)
                    .HasForeignKey(d => d.SchoolSid);
            });

            modelBuilder.Entity<Tool5Detail>(entity =>
            {
                entity.HasKey(e => new { e.SchoolId, e.Quarter, e.ClassId });

                entity.ToTable("Tool5Detail");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.SchoolSid).HasColumnName("SchoolSID");

                entity.HasOne(d => d.SchoolS)
                    .WithMany(p => p.Tool5Details)
                    .HasForeignKey(d => d.SchoolSid);

                entity.HasOne(d => d.Tool5)
                    .WithMany(p => p.Tool5Details)
                    .HasForeignKey(d => new { d.SchoolId, d.Quarter });
            });

        }

        public DbSet<AnnBemiscode> AnnBemiscodes { get; set; }
        public DbSet<AnnBemiscodeDetail> AnnBemiscodeDetails { get; set; }
        public DbSet<AnnEnrollment> AnnEnrollments { get; set; }
        public DbSet<AnnEnrollmentDetail> AnnEnrollmentDetails { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<BLteacher> BLteachers { get; set; }
        public DbSet<Baseline> Baselines { get; set; }
        public DbSet<BaselineEss> BaselineEsses { get; set; }
        public DbSet<BaselinePst> BaselinePsts { get; set; }
        public DbSet<BaselinePstOld> BaselinePstOlds { get; set; }
        public DbSet<BaselinePstRoom> BaselinePstRooms { get; set; }
        public DbSet<BlbuildingFacility> BlbuildingFacilities { get; set; }
        public DbSet<BleceComputerLab> BleceComputerLabs { get; set; }
        public DbSet<Blenrollment> Blenrollments { get; set; }
        public DbSet<BllibraryFurniture> BllibraryFurnitures { get; set; }
        public DbSet<EssSiting> EssSitings { get; set; }
        public DbSet<Essconstruction> Essconstructions { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<TeacherPost> TeacherPosts { get; set; }
        public DbSet<Tool5> Tool5s { get; set; }
        public DbSet<Tool5Detail> Tool5Details { get; set; }
    }
}
