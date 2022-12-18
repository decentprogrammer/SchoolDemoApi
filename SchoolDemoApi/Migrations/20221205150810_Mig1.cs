using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDemoApi.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnnBEMISCodeDetails",
                columns: table => new
                {
                    AnnualBEMISCodeDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<int>(type: "int", nullable: false),
                    BEMISID = table.Column<int>(type: "int", nullable: false),
                    BEMISCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BEMISDetail", x => x.AnnualBEMISCodeDetailID);
                });

            migrationBuilder.CreateTable(
                name: "AnnBEMISCodes",
                columns: table => new
                {
                    BEMISID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    ProjectYear = table.Column<short>(type: "smallint", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    UserID = table.Column<short>(type: "smallint", nullable: false),
                    VisitorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReCollectData = table.Column<bool>(type: "bit", nullable: true),
                    Verified = table.Column<bool>(type: "bit", nullable: true),
                    VerifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualBEMISCodes", x => x.BEMISID);
                });

            migrationBuilder.CreateTable(
                name: "AnnEnrollmentDetails",
                columns: table => new
                {
                    AnnualEnrollmentDetails = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnualEnrolID = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrollGirls = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrollBoys = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrollTotal = table.Column<short>(type: "smallint", nullable: false),
                    AttendRegGirls = table.Column<short>(type: "smallint", nullable: true),
                    AttendRegBoys = table.Column<short>(type: "smallint", nullable: true),
                    AttendRegTotal = table.Column<short>(type: "smallint", nullable: true),
                    AttendRegPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualClasses", x => x.AnnualEnrollmentDetails);
                });

            migrationBuilder.CreateTable(
                name: "AnnEnrollments",
                columns: table => new
                {
                    AnnualEnrolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<short>(type: "smallint", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ProjectYear = table.Column<short>(type: "smallint", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    VisitorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhotoRegAdmissionWTD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecollectData = table.Column<bool>(type: "bit", nullable: true),
                    Verified = table.Column<bool>(type: "bit", nullable: true),
                    VerifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnulErollments", x => x.AnnualEnrolID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baselines",
                columns: table => new
                {
                    BLID = table.Column<short>(type: "smallint", nullable: false),
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    TeacherContact = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    PtsmcName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    PtsmcContact = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    VisitorContact = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    PTSMCMembers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Within3kmPrimary = table.Column<short>(type: "smallint", nullable: false),
                    NextLevelDistance = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    NextLevelSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    IsCommunityWilling = table.Column<bool>(type: "bit", nullable: true),
                    IsLandAvailable = table.Column<bool>(type: "bit", nullable: true),
                    IsOwnBuilding = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsSpace = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsSpacePlayArea = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    Within3kmHigh = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    Within3kmMiddle = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    IsPtsmc = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsPtsmcFunctional = table.Column<bool>(type: "bit", nullable: true),
                    IsPtsmcTrained = table.Column<bool>(type: "bit", nullable: true),
                    NonFuntionalReasion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    IsLecFormed = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsLecFunctional = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsLecTrained = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsSpaceVertical = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    OtherReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verified = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    FunctionalReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baselines", x => x.BLID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    BEMIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tehsil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterBEMIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BLStep = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    IsICTLab = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsProjectFocused = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsScienceLab = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsSolar = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SID);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "TeacherPosts",
                columns: table => new
                {
                    PostID = table.Column<short>(type: "smallint", nullable: false),
                    PostName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostFullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPosts", x => x.PostID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BLbuildingFacilities",
                columns: table => new
                {
                    BLID = table.Column<short>(type: "smallint", nullable: false),
                    RoomsTotal = table.Column<short>(type: "smallint", nullable: false),
                    RoomsFunction = table.Column<short>(type: "smallint", nullable: false),
                    RoomsNonFunction = table.Column<short>(type: "smallint", nullable: false),
                    RoomsNeedConstruct = table.Column<short>(type: "smallint", nullable: false),
                    RoomsNeedRepair = table.Column<short>(type: "smallint", nullable: false),
                    ToiletsTotal = table.Column<short>(type: "smallint", nullable: false),
                    ToiletsFunction = table.Column<short>(type: "smallint", nullable: false),
                    ToiletsNonFunction = table.Column<short>(type: "smallint", nullable: false),
                    ToiletsNeedConstruct = table.Column<short>(type: "smallint", nullable: false),
                    ToiletsNeedRepair = table.Column<short>(type: "smallint", nullable: false),
                    PlayArea = table.Column<bool>(type: "bit", nullable: false),
                    Boundrywall = table.Column<bool>(type: "bit", nullable: true),
                    BoundrywallNew = table.Column<bool>(type: "bit", nullable: true),
                    WindowRepair = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    DoorsRepair = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    GateRepair = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsWater = table.Column<bool>(type: "bit", nullable: false),
                    WaterFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsElectricity = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricityInArea = table.Column<bool>(type: "bit", nullable: true),
                    IsGas = table.Column<bool>(type: "bit", nullable: false),
                    IsGasInArea = table.Column<bool>(type: "bit", nullable: true),
                    IsWaterTank = table.Column<bool>(type: "bit", nullable: false),
                    WaterTankType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWaterTankNeeded = table.Column<bool>(type: "bit", nullable: true),
                    IsPump = table.Column<bool>(type: "bit", nullable: true),
                    IsPumpFunctional = table.Column<bool>(type: "bit", nullable: true),
                    IsPumpNeeded = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomsKachaFunction = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    RoomsKachaNeedRepair = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    RoomsKachaNonFunction = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    RoomsKachaTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    ToiletsBoysFunction = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    ToiletsBoysNeedConstruct = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    ToiletsBoysNeedRepair = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    ToiletsBoysTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    WaterFacilityOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToiletsBoysNonFunction = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLbuildingFacilities", x => x.BLID);
                    table.ForeignKey(
                        name: "FK_BLbuildingFacilities_Baselines_BLID",
                        column: x => x.BLID,
                        principalTable: "Baselines",
                        principalColumn: "BLID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BLEceComputerLabs",
                columns: table => new
                {
                    BLID = table.Column<short>(type: "smallint", nullable: false),
                    IsEce = table.Column<bool>(type: "bit", nullable: false),
                    IsEceTeacher = table.Column<bool>(type: "bit", nullable: false),
                    IsEceTeacherTrained = table.Column<bool>(type: "bit", nullable: true),
                    IsEceMaterial = table.Column<bool>(type: "bit", nullable: false),
                    IsEceMaterialUsing = table.Column<bool>(type: "bit", nullable: true),
                    IsAssessment = table.Column<bool>(type: "bit", nullable: false),
                    AssessmentFrequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVisitBaec = table.Column<bool>(type: "bit", nullable: false),
                    VisitPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsComputerLab = table.Column<bool>(type: "bit", nullable: false),
                    IsComputerLabFunctional = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReaNoComputer = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReaNoTeacher = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReaNoUsingCondition = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReqElectrification = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReqFurniture = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReqNewComputer = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReaLoadShedding = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReqRepairLab = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    ReqSolarSystem = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    WorkingComputers = table.Column<short>(type: "smallint", nullable: true),
                    ReaNoElectric = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLEceComputerLabs", x => x.BLID);
                    table.ForeignKey(
                        name: "FK_BLEceComputerLabs_Baselines_BLID",
                        column: x => x.BLID,
                        principalTable: "Baselines",
                        principalColumn: "BLID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BLEnrollments",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BLID = table.Column<short>(type: "smallint", nullable: false),
                    ClassID = table.Column<short>(type: "smallint", nullable: false),
                    EnrollBoys = table.Column<short>(type: "smallint", nullable: false),
                    EnrollGirls = table.Column<short>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLEnrollments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BLEnrollments_Baselines_BLID",
                        column: x => x.BLID,
                        principalTable: "Baselines",
                        principalColumn: "BLID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BLLibraryFurnitures",
                columns: table => new
                {
                    BLID = table.Column<short>(type: "smallint", nullable: false),
                    IsLibrary = table.Column<bool>(type: "bit", nullable: false),
                    IsLibraryFunctional = table.Column<bool>(type: "bit", nullable: true),
                    LibReaNoBooks = table.Column<bool>(type: "bit", nullable: false),
                    LibReaNoFurniture = table.Column<bool>(type: "bit", nullable: false),
                    LibReaNoIncharge = table.Column<bool>(type: "bit", nullable: false),
                    LibSugElectrification = table.Column<bool>(type: "bit", nullable: false),
                    LibSugFurniture = table.Column<bool>(type: "bit", nullable: false),
                    LibSugRepair = table.Column<bool>(type: "bit", nullable: false),
                    IsLab = table.Column<bool>(type: "bit", nullable: false),
                    IsLabFunctional = table.Column<bool>(type: "bit", nullable: true),
                    LabReaNoItem = table.Column<bool>(type: "bit", nullable: false),
                    LabReaNoRoom = table.Column<bool>(type: "bit", nullable: false),
                    LabReaNoFurniture = table.Column<bool>(type: "bit", nullable: false),
                    LabReaNoTeacher = table.Column<bool>(type: "bit", nullable: false),
                    LabSugNewItem = table.Column<bool>(type: "bit", nullable: false),
                    LabSugElectrification = table.Column<bool>(type: "bit", nullable: false),
                    LabSugFurniture = table.Column<bool>(type: "bit", nullable: false),
                    LabSugRepair = table.Column<bool>(type: "bit", nullable: false),
                    Desks = table.Column<short>(type: "smallint", nullable: false),
                    MultipurposeTables = table.Column<short>(type: "smallint", nullable: false),
                    ArmChairs = table.Column<short>(type: "smallint", nullable: false),
                    GilamECE = table.Column<short>(type: "smallint", nullable: false),
                    DesksNeeded = table.Column<short>(type: "smallint", nullable: false),
                    MultipurposeTablesNeeded = table.Column<short>(type: "smallint", nullable: false),
                    ArmChairsNeeded = table.Column<short>(type: "smallint", nullable: false),
                    GilamECENeeded = table.Column<short>(type: "smallint", nullable: false),
                    TeacherChair = table.Column<short>(type: "smallint", nullable: false),
                    TeacherChairNeeded = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLLibraryFurnitures", x => x.BLID);
                    table.ForeignKey(
                        name: "FK_BLLibraryFurnitures_Baselines_BLID",
                        column: x => x.BLID,
                        principalTable: "Baselines",
                        principalColumn: "BLID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaselineEss",
                columns: table => new
                {
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    SignificantLandDisturbance = table.Column<bool>(type: "bit", nullable: true),
                    DestructionVegetation = table.Column<bool>(type: "bit", nullable: true),
                    EncroachmentUrban = table.Column<bool>(type: "bit", nullable: true),
                    RequiresRawMaterials = table.Column<bool>(type: "bit", nullable: true),
                    GenerateConstructionMaterial = table.Column<bool>(type: "bit", nullable: true),
                    ResidualWastes = table.Column<bool>(type: "bit", nullable: true),
                    SoilErosion = table.Column<bool>(type: "bit", nullable: true),
                    SoilWaterContamination = table.Column<bool>(type: "bit", nullable: true),
                    ContaminatioGroundWater = table.Column<bool>(type: "bit", nullable: true),
                    ContaminationSurfaceWater = table.Column<bool>(type: "bit", nullable: true),
                    UseOfChemicals = table.Column<bool>(type: "bit", nullable: true),
                    ContaminationSoil = table.Column<bool>(type: "bit", nullable: true),
                    StagnantWaterBodies = table.Column<bool>(type: "bit", nullable: true),
                    HarmfulAirEmissions = table.Column<bool>(type: "bit", nullable: true),
                    AmbientNoiseLevels = table.Column<bool>(type: "bit", nullable: true),
                    TransportHazardous = table.Column<bool>(type: "bit", nullable: true),
                    DisturbanceDrainageChannels = table.Column<bool>(type: "bit", nullable: true),
                    DestructionWildlife = table.Column<bool>(type: "bit", nullable: true),
                    UnplannedInfrastructure = table.Column<bool>(type: "bit", nullable: true),
                    ErosionLand = table.Column<bool>(type: "bit", nullable: true),
                    CulturalSites = table.Column<bool>(type: "bit", nullable: true),
                    Archaeological = table.Column<bool>(type: "bit", nullable: true),
                    ReligiousMonuments = table.Column<bool>(type: "bit", nullable: true),
                    DemolitionExistingStructures = table.Column<bool>(type: "bit", nullable: true),
                    SocialDisruption = table.Column<bool>(type: "bit", nullable: true),
                    EnvironmentalSocialDisturbance = table.Column<bool>(type: "bit", nullable: true),
                    AffectIncomeLevels = table.Column<bool>(type: "bit", nullable: true),
                    ReduceAccessSchool = table.Column<bool>(type: "bit", nullable: true),
                    EnvironmentalSocialImpacts = table.Column<bool>(type: "bit", nullable: true),
                    ImpactWomen = table.Column<bool>(type: "bit", nullable: true),
                    IncreaseSocialInequalities = table.Column<bool>(type: "bit", nullable: true),
                    ImpactsEthnicGroups = table.Column<bool>(type: "bit", nullable: true),
                    ChallengesEngagingWomen = table.Column<bool>(type: "bit", nullable: true),
                    AttractForcedLabor = table.Column<bool>(type: "bit", nullable: true),
                    OverloadSocialInfrastructure = table.Column<bool>(type: "bit", nullable: true),
                    ResettlementPopulation = table.Column<bool>(type: "bit", nullable: true),
                    laboratory = table.Column<bool>(type: "bit", nullable: true),
                    LabFunctional = table.Column<bool>(type: "bit", nullable: true),
                    LabVentilated = table.Column<bool>(type: "bit", nullable: true),
                    LabWaste = table.Column<bool>(type: "bit", nullable: true),
                    LabWasteDispose = table.Column<bool>(type: "bit", nullable: true),
                    RequireLandAcquisition = table.Column<bool>(type: "bit", nullable: true),
                    LandDonatedVoluntarily = table.Column<bool>(type: "bit", nullable: true),
                    OwnerAwareDonation = table.Column<bool>(type: "bit", nullable: true),
                    NotMoreThan10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PossionOnePerson = table.Column<bool>(type: "bit", nullable: true),
                    LandownerAgreedVLD = table.Column<bool>(type: "bit", nullable: true),
                    VldSignedAll = table.Column<bool>(type: "bit", nullable: true),
                    ContestedOwnership = table.Column<bool>(type: "bit", nullable: true),
                    SecurityProblems = table.Column<bool>(type: "bit", nullable: true),
                    NaturalReserves = table.Column<bool>(type: "bit", nullable: true),
                    GroundWaterSource = table.Column<bool>(type: "bit", nullable: true),
                    SurfaceWaterBodies = table.Column<bool>(type: "bit", nullable: true),
                    WaterCourses = table.Column<bool>(type: "bit", nullable: true),
                    Wetlands = table.Column<bool>(type: "bit", nullable: true),
                    RefugeesSettled = table.Column<bool>(type: "bit", nullable: true),
                    WasteDump = table.Column<bool>(type: "bit", nullable: true),
                    AccessPotableWater = table.Column<bool>(type: "bit", nullable: true),
                    WastewaterNetwork = table.Column<bool>(type: "bit", nullable: true),
                    One2KmAccessible = table.Column<bool>(type: "bit", nullable: true),
                    VisitedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchoolSID = table.Column<short>(type: "smallint", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    ItLab = table.Column<bool>(type: "bit", nullable: true),
                    ItLabFire = table.Column<bool>(type: "bit", nullable: true),
                    ItLabVentilated = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineEss", x => x.SID);
                    table.ForeignKey(
                        name: "FK_BaselineEss_Schools_SchoolSID",
                        column: x => x.SchoolSID,
                        principalTable: "Schools",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "BaselinePst",
                columns: table => new
                {
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    Elevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitute = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    SeismicZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfExistingSchoolStructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapeOfProposedSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteLength = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SiteWidth = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SiteArea = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsDismantlingRequired = table.Column<bool>(type: "bit", nullable: false),
                    DismantleRoomsNum = table.Column<short>(type: "smallint", nullable: false),
                    DismantleRoomsQty = table.Column<short>(type: "smallint", nullable: false),
                    DismentleToiletNum = table.Column<short>(type: "smallint", nullable: false),
                    DismentleToiletQty = table.Column<short>(type: "smallint", nullable: false),
                    DismentleBoundaryWall = table.Column<short>(type: "smallint", nullable: false),
                    IsBoundaryWall = table.Column<bool>(type: "bit", nullable: false),
                    BoundryWallType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRepairRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsNewBoundaryWallRequired = table.Column<bool>(type: "bit", nullable: false),
                    LengthOfBoundaryWall = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsMainGate = table.Column<bool>(type: "bit", nullable: false),
                    IsRepairRequiredMainGate = table.Column<bool>(type: "bit", nullable: false),
                    IsNeedNewGate = table.Column<bool>(type: "bit", nullable: false),
                    TotalPakkaRoom = table.Column<int>(type: "int", nullable: false),
                    TotalKachaRoom = table.Column<int>(type: "int", nullable: false),
                    IsStaffRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsPrincipalRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsMultiPurposeHall = table.Column<bool>(type: "bit", nullable: false),
                    IsITLab = table.Column<bool>(type: "bit", nullable: false),
                    IsLibrary = table.Column<bool>(type: "bit", nullable: false),
                    IsLaboratory = table.Column<bool>(type: "bit", nullable: false),
                    IsMultipurposePlayArea = table.Column<bool>(type: "bit", nullable: false),
                    IsRamp = table.Column<bool>(type: "bit", nullable: false),
                    IsPlantationArea = table.Column<bool>(type: "bit", nullable: false),
                    IsMHMStorageAvailable = table.Column<bool>(type: "bit", nullable: false),
                    TotalRequiredAdditionalClassRoom = table.Column<short>(type: "smallint", nullable: false),
                    IsAdditionalMultiPurposeHall = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalITLab = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalLibrary = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalLaboratory = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalMultipurposePlayArea = table.Column<bool>(type: "bit", nullable: false),
                    IsECRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricity = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricityRepair = table.Column<bool>(type: "bit", nullable: false),
                    IsProvideElectricityConnection = table.Column<bool>(type: "bit", nullable: false),
                    DoesExistGasPipeline = table.Column<bool>(type: "bit", nullable: false),
                    IsPossibleToProvideGasConnection = table.Column<bool>(type: "bit", nullable: false),
                    DistanceOfMainPipeline = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsWaterAvailable = table.Column<bool>(type: "bit", nullable: false),
                    WaterSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterSourceDistance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsPossibleToProvideWaterConnection = table.Column<bool>(type: "bit", nullable: false),
                    DoesDryPitToilet = table.Column<bool>(type: "bit", nullable: false),
                    DoesPourFlushToilet = table.Column<bool>(type: "bit", nullable: false),
                    DoesVIPToilet = table.Column<bool>(type: "bit", nullable: false),
                    ToiletType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterSourceForToilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalToilet = table.Column<int>(type: "int", nullable: false),
                    FunctionalToilet = table.Column<int>(type: "int", nullable: false),
                    NonFunctionalToilet = table.Column<int>(type: "int", nullable: false),
                    FunctionalToiletForBoys = table.Column<int>(type: "int", nullable: false),
                    FunctionalToiletForGirls = table.Column<int>(type: "int", nullable: false),
                    ReasonForNonFunctionalToilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSoakagePitConstructed = table.Column<bool>(type: "bit", nullable: false),
                    IsSoakagePitNeedToRepair = table.Column<bool>(type: "bit", nullable: false),
                    IsRampConstructed = table.Column<bool>(type: "bit", nullable: false),
                    TotalAdditionalToiletRequired = table.Column<int>(type: "int", nullable: false),
                    IsHandWashArea = table.Column<bool>(type: "bit", nullable: false),
                    IsHandWashAreaFunctional = table.Column<bool>(type: "bit", nullable: true),
                    IsProperDrainage = table.Column<bool>(type: "bit", nullable: true),
                    HasWasteWaterDiverted = table.Column<bool>(type: "bit", nullable: true),
                    IsHandWashNeedMinorRepair = table.Column<bool>(type: "bit", nullable: true),
                    IsHandWashNeedToConstructed = table.Column<bool>(type: "bit", nullable: true),
                    IsCrackInSlab = table.Column<bool>(type: "bit", nullable: false),
                    CrackRepairableClassroom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCrackInBeam = table.Column<bool>(type: "bit", nullable: false),
                    CrackRepairableBeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCrackInColumn = table.Column<bool>(type: "bit", nullable: false),
                    CrackRepairableColumn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExposedSteel = table.Column<bool>(type: "bit", nullable: false),
                    SteelRepairable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsIrreparableCracksInWalls = table.Column<bool>(type: "bit", nullable: false),
                    CrackRepairableToilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FolderPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagesTotal = table.Column<short>(type: "smallint", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitedContact = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    SiteVisitBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitorDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedContact = table.Column<int>(type: "int", nullable: false),
                    VerifiedDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToiletTypeOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTGirderRoom = table.Column<int>(type: "int", nullable: false),
                    ToiletsNeedRepair = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    CrackSlabToilet = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    IsRequiredAdditionalClassRoom = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    BoundaryWallImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoundaryWallImgTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    BuildingImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingImgTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    ClassroomsImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassroomsImgTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    IsProvideSolarSystem = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    IsSolarSystem = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    PlayAreaImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayAreaImgTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    ToiletsImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToiletsImgTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    WashImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WashImgTotal = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselinePst1", x => x.SID);
                    table.ForeignKey(
                        name: "FK_BaselinePst_Schools_SID",
                        column: x => x.SID,
                        principalTable: "Schools",
                        principalColumn: "SID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaselinePstOld",
                columns: table => new
                {
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    Elevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitute = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TypeOfExistingSchoolStructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapeOfProposedSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SiteWidth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SiteArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDismantlingRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsBoundaryWall = table.Column<bool>(type: "bit", nullable: false),
                    IsMainGate = table.Column<bool>(type: "bit", nullable: false),
                    IsNeedNewGate = table.Column<bool>(type: "bit", nullable: false),
                    IsStaffRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsPrincipalRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsMultiPurposeHall = table.Column<bool>(type: "bit", nullable: false),
                    IsITLab = table.Column<bool>(type: "bit", nullable: false),
                    IsLibrary = table.Column<bool>(type: "bit", nullable: false),
                    IsLaboratory = table.Column<bool>(type: "bit", nullable: false),
                    IsMultipurposePlayArea = table.Column<bool>(type: "bit", nullable: false),
                    IsRamp = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalMultiPurposeHall = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalITLab = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalLibrary = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalLaboratory = table.Column<bool>(type: "bit", nullable: false),
                    IsAdditionalMultipurposePlayArea = table.Column<bool>(type: "bit", nullable: false),
                    IsECRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricity = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricityRepair = table.Column<bool>(type: "bit", nullable: false),
                    IsProvideElectricityConnection = table.Column<bool>(type: "bit", nullable: false),
                    DoesExistGasPipeline = table.Column<bool>(type: "bit", nullable: true),
                    IsHandWashNeedToConstructed = table.Column<bool>(type: "bit", nullable: false),
                    DistanceOfMainPipeline = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPossibleToProvideGasConnection = table.Column<bool>(type: "bit", nullable: false),
                    IsWaterAvailable = table.Column<bool>(type: "bit", nullable: false),
                    WaterSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterSourceDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPossibleToProvideWaterConnection = table.Column<bool>(type: "bit", nullable: false),
                    IsSoakagePitNeedToRepair = table.Column<bool>(type: "bit", nullable: false),
                    DoesDryPitToilet = table.Column<bool>(type: "bit", nullable: false),
                    WaterSourceForToilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNewBoundaryWallRequired = table.Column<bool>(type: "bit", nullable: false),
                    DoesPourFlushToilet = table.Column<bool>(type: "bit", nullable: false),
                    IsRampConstructed = table.Column<bool>(type: "bit", nullable: false),
                    DoesVIPToilet = table.Column<bool>(type: "bit", nullable: false),
                    IsHandWashNeedMinorRepair = table.Column<bool>(type: "bit", nullable: false),
                    IsSoakagePitConstructed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalKachaRoom = table.Column<int>(type: "int", nullable: false),
                    IsRepairRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsMHMStorageAvailable = table.Column<bool>(type: "bit", nullable: false),
                    TotalAdditionalToiletRequired = table.Column<int>(type: "int", nullable: true),
                    TotalToilet = table.Column<int>(type: "int", nullable: false),
                    LengthOfBoundaryWall = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPakkaRoom = table.Column<int>(type: "int", nullable: false),
                    FunctionalToilet = table.Column<int>(type: "int", nullable: false),
                    TotalRequiredAdditionalClassRoom = table.Column<short>(type: "smallint", nullable: false),
                    IsRepairRequiredMainGate = table.Column<bool>(type: "bit", nullable: false),
                    IsHandWashArea = table.Column<bool>(type: "bit", nullable: false),
                    IsHandWashAreaFunctional = table.Column<bool>(type: "bit", nullable: false),
                    IsProperDrainage = table.Column<bool>(type: "bit", nullable: false),
                    IsPlantationArea = table.Column<bool>(type: "bit", nullable: false),
                    HasWasteWaterDiverted = table.Column<bool>(type: "bit", nullable: false),
                    ReasonForNonFunctionalToilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalToiletForBoys = table.Column<int>(type: "int", nullable: false),
                    FunctionalToiletForGirls = table.Column<int>(type: "int", nullable: false),
                    NonFunctionalToilet = table.Column<int>(type: "int", nullable: false),
                    IsCrackInSlab = table.Column<bool>(type: "bit", nullable: false),
                    IsCrackInBeam = table.Column<bool>(type: "bit", nullable: false),
                    IsCrackInColumn = table.Column<bool>(type: "bit", nullable: false),
                    IsExposedSteel = table.Column<bool>(type: "bit", nullable: false),
                    IsIrreparableCracksInWalls = table.Column<bool>(type: "bit", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    SiteVisitBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteVisitorDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchoolSID = table.Column<short>(type: "smallint", nullable: true),
                    AccessToHandWashArea = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Access = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ConditionOfExistingBoundaryWall = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DistanceOfMainWaterConnectionPipeline = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DoesExistingSchoolHaveWaterConnection = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DryPitToiletForProposed = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ExistingMainGate = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalDryPitToilet = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalDryPitToiletForBoys = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalDryPitToiletForGirls = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalPourFlushToilet = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalPourFlushToiletForBoys = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalPourFlushToiletForGirls = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalVIPToilet = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalVIPToiletForBoys = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FunctionalVIPToiletForGirls = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    GateSizeHeight = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    GateSizeWidth = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsAdditionalPrincipalRoom = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsAdditionalStaffRoom = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsDryPitToiletOnRaisedPlatform = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsFlooringForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsHandRailRequiredForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsLevelingRequiredForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsNearWaterConnectionLocation = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsPTCLCablePass = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsPaintRequiredForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsPipelineNearTheSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsPlantationAreaRequiredRepairing = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsPlasterRequiredForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsPourFlushToiletOnRaisedPlatform = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsRainWaterDrain = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsRampRequiredForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsRoofScreedingRequiredForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSeparateDryPitToilets = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSeparatePourFlushToilets = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSeparateVIPToilets = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSewerageInPourFlush = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSewerageInVIP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSewerageOnProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IsSoakageForProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    LevelOfProposedSite = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalDryPitToilet = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalDryPitToiletForBoys = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalDryPitToiletForGirls = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalPourFlushToilet = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalPourFlushToiletForBoys = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalPourFlushToiletForGirls = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalVIPToilet = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NonFunctionalVIPToiletForBoys = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BoundryWallType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    CheckedDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrackRepairableBeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrackRepairableClassroom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrackRepairableColumn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrackRepairableToilet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DismantleRoomsNum = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    DismantleRoomsQty = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    DismentleBoundaryWall = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    DismentleToiletNum = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    DismentleToiletQty = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "(CONVERT([smallint],(0)))"),
                    IsCrackSlabToilet = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    SteelRepairable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToiletType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeismicZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedContact = table.Column<int>(type: "int", nullable: false),
                    VerifiedDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitedContact = table.Column<int>(type: "int", nullable: false),
                    test = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselinePst", x => x.SID);
                    table.ForeignKey(
                        name: "FK_BaselinePst_Schools_SchoolSID",
                        column: x => x.SchoolSID,
                        principalTable: "Schools",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "BaselinePstRoom",
                columns: table => new
                {
                    SRID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    RoomLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomWidth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaintRequired = table.Column<bool>(type: "bit", nullable: false),
                    TotalRoomDoor = table.Column<int>(type: "int", nullable: false),
                    TotalRoomDoorReplace = table.Column<int>(type: "int", nullable: false),
                    TotalRoomDoorRepair = table.Column<int>(type: "int", nullable: false),
                    TotalRoomWindow = table.Column<int>(type: "int", nullable: false),
                    TotalRoomWindowReplace = table.Column<int>(type: "int", nullable: false),
                    TotalRoomWindowRepair = table.Column<int>(type: "int", nullable: false),
                    TotalRoomVentilator = table.Column<int>(type: "int", nullable: false),
                    TotalRoomVentilatorReplace = table.Column<int>(type: "int", nullable: false),
                    TotalRoomVentilatorRepair = table.Column<int>(type: "int", nullable: false),
                    TotalRoomLightRequired = table.Column<int>(type: "int", nullable: false),
                    TotalRoomFanRequired = table.Column<int>(type: "int", nullable: false),
                    IsFlooringRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsPlasterRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsRoofScreedingRequired = table.Column<bool>(type: "bit", nullable: false),
                    SchoolSID = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselinePstRoom_1", x => x.SRID);
                    table.ForeignKey(
                        name: "FK_BaselinePstRoom_Schools_SchoolSID",
                        column: x => x.SchoolSID,
                        principalTable: "Schools",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "ESSConstruction",
                columns: table => new
                {
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    IsPond = table.Column<bool>(type: "bit", nullable: true),
                    IsArtifact = table.Column<bool>(type: "bit", nullable: true),
                    IsSewerage = table.Column<bool>(type: "bit", nullable: true),
                    IsConstructionWaste = table.Column<bool>(type: "bit", nullable: true),
                    IsCuttingTree = table.Column<bool>(type: "bit", nullable: true),
                    TreeRemoved = table.Column<short>(type: "smallint", nullable: false),
                    IsCompensatoryPlantation = table.Column<bool>(type: "bit", nullable: true),
                    ReaNoBudget = table.Column<bool>(type: "bit", nullable: true),
                    ReaTimeOver = table.Column<bool>(type: "bit", nullable: true),
                    ReaNoLand = table.Column<bool>(type: "bit", nullable: true),
                    ReaNoWater = table.Column<bool>(type: "bit", nullable: true),
                    IsWasteWaterTowardsPlantation = table.Column<bool>(type: "bit", nullable: true),
                    IsNoPlantationArea = table.Column<bool>(type: "bit", nullable: true),
                    IsSeparateToiletsConstructed = table.Column<bool>(type: "bit", nullable: true),
                    ReasonNoSeparateToilets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConstructionObstruction = table.Column<bool>(type: "bit", nullable: true),
                    IsConstructionDisruptedSchool = table.Column<bool>(type: "bit", nullable: true),
                    IsRiskGBV = table.Column<bool>(type: "bit", nullable: true),
                    IsCodeOfConductSigned = table.Column<bool>(type: "bit", nullable: true),
                    IsFenced = table.Column<bool>(type: "bit", nullable: true),
                    IsPardaArrangement = table.Column<bool>(type: "bit", nullable: true),
                    IsEmergencyExist = table.Column<bool>(type: "bit", nullable: true),
                    EmergencyExistRooms = table.Column<short>(type: "smallint", nullable: false),
                    IsSafetyTraining = table.Column<bool>(type: "bit", nullable: true),
                    IsBoots = table.Column<bool>(type: "bit", nullable: true),
                    IsGloves = table.Column<bool>(type: "bit", nullable: true),
                    IsHelmet = table.Column<bool>(type: "bit", nullable: true),
                    IsHandWashArea = table.Column<bool>(type: "bit", nullable: true),
                    IsRaisedSchoolRamp = table.Column<bool>(type: "bit", nullable: true),
                    IsRaisedSchoolHandrail = table.Column<bool>(type: "bit", nullable: true),
                    IsNewToiletRamp = table.Column<bool>(type: "bit", nullable: true),
                    IsnewToiletHandrail = table.Column<bool>(type: "bit", nullable: true),
                    IsExistingToiletRamp = table.Column<bool>(type: "bit", nullable: true),
                    IsExistingToilethandrail = table.Column<bool>(type: "bit", nullable: true),
                    IsESMPGuidelines = table.Column<bool>(type: "bit", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchoolSID = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESSConstruction", x => x.SID);
                    table.ForeignKey(
                        name: "FK_ESSConstruction_Schools_SchoolSID",
                        column: x => x.SchoolSID,
                        principalTable: "Schools",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "EssSiting",
                columns: table => new
                {
                    SID = table.Column<short>(type: "smallint", nullable: false),
                    AdditionalLand = table.Column<bool>(type: "bit", nullable: true),
                    LandMutation = table.Column<bool>(type: "bit", nullable: true),
                    FloodPath = table.Column<bool>(type: "bit", nullable: true),
                    FloodPathImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandSlideArea = table.Column<bool>(type: "bit", nullable: true),
                    LandSlideAreaImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hill = table.Column<bool>(type: "bit", nullable: true),
                    HillImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalineLand = table.Column<bool>(type: "bit", nullable: true),
                    SalineLandImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasetDumps = table.Column<bool>(type: "bit", nullable: true),
                    WasetDumpsImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterTrees = table.Column<bool>(type: "bit", nullable: true),
                    ClusterTreesImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreesNum = table.Column<short>(type: "smallint", nullable: false),
                    HighwayAway = table.Column<bool>(type: "bit", nullable: true),
                    TransmissionLines = table.Column<bool>(type: "bit", nullable: true),
                    TransmissionLinesImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransmissionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricPoleInside = table.Column<bool>(type: "bit", nullable: true),
                    ElectricPoleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricPoleImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandWashArea = table.Column<bool>(type: "bit", nullable: true),
                    HandWashAreaRepair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireExtinguisher = table.Column<bool>(type: "bit", nullable: true),
                    FireBlanket = table.Column<bool>(type: "bit", nullable: true),
                    SandBuckets = table.Column<bool>(type: "bit", nullable: true),
                    WasteBinClasses = table.Column<bool>(type: "bit", nullable: true),
                    WasteBinPlayground = table.Column<bool>(type: "bit", nullable: true),
                    TreesInSchool = table.Column<bool>(type: "bit", nullable: true),
                    TreesInSchoolNum = table.Column<short>(type: "smallint", nullable: false),
                    SpaceForPlantation = table.Column<bool>(type: "bit", nullable: true),
                    WaterAvailable = table.Column<bool>(type: "bit", nullable: true),
                    BuildingOnGround = table.Column<bool>(type: "bit", nullable: true),
                    BuildingRamp = table.Column<bool>(type: "bit", nullable: true),
                    BuildingHandrail = table.Column<bool>(type: "bit", nullable: true),
                    ToiletOnGround = table.Column<bool>(type: "bit", nullable: true),
                    ToiletRamp = table.Column<bool>(type: "bit", nullable: true),
                    ToiletHandrail = table.Column<bool>(type: "bit", nullable: true),
                    DifferentChild = table.Column<short>(type: "smallint", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuildingDepression = table.Column<bool>(type: "bit", nullable: true),
                    ProperFlowOut = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EssSiting", x => x.SID);
                    table.ForeignKey(
                        name: "FK_EssSiting_Schools_SID",
                        column: x => x.SID,
                        principalTable: "Schools",
                        principalColumn: "SID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrollment",
                columns: table => new
                {
                    SchoolID = table.Column<int>(type: "int", nullable: false),
                    Quarter = table.Column<short>(type: "smallint", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    ProjectYear = table.Column<short>(type: "smallint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReCollectData = table.Column<bool>(type: "bit", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchoolSID = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrollment", x => new { x.SchoolID, x.Quarter });
                    table.ForeignKey(
                        name: "FK_StudentEnrollment_Schools_SchoolSID",
                        column: x => x.SchoolSID,
                        principalTable: "Schools",
                        principalColumn: "SID");
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_AppUser_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "SectionId");
                });

            migrationBuilder.CreateTable(
                name: "bLTeachers",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BLID = table.Column<short>(type: "smallint", nullable: false),
                    PostID = table.Column<short>(type: "smallint", nullable: false),
                    TeachersPost = table.Column<short>(type: "smallint", nullable: false),
                    TrainedEce = table.Column<short>(type: "smallint", nullable: false),
                    TrainedInduction = table.Column<short>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bLTeachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BLTeachers_Baselines_BLID",
                        column: x => x.BLID,
                        principalTable: "Baselines",
                        principalColumn: "BLID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BLTeachers_TeacherPosts_PostID",
                        column: x => x.PostID,
                        principalTable: "TeacherPosts",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrollmentDetail",
                columns: table => new
                {
                    SchoolID = table.Column<int>(type: "int", nullable: false),
                    Quarter = table.Column<short>(type: "smallint", nullable: false),
                    ClassID = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrolltGirls = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrollBoys = table.Column<short>(type: "smallint", nullable: false),
                    AttendRegGirls = table.Column<short>(type: "smallint", nullable: false),
                    AttendRegBoys = table.Column<short>(type: "smallint", nullable: false),
                    HeadCountGirls = table.Column<short>(type: "smallint", nullable: false),
                    HeadCountBoys = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SchoolSID = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrollmentDetail", x => new { x.SchoolID, x.Quarter, x.ClassID });
                    table.ForeignKey(
                        name: "FK_StudentEnrollmentDetail_Schools_SchoolSID",
                        column: x => x.SchoolSID,
                        principalTable: "Schools",
                        principalColumn: "SID");
                    table.ForeignKey(
                        name: "FK_StudentEnrollmentDetail_StudentEnrollment_SchoolID_Quarter",
                        columns: x => new { x.SchoolID, x.Quarter },
                        principalTable: "StudentEnrollment",
                        principalColumns: new[] { "SchoolID", "Quarter" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AppUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_SectionId",
                table: "AppUser",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AppUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BaselineEss_SchoolSID",
                table: "BaselineEss",
                column: "SchoolSID");

            migrationBuilder.CreateIndex(
                name: "IX_BaselinePstOld_SchoolSID",
                table: "BaselinePstOld",
                column: "SchoolSID");

            migrationBuilder.CreateIndex(
                name: "IX_BaselinePstRoom_SchoolSID",
                table: "BaselinePstRoom",
                column: "SchoolSID");

            migrationBuilder.CreateIndex(
                name: "IX_BLEnrollments_BLID",
                table: "BLEnrollments",
                column: "BLID");

            migrationBuilder.CreateIndex(
                name: "IX_bLTeachers_BLID",
                table: "bLTeachers",
                column: "BLID");

            migrationBuilder.CreateIndex(
                name: "IX_bLTeachers_PostID",
                table: "bLTeachers",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_ESSConstruction_SchoolSID",
                table: "ESSConstruction",
                column: "SchoolSID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollment_SchoolSID",
                table: "StudentEnrollment",
                column: "SchoolSID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollmentDetail_SchoolSID",
                table: "StudentEnrollmentDetail",
                column: "SchoolSID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnBEMISCodeDetails");

            migrationBuilder.DropTable(
                name: "AnnBEMISCodes");

            migrationBuilder.DropTable(
                name: "AnnEnrollmentDetails");

            migrationBuilder.DropTable(
                name: "AnnEnrollments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BaselineEss");

            migrationBuilder.DropTable(
                name: "BaselinePst");

            migrationBuilder.DropTable(
                name: "BaselinePstOld");

            migrationBuilder.DropTable(
                name: "BaselinePstRoom");

            migrationBuilder.DropTable(
                name: "BLbuildingFacilities");

            migrationBuilder.DropTable(
                name: "BLEceComputerLabs");

            migrationBuilder.DropTable(
                name: "BLEnrollments");

            migrationBuilder.DropTable(
                name: "BLLibraryFurnitures");

            migrationBuilder.DropTable(
                name: "bLTeachers");

            migrationBuilder.DropTable(
                name: "ESSConstruction");

            migrationBuilder.DropTable(
                name: "EssSiting");

            migrationBuilder.DropTable(
                name: "StudentEnrollmentDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Baselines");

            migrationBuilder.DropTable(
                name: "TeacherPosts");

            migrationBuilder.DropTable(
                name: "StudentEnrollment");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
