/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UActionInputEventHolder
	{
		public const int UnknownData00 = 0x0028;
	}

	public class ATslBaseHUD
	{
		public const int MainUMGHudClass = 0x0498;
		public const int AutoLoadAudioBanks = 0x04A0;
		public const int UnknownData00 = 0x04B0;
		public const int ActionInputEventHolderArray = 0x04B8;
		public const int WidgetStateMap = 0x04C8;
		public const int UseMouseWidgetStack = 0x0518;
		public const int MainUMGHud = 0x0528;
		public const int BlockInputWidgetList = 0x0530;
		public const int UnknownData01 = 0x0540;
	}

	public class AAirborneEjectionArea
	{
		public const int SphereComponent = 0x03B0;
		public const int Radius = 0x03B8;
		public const int UnknownData00 = 0x03BC;
	}

	public class UAnimDB
	{
		public const int Stand_Info = 0x0030;
		public const int Crouch_Info = 0x0098;
		public const int Prone_Info = 0x0100;
		public const int BlendSpaceSpeed_Walk = 0x0168;
		public const int BlendSpaceSpeed_Run = 0x016C;
		public const int BlendSpaceSpeed_Sprint = 0x0170;
		public const int UnknownData00 = 0x0174;
	}

	public class UAnimNotify_AkEvent_Advanced
	{
		public const int AkAudioEvent = 0x0038;
		public const int EventName = 0x0040;
		public const int AttachName = 0x0050;
		public const int CustomRelativeLocation = 0x0058;
		public const int bFollow = 0x0064;
		public const int bUseMinActivationDistance = 0x0065;
		public const int bUseActivationDistanceByAttenuation = 0x0066;
		public const int UnknownData00 = 0x0067;
		public const int MinActivationDistance = 0x0068;
		public const int bPlayCameraShake = 0x006C;
		public const int UnknownData01 = 0x006D;
		public const int CameraShake = 0x0070;
		public const int AffectedCameras = 0x0078;
	}

	public class UAnimNotify_CharacterAnimationNotify
	{
		public const int NotifyName = 0x0038;
	}

	public class UAnimNotify_UnarmedAttack
	{
		public const int NotifyName = 0x0038;
	}

	public class UAnimNotify_WeaponAnimationNotify
	{
		public const int NotifyName = 0x0038;
	}

	public class UAsyncStaticMeshComponent
	{
		public const int OnStaticMeshLoaded = 0x09C0;
		public const int StaticMeshAsset = 0x09D0;
		public const int UnknownData00 = 0x09F0;
		public const int ErrorStaticMesh = 0x09F8;
		public const int ClientCollisionProfileNameOverride = 0x0A00;
		public const int PendingStaticMeshAsset = 0x0A08;
		public const int UnknownData01 = 0x0A28;
	}

	public class UBluezoneInOutComponent
	{
		public const int UnknownData00 = 0x01E0;
	}

	public class UBluezoneInOutSoundEffectComponent
	{
		public const int BluezoneInSoundAk = 0x01E0;
		public const int BluezoneOutSoundAk = 0x01E8;
	}

	public class UBTDecorator_HasLoSTo
	{
		public const int EnemyKey = 0x0068;
	}

	public class ATslBuff
	{
		public const int OverlapId = 0x03B0;
		public const int OverlapSolveMethod = 0x03B8;
		public const int UnknownData00 = 0x03B9;
		public const int BuffTickInterval = 0x03BC;
		public const int BuffTickFirstDelay = 0x03C0;
		public const int BuffDuration = 0x03C4;
		public const int Infinite = 0x03C8;
		public const int UnknownData01 = 0x03C9;
		public const int AttachSocket = 0x03D0;
		public const int AttachServerPaticleClass = 0x03D8;
		public const int IsDebuff = 0x03E0;
		public const int UnknownData02 = 0x03E1;
		public const int OwnerBuffComponent = 0x03E8;
		public const int UnknownData03 = 0x03F0;
		public const int AttachedServerPaticle = 0x0400;
		public const int UnknownData04 = 0x0408;
	}

	public class UBuffComponet
	{
		public const int UnknownData00 = 0x01E0;
	}

	public class UCameraSettings
	{
		public const int CameraPitchMinStand = 0x0028;
		public const int CameraPitchMaxStand = 0x002C;
		public const int CameraYawMinStand = 0x0030;
		public const int CameraYawMaxStand = 0x0034;
		public const int CameraPitchMinProne = 0x0038;
		public const int CameraPitchMaxProne = 0x003C;
		public const int CameraYawMinProne = 0x0040;
		public const int CameraYawMaxProne = 0x0044;
		public const int FPSShowOnHighScopingFOV = 0x0048;
		public const int TPSShowOnHighScopingFOV = 0x004C;
		public const int CameraPitchMinInVehicle = 0x0050;
		public const int CameraPitchMaxInVehicle = 0x0054;
		public const int CameraYawMinInVehicle = 0x0058;
		public const int CameraYawMaxInVehicle = 0x005C;
		public const int HeadBoneName = 0x0060;
		public const int HideMaterialsWhenCameraIsInHead = 0x0068;
		public const int HideMaterialsOnScopeMode = 0x0078;
		public const int HideMaterialsOnHighScopeMode = 0x0088;
	}

	public class UCastComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int OnCancelCast = 0x01E8;
		public const int UnknownData01 = 0x01F8;
	}

	public class UCharacterBreathComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int Breath = 0x01E8;
		public const int BreathMax = 0x01EC;
		public const int BreathPointOffsetAtStand = 0x01F0;
		public const int BreathPointOffsetAtCrouch = 0x01FC;
		public const int BreathPointOffsetAtProne = 0x0208;
		public const int BreathPointOffsetAtGroggy = 0x0214;
		public const int RestorationBuff = 0x0220;
		public const int ApneaDebuff = 0x0228;
		public const int HoldBreathDebuff = 0x0230;
		public const int MinimumBreathStartHoldingBreath = 0x0238;
		public const int UnknownData01 = 0x023C;
		public const int SprintDebuff = 0x0240;
		public const int MinimumBreathStartSprinting = 0x0248;
		public const int UnknownData02 = 0x024C;
	}

	public class ACharacterStudio
	{
		public const int SpringArmComponent = 0x03B0;
		public const int CameraComponent = 0x03B8;
		public const int SceneCaptureComponent = 0x03C0;
		public const int TextureTarget = 0x03C8;
		public const int bUseDynamicResolution = 0x03D0;
		public const int UnknownData00 = 0x03D1;
		public const int MaxViewDistance = 0x03D4;
		public const int MaleCharacterProxyClass = 0x03D8;
		public const int FemaleCharacterProxyClass = 0x03E0;
		public const int UnknownData01 = 0x03E8;
		public const int CharacterInitialTransform = 0x03F0;
		public const int CharacterProxy = 0x0420;
		public const int CharacterRotationPivot = 0x0428;
		public const int SceneCaptureMaterial = 0x0430;
		public const int UnknownData02 = 0x0438;
	}

	public class UCoherentCommonBinder
	{
		public const int UnknownData00 = 0x0028;
		public const int DefaultLobbyUrl = 0x0088;
		public const int UnknownData01 = 0x0098;
	}

	public class UCoherentWidgetBinder
	{
		public const int UnknownData00 = 0x00A0;
	}

	public class ATslPlayerController
	{
		public const int OnShowReplayTimeline = 0x06F0;
		public const int UnknownData00 = 0x0700;
		public const int UnknownData01 = 0x0728;
		public const int bIsSpectated = 0x0728;
		public const int UnknownData02 = 0x0729;
		public const int CameraPeekLeftMove = 0x072C;
		public const int CameraPeekRightMove = 0x0738;
		public const int UnknownData03 = 0x0744;
		public const int CameraViewBehaviour = 0x0754;
		public const int UnknownData04 = 0x0755;
		public const int SpectatorAccumViewRotation = 0x0778;
		public const int ObserverAuthorityType = 0x0784;
		public const int UnknownData05 = 0x0785;
		public const int InteractionTargetComponent = 0x07B8;
		public const int SpectatorViewCharacter = 0x07C0;
		public const int UnknownData06 = 0x07C8;
		public const int Achievement = 0x07D8;
		public const int SpectatorScopeMesh = 0x07E0;
		public const int UnknownData07 = 0x07E8;
		public const int NearClippingLevelsOverZ = 0x0840;
		public const int MaxValidPing = 0x0850;
		public const int DefaultFOV = 0x0854;
		public const int InteractGamepadHoldTime = 0x0858;
		public const int UnknownData08 = 0x085C;
		public const int VivoxComponent = 0x0860;
		public const int Teams = 0x0868;
		public const int ReplicateTeamMembers = 0x0878;
		public const int UnknownData09 = 0x0888;
		public const int ReplicateCharacter = 0x08D8;
		public const int ReplicateCarePackageItemList = 0x08E8;
		public const int UnknownData10 = 0x08F8;
		public const int DeathResultDelaySeconds = 0x0918;
		public const int UnknownData11 = 0x091C;
		public const int PingPongSummary = 0x09AC;
		public const int UnknownData12 = 0x09B8;
	}

	public class ADeployedItem
	{
		public const int ItemType = 0x03B0;
		public const int StackCount = 0x03B8;
		public const int UnknownData00 = 0x03BC;
		public const int SceneComponent = 0x03C0;
	}

	public class ASubActor
	{
		public const int NetOwnerCharacter = 0x03B0;
	}

	public class AItemSlotContainer
	{
		public const int UnknownData00 = 0x03B8;
		public const int OnCreateAndShowContextMenuWidget = 0x03C0;
		public const int OnDestroyContextMenuWidget = 0x03D0;
		public const int UnknownData01 = 0x03E0;
	}

	public class AItemExplorer
	{
		public const int UnknownData00 = 0x03E8;
		public const int OnUpdateItemList = 0x03F0;
		public const int OnClearItemList = 0x0400;
		public const int UnknownData01 = 0x0410;
	}

	public class UItem
	{
		public const int UnknownData00 = 0x0028;
		public const int bStackable = 0x0038;
		public const int bUsable = 0x0038;
		public const int bIsConsumable = 0x0038;
		public const int bDisableSpawnInGame = 0x0038;
		public const int UnknownData01 = 0x0039;
		public const int StackCount = 0x003C;
		public const int ItemName = 0x0040;
		public const int ItemCategory = 0x0058;
		public const int ItemDetailedName = 0x0070;
		public const int ItemDescription = 0x0088;
		public const int ItemMaxInteractableDistance = 0x00A0;
		public const int StackCountMax = 0x00A4;
		public const int SpacePerItem = 0x00A8;
		public const int UnknownData02 = 0x00AC;
		public const int DroppedMesh = 0x00B0;
		public const int DroppedMeshScale = 0x00D0;
		public const int UnknownData03 = 0x00D4;
		public const int Icon = 0x00D8;
		public const int ToolTipIcon = 0x00F8;
		public const int IconSizeRatio = 0x0118;
		public const int ToolTipIconSizeRatio = 0x011C;
		public const int DropSoundAk = 0x0120;
		public const int PickUpSoundAk = 0x0128;
		public const int InventoryPutSoundAk = 0x0130;
		public const int SortPriority = 0x0138;
		public const int LobbyItemID = 0x013C;
		public const int LobbyItemDesc = 0x0140;
		public const int Category = 0x0198;
		public const int UnknownData04 = 0x0199;
		public const int SubCategory = 0x01A0;
		public const int bIsToy = 0x01A8;
		public const int UnknownData05 = 0x01A9;
		public const int Note = 0x01B0;
	}

	public class AItemPackage
	{
		public const int UnknownData00 = 0x0418;
		public const int PackageName = 0x0428;
		public const int PackageCategory = 0x0440;
		public const int PackageDetailedName = 0x0458;
		public const int PackageDescription = 0x0470;
		public const int PackageIcon = 0x0488;
		public const int PackageIconSizeRatio = 0x0490;
		public const int UnknownData01 = 0x0494;
		public const int PackageToolTipIcon = 0x0498;
		public const int PackageToolTipIconSizeRatio = 0x04A0;
		public const int UnknownData02 = 0x04A4;
		public const int PackageMesh = 0x04A8;
		public const int BoxComponent = 0x04C8;
		public const int InteractionComponent = 0x04D0;
		public const int DestroyByEmptyItem = 0x04D8;
		public const int UnknownData03 = 0x04D9;
		public const int Items = 0x04E0;
		public const int CreatorName = 0x04F0;
		public const int SortPriority = 0x0500;
		public const int UnknownData04 = 0x0504;
	}

	public class ADeployedItemPackage
	{
		public const int ItemPackageType = 0x03B0;
		public const int ItemInfos = 0x03B8;
	}

	public class UDoorDataAsset
	{
		public const int OpenAngle = 0x0030;
		public const int UnknownData00 = 0x0034;
		public const int OpenCurve = 0x0038;
		public const int OpenCurveDuration = 0x0040;
		public const int UnknownData01 = 0x0044;
		public const int CloseCurve = 0x0048;
		public const int CloseCurveDuration = 0x0050;
		public const int UnknownData02 = 0x0054;
		public const int OpenSound = 0x0058;
		public const int CloseSound = 0x0060;
	}

	public class UTslReactionDoorData
	{
		public const int PointDamageImpulse = 0x0030;
		public const int PointDamageRadius = 0x0034;
		public const int BreakingRadius = 0x0038;
		public const int BreakingImpulse = 0x003C;
		public const int BreakingMinDamage = 0x0040;
		public const int DamageAccumulateTimeout = 0x0044;
		public const int ZombieDamageAccumulateTimeout = 0x0048;
		public const int UnknownData00 = 0x004C;
		public const int TopImpactSoketName = 0x0050;
		public const int CenterImpactSoketName = 0x0058;
		public const int BottomImpactSoketName = 0x0060;
		public const int DestructibleSoundAk = 0x0068;
	}

	public class UDoorFrameComponent
	{
		public const int DoorTransform = 0x09C0;
		public const int SoundOffsetFromDoor = 0x09F0;
		public const int UnknownData00 = 0x09FC;
		public const int DoorStaticMesh = 0x0A00;
		public const int DoorDestructibleMesh = 0x0A08;
		public const int DoorDataAsset = 0x0A10;
		public const int ReactionDoorData = 0x0A18;
		public const int UnknownData01 = 0x0A20;
	}

	public class ADroppedItem
	{
		public const int Item = 0x03B0;
	}

	public class ADroppedItemGridManager
	{
		public const int MaxGridSize = 0x03B0;
		public const int MaxGridLayerNum = 0x03B4;
		public const int MaxItemNumPerGroup = 0x03B8;
		public const int UnknownData00 = 0x03BC;
	}

	public class ADroppedItemGroup
	{
		public const int UnknownData00 = 0x03B0;
		public const int RandomSpawnRadius = 0x03B4;
		public const int MaxRandomSpawnCount = 0x03B8;
		public const int UnknownData01 = 0x03BC;
	}

	public class UExportableDataAsset
	{
		public const int JsonSaveDirectory = 0x0030;
		public const int JsonSaveFileName = 0x0040;
	}

	public class ULobbyCustomizableData
	{
		public const int Faces = 0x0050;
		public const int Hairs = 0x0060;
	}

	public class ULobbyItemExporter
	{
		public const int LocJsonSaveFileName = 0x0050;
	}

	public class AFlashBangCaptureActor
	{
		public const int SceneRootComponent = 0x03B0;
		public const int SceneCapture = 0x03B8;
		public const int PlayerPawnReference = 0x03C0;
		public const int CaptureTexture = 0x03C8;
		public const int UnknownData00 = 0x03D0;
	}

	public class UGameEventObserver
	{
		public const int OnMatchStarted = 0x0028;
		public const int OnMatchEnded = 0x0038;
		public const int OnKillOtherPlayer = 0x0048;
		public const int OnDie = 0x0058;
		public const int OnDamage = 0x0068;
	}

	public class UGameStateListenerComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int OnGameModeEvent = 0x01E8;
		public const int UnknownData01 = 0x01F8;
	}

	public class UTableGeneralItemSpawner
	{
		public const int RawItemSpawnDataTable = 0x0028;
		public const int RawItemSpawnTogetherDataTable = 0x0030;
		public const int SpawnProbArray = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UHackReporterComponent
	{
		public const int UnknownData00 = 0x01E0;
	}

	public class UHighlightSession
	{
		public const int Config_Kill = 0x0028;
		public const int Config_KillGroggy = 0x0034;
		public const int Config_Die = 0x0040;
		public const int Config_DieGroggy = 0x004C;
		public const int Config_EndMatch = 0x0058;
		public const int UnknownData00 = 0x0064;
		public const int TslHUD = 0x0068;
		public const int UnknownData01 = 0x0070;
	}

	public class UInteractionComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int MaxInteractableDistance = 0x01E8;
		public const int UnknownData01 = 0x01EC;
		public const int InteractionVerb = 0x01F0;
		public const int InteractiveObjectName = 0x0208;
		public const int CastConfig = 0x0220;
		public const int bUseTraceCheck = 0x0250;
		public const int UnknownData02 = 0x0251;
		public const int OnInteractBy = 0x0258;
		public const int ClientOnInteractBy = 0x0268;
		public const int UnknownData03 = 0x0278;
	}

	public class UDoublePhaseInteractionComponent
	{
		public const int FirstInteractionVerb = 0x0360;
		public const int FirstInteractiveObjectName = 0x0378;
		public const int SecondInteractionVerb = 0x0390;
		public const int SecondInteractiveObjectName = 0x03A8;
		public const int OnSecondInteractBy = 0x03C0;
		public const int ClientOnSecondInteractBy = 0x03D0;
		public const int UnknownData00 = 0x03E0;
	}

	public class UDroppedItemActorComponent
	{
		public const int UnknownData00 = 0x0360;
	}

	public class UOnceInteractionComponent
	{
		public const int CharacterHistory = 0x0360;
	}

	public class UAmmoItem
	{
		public const int AmmoIcon = 0x01C0;
		public const int AmmoIconRatio = 0x01C8;
		public const int UnknownData00 = 0x01CC;
	}

	public class UAttachableItem
	{
		public const int AttachmentData = 0x01C0;
		public const int AttachmentMeshAsset = 0x03A8;
		public const int AttachmentWeaponTagData = 0x03C8;
		public const int EquipOnPickUp = 0x03D8;
		public const int UnknownData00 = 0x03D9;
		public const int AttachedSoundAk = 0x03E0;
	}

	public class UCastableItem
	{
		public const int CastConfig = 0x01C0;
		public const int bCanUseInWater = 0x01F0;
		public const int CastableItemType = 0x01F1;
		public const int UnknownData00 = 0x01F2;
	}

	public class UInstantHealItem
	{
		public const int HealLimit = 0x01F8;
		public const int UnknownData00 = 0x01FC;
	}

	public class USkinItem
	{
		public const int SkinData = 0x01F8;
		public const int bAutoAction = 0x0218;
		public const int UnknownData00 = 0x0219;
	}

	public class UEquipableItem
	{
		public const int EquipSlotID = 0x01C0;
		public const int UnknownData00 = 0x01C1;
		public const int SpaceExtension = 0x01C4;
		public const int DamageReductionRate = 0x01C8;
		public const int DurabilityMax = 0x01CC;
		public const int DestroyByDurability = 0x01D0;
		public const int UnknownData01 = 0x01D1;
		public const int Durability = 0x01D4;
		public const int DurabilityConsumeType = 0x01D8;
		public const int UnknownData02 = 0x01D9;
		public const int CustomizableObjectIdentifierForMale = 0x01E0;
		public const int CustomizableObjectIdentifierForFemale = 0x0210;
		public const int EquipedSoundAk = 0x0240;
		public const int SoundGroup = 0x0248;
		public const int SoundType = 0x0249;
		public const int bCanZombieEquip = 0x024A;
		public const int SlotOffsetType = 0x024B;
		public const int bIsUnequipable = 0x024C;
		public const int UnknownData03 = 0x024D;
		public const int HudDisplayEquipIcon = 0x0250;
		public const int UnknownData04 = 0x0270;
	}

	public class UCustomEquipableItem
	{
		public const int ItemLevel = 0x0278;
		public const int UnknownData00 = 0x027C;
		public const int SlotOffset_Primary = 0x0280;
		public const int SlotOffset_Secondary = 0x02B0;
		public const int SlotOffset_SideArm = 0x02E0;
		public const int SlotOffset_Melee = 0x0310;
		public const int SlotOffset_Thrown = 0x0340;
	}

	public class UParachuteItem
	{
		public const int ParachuteType = 0x0278;
	}

	public class UThrowableItem
	{
		public const int UnknownData00 = 0x0278;
		public const int WeaponType = 0x0280;
		public const int EquippedWeapon = 0x0288;
	}

	public class ATslWeapon
	{
		public const int UnknownData00 = 0x03B0;
		public const int WeaponIcon = 0x03C0;
		public const int WeaponIconRatio = 0x03C8;
		public const int UnknownData01 = 0x03CC;
		public const int PrimaryIcon = 0x03D0;
		public const int SecondaryIcon = 0x03E8;
		public const int PrimaryClipIcon = 0x0400;
		public const int SecondaryClipIcon = 0x0418;
		public const int AmmoIconsCount = 0x0430;
		public const int PrimaryClipIconOffset = 0x0434;
		public const int SecondaryClipIconOffset = 0x0438;
		public const int UnknownData02 = 0x043C;
		public const int Crosshair = 0x0440;
		public const int AimingCrosshair = 0x04B8;
		public const int UseLaserDot = 0x0530;
		public const int UseCustomCrosshair = 0x0531;
		public const int UseCustomAimingCrosshair = 0x0532;
		public const int bHideCrosshairWhileNotAiming = 0x0533;
		public const int UnknownData03 = 0x0534;
		public const int OnUpdatedAttachment = 0x0538;
		public const int MyPawn = 0x0548;
		public const int WeaponConfig = 0x0550;
		public const int WeaponHand = 0x05E8;
		public const int UnknownData04 = 0x05E9;
		public const int Mesh3P = 0x05F0;
		public const int RootScene = 0x05F8;
		public const int UnknownData05 = 0x0600;
		public const int AttachmentAniRateCalculateType = 0x0601;
		public const int AttachmentRecoilPatternScaleCalculateType = 0x0602;
		public const int UnknownData06 = 0x0603;
		public const int AttachmentPositionData = 0x0608;
		public const int DefaultAttachedItemAssets = 0x0618;
		public const int AttachedItemClasses = 0x0628;
		public const int WeaponTag = 0x0638;
		public const int UnknownData07 = 0x0640;
		public const int AkComponent = 0x06A8;
		public const int MuzzleAttachPoint = 0x06B0;
		public const int FiringAttachPoint = 0x06B8;
		public const int MuzzleFx = 0x06C0;
		public const int ShellFxAttachPoint = 0x06C8;
		public const int ShellFxClass = 0x06D0;
		public const int MuzzlePSC = 0x06D8;
		public const int MuzzlePSCSecondary = 0x06E0;
		public const int FireCameraShake = 0x06E8;
		public const int FireForceFeedback = 0x06F0;
		public const int FireSoundAk = 0x06F8;
		public const int FireLoopSoundAk = 0x0700;
		public const int FireFinishSoundAk = 0x0708;
		public const int OutOfAmmoSoundAk = 0x0710;
		public const int ReloadSoundAk = 0x0718;
		public const int EquipSoundAk = 0x0720;
		public const int UnequipSoundAk = 0x0728;
		public const int AimingStartSoundAk = 0x0730;
		public const int AimingFinishSoundAk = 0x0738;
		public const int ScopingStartSoundAk = 0x0740;
		public const int ScopingFinishSoundAk = 0x0748;
		public const int AnimWeaponType = 0x0750;
		public const int UnknownData08 = 0x0751;
		public const int WeaponAnim = 0x0758;
		public const int ProneRollAnim = 0x0770;
		public const int HipDuration = 0x0780;
		public const int bLoopedMuzzleFX = 0x0784;
		public const int bLoopedFireSound = 0x0784;
		public const int UnknownData09 = 0x0785;
		public const int SkinData = 0x07B8;
	}

	public class UWeaponItem
	{
		public const int UnknownData00 = 0x0278;
		public const int WeaponType = 0x0280;
		public const int AmmoCount = 0x0288;
		public const int AmmoPerClip = 0x028C;
		public const int AttachmentTagData = 0x0290;
		public const int WeaponTag = 0x02A0;
		public const int AttachedItems = 0x02A8;
		public const int FiringMode = 0x02B8;
		public const int UnknownData01 = 0x02B9;
		public const int EquippedWeapon = 0x02C0;
	}

	public class URandomlyGeneratableItem
	{
		public const int RandomExpression = 0x01C0;
		public const int bOpenByKey = 0x01D0;
		public const int bOpenByPoint = 0x01D0;
		public const int UnknownData00 = 0x01D1;
		public const int OpenKeyItem = 0x01D8;
		public const int OpenKeyItemCount = 0x01F8;
		public const int PointOpenPrice = 0x01FC;
		public const int ExchangeBundleId = 0x0200;
		public const int UnknownData01 = 0x0204;
		public const int BundleList = 0x0208;
		public const int ReferenceItems = 0x0218;
	}

	public class UItemSpawnProcessor
	{
		public const int UnknownData00 = 0x0028;
	}

	public class USpawnTableItemSpawnProcessor
	{
		public const int RawSpotGroupProperties = 0x0038;
		public const int RawItemSpawnDataTable = 0x0048;
		public const int RawItemSpawnTogetherDataTable = 0x0050;
		public const int UnknownData00 = 0x0058;
		public const int bUseActorSpawn = 0x0F10;
		public const int UnknownData01 = 0x0F11;
	}

	public class AItemSpot
	{
		public const int SpotGroupComponent = 0x03B0;
	}

	public class UItemSpotComponent
	{
		public const int ItemSpotType = 0x03E0;
		public const int UnknownData00 = 0x03E1;
	}

	public class UItemSpotGroupComponent
	{
		public const int SpotGroupType = 0x03E0;
		public const int UnknownData00 = 0x03E1;
	}

	public class AItemStudio
	{
		public const int CameraSocketName = 0x03B0;
		public const int TextureTarget = 0x03B8;
		public const int MaxViewDistance = 0x03C0;
		public const int UnknownData00 = 0x03C4;
		public const int CameraComponent = 0x03C8;
		public const int SceneCaptureComponent = 0x03D0;
		public const int UnknownData01 = 0x03D8;
		public const int DefaultCameraSocketTransform = 0x03E0;
	}

	public class ALevelAttribute
	{
		public const int NumMapBlock = 0x03B0;
		public const int MapRect2D = 0x03B4;
		public const int MapImageMaterial = 0x03C8;
		public const int UnknownData00 = 0x03D0;
	}

	public class ULobbyItemBundleIdPublisher
	{
		public const int LobbyItemPath = 0x0028;
		public const int UnknownData00 = 0x0038;
	}

	public class ULobbyLink
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UMatchPreparer
	{
		public const int WarmupTime = 0x0028;
		public const int WarmupTimeInPIE = 0x002C;
		public const int UnknownData00 = 0x0030;
	}

	public class UAirborneMatchPreparer
	{
		public const int AircraftClass = 0x0058;
		public const int Aircrafts = 0x0060;
		public const int AircraftCount = 0x0070;
		public const int AircraftCapacityOverride = 0x0074;
		public const int AircraftAltitude = 0x0078;
		public const int EndThetaDegree = 0x007C;
		public const int AircraftIntervalDistance = 0x0080;
		public const int UnknownData00 = 0x0084;
	}

	public class UNormalMatchPreparer
	{
		public const int UnknownData00 = 0x0058;
		public const int AvailablePlayerStartCount = 0x0068;
		public const int UnknownData01 = 0x006C;
	}

	public class UMaterialMergeSettings
	{
		public const int UnknownData00 = 0x0028;
		public const int MasterMaterial = 0x0080;
		public const int MergedMaterial = 0x0088;
		public const int ParameterList = 0x0090;
		public const int bUpdateParameterList = 0x00A0;
		public const int UnknownData01 = 0x00A1;
	}

	public class ABattleRoyaleModeController
	{
		public const int NormalPoisonGasDataArray = 0x04A8;
		public const int FastPoisonGasDataArray = 0x04B8;
		public const int FastZonePlayerCount = 0x04C8;
		public const int BattleRoyaleZoneTypeCheckTime = 0x04CC;
		public const int PoisonWarningTime = 0x04D0;
		public const int WaterVolumeRayHeight = 0x04E0;
		public const int UnknownData00 = 0x04E4;
		public const int OceanPhysicsVolume = 0x04F0;
		public const int PassBluezoneAreas = 0x0500;
		public const int PassBluezoneAreasRectangle = 0x0510;
		public const int UnknownData01 = 0x0520;
	}

	public class ACarePackageController
	{
		public const int AircraftCarePackageClass = 0x04A8;
		public const int StartDelay = 0x04B0;
		public const int SpawnInterval = 0x04B8;
		public const int FlyingHeight = 0x04C0;
		public const int CarePackageLifeTime = 0x04C4;
		public const int WhiteZoneSpawnInnerRate = 0x04C8;
		public const int DropAreaRate = 0x04CC;
		public const int UnknownData00 = 0x04D0;
	}

	public class ARedZoneController
	{
		public const int BombTemplateClass = 0x04A8;
		public const int StartDelay = 0x04B0;
		public const int NextCreateRedZoneInterval = 0x04B4;
		public const int BombingDelay = 0x04BC;
		public const int BombingSoundDelay = 0x04C0;
		public const int OuterRadius = 0x04C4;
		public const int LimitExceptExplosionRadius = 0x04C8;
		public const int ExceptExplosionRadius = 0x04D0;
		public const int BombProjectileDelayTime = 0x04D4;
		public const int RedZoneDuration = 0x04D8;
		public const int BombingInterval = 0x04DC;
		public const int RedZoneLifeTime = 0x04E4;
		public const int ReyStartHeight = 0x04E8;
		public const int RedZoneRadiusOffsetRate = 0x04EC;
		public const int RedZoneStartText = 0x04F0;
		public const int RedZoneProjectileCount = 0x0508;
		public const int bFGSquircularMapping = 0x050C;
		public const int UnknownData00 = 0x050D;
		public const int RayCheckAroundLength = 0x0510;
		public const int UnknownData01 = 0x0514;
		public const int BeginServerPaticleClass = 0x0518;
		public const int BeginServerPaticle = 0x0520;
		public const int BeginSoundDelay = 0x0528;
		public const int UnknownData02 = 0x052C;
		public const int OceanPhysicsVolume = 0x0540;
	}

	public class AMutableCharacter
	{
		public const int UnknownData00 = 0x07E0;
		public const int Gender = 0x0800;
		public const int UnknownData01 = 0x0801;
		public const int CustomizableObjectInstance = 0x0808;
		public const int CustomizableSkeletalComponent = 0x0810;
		public const int InstanceDescriptor = 0x0818;
		public const int UnknownData02 = 0x0828;
	}

	public class ALobbyCharacter
	{
		public const int UnknownData00 = 0x0830;
		public const int OnHost = 0x0838;
		public const int OnLobbySceneChanged = 0x0848;
		public const int bHasJacket = 0x0858;
		public const int bIsReady = 0x0858;
		public const int bIsHost = 0x0858;
		public const int bIsInCustomizationScene = 0x0858;
		public const int UnknownData01 = 0x0859;
	}

	public class ATslVaultingHelper
	{
		public const int RootSceneComponent = 0x03B0;
		public const int ActorAttachScene = 0x03B8;
	}

	public class ATslWeapon_Gun
	{
		public const int bSpawnBulletFromBarrel = 0x07D8;
		public const int UnknownData00 = 0x07D9;
		public const int VariableZoomStepAk = 0x07E0;
		public const int ZeroingStepAk = 0x07E8;
		public const int UnknownData01 = 0x07F0;
		public const int AmmoPerClip = 0x07F4;
		public const int CurrentAmmoInClip = 0x07F8;
		public const int bIsHipped = 0x07FC;
		public const int UnknownData02 = 0x07FD;
		public const int TimeBetweenShots = 0x0800;
		public const int UnknownData03 = 0x0804;
		public const int FiringModeIndex = 0x082C;
		public const int UnknownData04 = 0x0830;
		public const int WeaponGunConfig = 0x08B8;
		public const int WeaponDeviationConfig = 0x0948;
		public const int UnknownData05 = 0x098C;
		public const int WeaponGunAnim = 0x0990;
		public const int WeaponGunPostprocessSettings = 0x0A80;
		public const int ScopingAttachPoint = 0x0AD0;
		public const int ScopingFocusPoint = 0x0AD8;
	}

	public class AVehicleSeatActor
	{
		public const int ViewPitchMin = 0x03B0;
		public const int ViewPitchMax = 0x03B4;
		public const int ViewYawMin = 0x03B8;
		public const int ViewYawMax = 0x03BC;
		public const int CurvePitchMax = 0x03C0;
		public const int CurvePitchMin = 0x03C8;
		public const int bCanOnlyFireWhileAiming = 0x03D0;
		public const int UnknownData00 = 0x03D1;
		public const int SeatBlendspaceAiming = 0x03D8;
		public const int SeatAnimationIdle = 0x03E0;
		public const int SeatIdleAO = 0x03E8;
		public const int TransitionOutBlendspace = 0x03F0;
		public const int TransitionInBlendspace = 0x03F8;
		public const int bRestricWeaponUse = 0x0400;
		public const int UnknownData01 = 0x0401;
		public const int AllowedWeaponClasses = 0x0408;
		public const int bUseEntryVelocityRestriction = 0x0418;
		public const int UnknownData02 = 0x0419;
		public const int MaxVelocityForEntry = 0x041C;
		public const int Rider = 0x0420;
		public const int UnknownData03 = 0x0428;
		public const int SeatAnimationType = 0x0434;
		public const int UnknownData04 = 0x0435;
	}

	public class AWeaponProcessor
	{
		public const int UnknownData00 = 0x03B0;
		public const int OnWeaponProcessorArmed = 0x03B8;
		public const int UnknownData01 = 0x03C8;
		public const int EquippedWeapons = 0x0448;
		public const int CurrentWeaponIndex = 0x0458;
		public const int UnknownData02 = 0x045C;
	}

	public class UVaultingData
	{
		public const int LocationStartNormalScale = 0x0030;
		public const int LocationStartZOffset = 0x0034;
		public const int LocationEndNormalScale = 0x0038;
		public const int LocationEndZOffset = 0x003C;
		public const int bIsClimb = 0x0040;
		public const int bIsSlide = 0x0041;
		public const int UnknownData00 = 0x0042;
		public const int VaultInitialTimer = 0x0044;
		public const int ApexAdditiveStartTime = 0x0048;
		public const int ApexAdditiveEndTime = 0x004C;
		public const int PreApexSpeedScale = 0x0050;
		public const int PostApexSpeedScale = 0x0054;
		public const int VaultEndToFallTimerCutoff = 0x0058;
		public const int StartCutoffByDistance_InMap = 0x005C;
		public const int StartCutoffByDistance_OutMap = 0x0064;
		public const int StartCutoffBySpeed_InMap = 0x006C;
		public const int StartCutoffBySpeed_OutMap = 0x0074;
		public const int PlayrateBySpeed_InMap_PreApex = 0x007C;
		public const int PlayrateBySpeed_OutMap_PreApex = 0x0084;
		public const int PlayrateBySpeed_InMap_PostApex = 0x008C;
		public const int PlayrateBySpeed_OutMap_PostApex = 0x0094;
		public const int UnknownData01 = 0x009C;
		public const int AnimationSequence = 0x00A0;
		public const int AnimationCurve = 0x00A8;
		public const int CharLocationInterpSpeedInMap = 0x00B0;
		public const int CharLocationInterpSpeedOutMap = 0x00B8;
		public const int TimerProgressionByDistanceInMap = 0x00C0;
		public const int TimerProgressionByDistanceOutMap = 0x00C8;
		public const int TimerProgressionVTimerMax = 0x00D0;
		public const int VaultEndTimerNormal = 0x00D4;
		public const int VaultEndTimerFall = 0x00D8;
		public const int CharacterPostVaultVelocityScalar = 0x00DC;
		public const int CharacterPostVaultVelocityScalarVector = 0x00E0;
		public const int CharacterPostVaultVelocityScalarVector_ToFall = 0x00EC;
		public const int AnimBlendInTime = 0x00F8;
		public const int AnimBlendOutTime = 0x00FC;
		public const int bCanVaultWithWeapon = 0x0100;
		public const int bIsCancellable = 0x0101;
		public const int UnknownData02 = 0x0102;
		public const int MinCancelVTimer = 0x0104;
		public const int MaxCancelVTimer = 0x0108;
		public const int TaskEndVTimer = 0x010C;
		public const int PostVaultTimerProgressionScale = 0x0110;
		public const int bUseStaticVTimerDampening = 0x0114;
		public const int bUseMappedVTimerDampening = 0x0115;
		public const int UnknownData03 = 0x0116;
		public const int StaticDampeningScalar = 0x0118;
		public const int StaticDampeningVTimerMax = 0x011C;
		public const int MappedDampeningScalar = 0x0120;
		public const int MappedDampeningVTimerMax = 0x0124;
		public const int bUseCustomApexForTimer = 0x0128;
		public const int UnknownData04 = 0x0129;
		public const int CustomApex = 0x012C;
	}

	public class ATslCharacter
	{
		public const int TslPawnInputBindingComponent = 0x0830;
		public const int TimerHandle_Targeting_HoldADS = 0x0838;
		public const int bShouldAiming = 0x0840;
		public const int bPeekLeftToggled = 0x0841;
		public const int bPeekRightToggled = 0x0842;
		public const int UnknownData00 = 0x0843;
		public const int CurrentAttackerPlayerState = 0x0844;
		public const int LastAttackedPlayerState = 0x084C;
		public const int UnknownData01 = 0x0854;
		public const int NoBagSpaceDelgate = 0x08A0;
		public const int UnknownData02 = 0x08B0;
		public const int UnknownData03 = 0x0908;
		public const int LastPossessedController = 0x0950;
		public const int Banks = 0x0958;
		public const int BuffComponent = 0x0968;
		public const int UnknownData04 = 0x0970;
		public const int Remote_CastAnim = 0x09B0;
		public const int UnknownData05 = 0x09B1;
		public const int RevivingCharacter = 0x09B8;
		public const int GroggyPlayerInstigator = 0x09C0;
		public const int SavedCameraFOV = 0x09C8;
		public const int SavedCamera = 0x0A18;
		public const int UnknownData06 = 0x0A20;
		public const int CurrentVariableZoomLevel = 0x0A40;
		public const int BuffFinalSpreadFactor = 0x0A44;
		public const int InventoryFacade = 0x0A48;
		public const int WeaponProcessor = 0x0A50;
		public const int CharacterState = 0x0A58;
		public const int UnknownData07 = 0x0A59;
		public const int DropPackageType = 0x0A78;
		public const int SoundClearAk = 0x0A80;
		public const int RemoteVolumeControlOn = 0x0A88;
		public const int RemoteVolumeControlOff = 0x0A90;
		public const int CameraFovRatioCurve = 0x0A98;
		public const int HeavyFallVerticalVelocityThreshold = 0x0AA0;
		public const int ExtremeFallVerticalVelocityThreshold = 0x0AA4;
		public const int ProneFallVerticalVelocityThreshold = 0x0AA8;
		public const int HeavyFallMovementStopTime = 0x0AAC;
		public const int ExtremeFallMovementStopTime = 0x0AB0;
		public const int UnknownData08 = 0x0AB4;
		public const int Punch_Damage = 0x0AB8;
		public const int PunchHeavy_Damage = 0x0ABC;
		public const int UnarmedDamageType = 0x0AC0;
		public const int ZombieDamageType = 0x0AC8;
		public const int Punch_Distance = 0x0AD0;
		public const int PunchHeavy_Distance = 0x0AD4;
		public const int Punch_Radius = 0x0AD8;
		public const int PunchHeavy_Radius = 0x0ADC;
		public const int Punch_InitialLocation = 0x0AE0;
		public const int UnknownData09 = 0x0AEC;
		public const int LeanLeftTraceOffset = 0x0AF0;
		public const int LeanRightTraceOffset = 0x0AFC;
		public const int UnknownData10 = 0x0B08;
		public const int LeanOffset_Stand = 0x0B10;
		public const int LeanOffset_Crouch = 0x0B14;
		public const int LeanOffset_Prone = 0x0B18;
		public const int UnknownData11 = 0x0B1C;
		public const int Sprint_MaxSpeed = 0x0B2C;
		public const int Sprint_MinSpeed = 0x0B30;
		public const int SprintingFOV = 0x0B34;
		public const int MinimumBreathToHold = 0x0B38;
		public const int UnknownData12 = 0x0B3C;
		public const int SwimPoint = 0x0B40;
		public const int SwimableWaterDepth = 0x0B48;
		public const int CrouchWaterDepth = 0x0B4C;
		public const int ProneWaterDepth = 0x0B50;
		public const int WaterFloorDetectionLength = 0x0B54;
		public const int SwimMaxControllerPitch = 0x0B58;
		public const int UnderwaterSwimGapFromSurface = 0x0B5C;
		public const int SwimTrailEffectClass = 0x0B60;
		public const int SwimTrailEffect = 0x0B68;
		public const int ParticleSocket_SwimIdleRipple = 0x0B70;
		public const int SwimIdleRippleEffectClass = 0x0B78;
		public const int maxNumSwimIdleRippleEffect = 0x0B80;
		public const int SwimIdleRippleOffsetFromSurface = 0x0B84;
		public const int UnknownData13 = 0x0B88;
		public const int BreathComponent = 0x0BA0;
		public const int BreathPoint = 0x0BA8;
		public const int UnderwaterChokeEffectClass = 0x0BB0;
		public const int UnderwaterChokeEffect = 0x0BB8;
		public const int IndoorCheckDistance = 0x0BC0;
		public const int UnknownData14 = 0x0BC4;
		public const int IndoorCheckHalfConeAngle = 0x0BC8;
		public const int IndoorCheckSuccessRate = 0x0BCC;
		public const int IndoorCheckSamplingQueueSize = 0x0BD0;
		public const int IndoorCheckAccuracyMultiplier = 0x0BD4;
		public const int UnknownData15 = 0x0BD8;
		public const int FootSoundObstructionCheckInterval = 0x0BE8;
		public const int FootSoundObstructionCheckMaxDistance = 0x0BEC;
		public const int UnknownData16 = 0x0BF0;
		public const int ParachuteAttachPoint = 0x0BF8;
		public const int ReleasingParachuteAltitude = 0x0C00;
		public const int ForceReleasingParachuteAltitude = 0x0C04;
		public const int MinimumParachuteAltitude = 0x0C08;
		public const int UnknownData17 = 0x0C0C;
		public const int ParachuteType = 0x0C10;
		public const int bParachuteLandingAssist = 0x0C18;
		public const int UnknownData18 = 0x0C19;
		public const int CastComponent = 0x0C20;
		public const int StanceComponent = 0x0C28;
		public const int HackReporterComponent = 0x0C30;
		public const int bAcceptHitsWhileNotAlive = 0x0C38;
		public const int UnknownData19 = 0x0C39;
		public const int SimulatedHit_Initial = 0x0C3C;
		public const int SimulatedHit_RecoveryPerSecond = 0x0C40;
		public const int SimulatedHit_Value = 0x0C44;
		public const int SimulatedHit_ImpulsePower = 0x0C48;
		public const int SimlatedHit_PunchLightPower = 0x0C4C;
		public const int SimlatedHit_PunchHeavyPower = 0x0C50;
		public const int UnknownData20 = 0x0C54;
		public const int PunchImpactEffect = 0x0C58;
		public const int UnknownData21 = 0x0C60;
		public const int WeaponAnimInfoComponent = 0x0C88;
		public const int CharacterAccessory_Primary = 0x0C90;
		public const int CharacterAccessory_Secondary = 0x0C98;
		public const int CharacterAccessory_Sidearm = 0x0CA0;
		public const int CharacterAccessory_Melee = 0x0CA8;
		public const int CharacterAccessory_Thrown = 0x0CB0;
		public const int FootStepEffectClassInDirt = 0x0CB8;
		public const int FootStepEffectClassInGrass = 0x0CC0;
		public const int FootStepEffectClassInRock = 0x0CC8;
		public const int FootStepEffectClassInSand = 0x0CD0;
		public const int ParticleSocketFootLeft = 0x0CD8;
		public const int ParticleSocketFootRight = 0x0CE0;
		public const int FootStepEffectClassInWater = 0x0CE8;
		public const int FootStepEffect = 0x0CF0;
		public const int Team = 0x0CF8;
		public const int UnknownData22 = 0x0D00;
		public const int ViewTargetTempComponent = 0x0D20;
		public const int ValidateLocationComponent = 0x0D28;
		public const int ThrowableTrajectoryViewComponent = 0x0D30;
		public const int UnknownData23 = 0x0D38;
		public const int CharacterNetId = 0x0D58;
		public const int CharacterName = 0x0D68;
		public const int HeadAttachPoint = 0x0D78;
		public const int CameraHeadHideDistance = 0x0D80;
		public const int UnknownData24 = 0x0D84;
		public const int CrouchedCameraMove = 0x0D90;
		public const int PronedCameraMove = 0x0D9C;
		public const int GroggyCameraMove = 0x0DA8;
		public const int CrouchedCameraMoveSpeed = 0x0DB4;
		public const int PronedCameraMoveSpeed = 0x0DB8;
		public const int GroggyCameraMoveSpeed = 0x0DBC;
		public const int UnknownData25 = 0x0DC0;
		public const int LastTakeHitInfo = 0x0E08;
		public const int UnknownData26 = 0x0E48;
		public const int TargetingSpeedModifier = 0x0E4C;
		public const int TargetingType = 0x0E50;
		public const int UnknownData27 = 0x0E51;
		public const int Stand_RunningSpeedModifier = 0x0E54;
		public const int Stand_SprintingSpeedModifier = 0x0E58;
		public const int Stand_SprintingBigGunModifier = 0x0E5C;
		public const int Stand_SprintingRifleModifier = 0x0E60;
		public const int Stand_SprintingSmallGunMOdifier = 0x0E64;
		public const int Crouch_RunningSpeedModifier = 0x0E68;
		public const int Crouch_SprintingSpeedModifier = 0x0E6C;
		public const int Prone_RunningSpeedModifier = 0x0E70;
		public const int Prone_SprintingSpeedModifier = 0x0E74;
		public const int ReviveCastingTime = 0x0E78;
		public const int bWantsToRun = 0x0E7C;
		public const int bWantsToSprint = 0x0E7C;
		public const int bWantsToSprintingAuto = 0x0E7C;
		public const int bWantsToRollingLeft = 0x0E7C;
		public const int bWantsToRollingRight = 0x0E7C;
		public const int bIsPeekLeft = 0x0E7C;
		public const int bIsPeekRight = 0x0E7C;
		public const int IgnoreRotation = 0x0E7C;
		public const int bIsGroggying = 0x0E7D;
		public const int bIsThirdPerson = 0x0E7D;
		public const int UnknownData28 = 0x0E7D;
		public const int bIsReviving = 0x0E7D;
		public const int bIsWeaponObstructed = 0x0E7D;
		public const int bIsCoatEquipped = 0x0E7D;
		public const int bIsZombie = 0x0E7D;
		public const int bIsThrowHigh = 0x0E7D;
		public const int UnknownData29 = 0x0E7E;
		public const int bUseRightShoulderAiming = 0x0E80;
		public const int UnknownData30 = 0x0E81;
		public const int GunDirectionSway = 0x0E84;
		public const int AimOffsets = 0x0E90;
		public const int LastAimOffsets = 0x0E9C;
		public const int AimoffsetsLastRepTime = 0x0EA8;
		public const int UnknownData31 = 0x0EAC;
		public const int CurrentAutoRotator = 0x0EE4;
		public const int AutoPitchValueMax = 0x0EF0;
		public const int AutoPitchBlendSpeed = 0x0EF4;
		public const int UnknownData32 = 0x0EF8;
		public const int Curve_JumpCamera = 0x0F00;
		public const int Curve_FPPCameraOffsetByFOV = 0x0F08;
		public const int Curve_DBNOFadeOut = 0x0F10;
		public const int DBNOFadeOutLerpSpeed = 0x0F18;
		public const int UnknownData33 = 0x0F1C;
		public const int Curve_StandWalk = 0x0F20;
		public const int Curve_StandRun = 0x0F28;
		public const int Curve_StandSprint = 0x0F30;
		public const int Curve_CrouchWalk = 0x0F38;
		public const int Curve_CrouchRun = 0x0F40;
		public const int Curve_CrouchSprint = 0x0F48;
		public const int Curve_ProneWalk = 0x0F50;
		public const int Curve_ProneRun = 0x0F58;
		public const int Curve_ProneSprint = 0x0F60;
		public const int Curve_Swim = 0x0F68;
		public const int Curve_UnderwaterSwim = 0x0F70;
		public const int Curve_StandScope = 0x0F78;
		public const int Curve_CrouchScope = 0x0F80;
		public const int Curve_ProneScope = 0x0F88;
		public const int Curve_StandAim = 0x0F90;
		public const int Curve_CrouchAim = 0x0F98;
		public const int Curve_ProneAim = 0x0FA0;
		public const int Curve_DBNO = 0x0FA8;
		public const int Curve_GroundAngle = 0x0FB0;
		public const int Curve_WeaponSway = 0x0FB8;
		public const int Curve_TurningLerp = 0x0FC0;
		public const int Curve_TurningLerpLocomotion = 0x0FC8;
		public const int DirectionalSpeedModifier = 0x0FD0;
		public const int PointDamageForceMultiplier = 0x0FD4;
		public const int PointDamageForce_MapMin = 0x0FD8;
		public const int PointDamageForce_MapMax = 0x0FDC;
		public const int RadialDamageForceMultiplier = 0x0FE0;
		public const int RadialDamageFalloffType = 0x0FE4;
		public const int UnknownData34 = 0x0FE5;
		public const int RollLeftAnim = 0x0FE8;
		public const int RollRightAnim = 0x0FF0;
		public const int CharacterAnim = 0x0FF8;
		public const int NetOwnerController = 0x1008;
		public const int LeanAlphaSpeed = 0x1010;
		public const int TurnSpeedHip = 0x1014;
		public const int TurnSpeedAimed = 0x1018;
		public const int TurnSpeedOverLimit = 0x101C;
		public const int MinTurnAngleHip = 0x1020;
		public const int MinTurnAngleAim = 0x1024;
		public const int TurnLinearEndThreshold = 0x1028;
		public const int bNonLinearTurn = 0x102C;
		public const int UnknownData35 = 0x102D;
		public const int TurnNonLinearEndThreshold = 0x1030;
		public const int TurnNonLinearInterpSpeed = 0x1034;
		public const int CapsuleTurnInterpSpeedLocomotion = 0x1038;
		public const int CapsuleTurnInterpSpeedLocomotionSprint = 0x103C;
		public const int CapsuleTurnInterpSpeedLocomotionProne = 0x1040;
		public const int CapsuleTurnInterpSpeedStationary = 0x1044;
		public const int UnknownData36 = 0x1048;
		public const int FPPCameraBoneName = 0x1060;
		public const int TPPCameraBoneName = 0x1068;
		public const int UnknownData37 = 0x1070;
		public const int AimStateDefaultTime = 0x107C;
		public const int AimStateReturnTime = 0x1080;
		public const int AimStateDrawTime = 0x1084;
		public const int UnknownData38 = 0x1088;
		public const int bAimStateActive = 0x1090;
		public const int UnknownData39 = 0x1091;
		public const int CanGroggyDamageTime = 0x1094;
		public const int GroggyStartText = 0x1098;
		public const int GroggyCancelText = 0x10B0;
		public const int GroggyFinishText = 0x10C8;
		public const int GamepadRunningValue = 0x10E0;
		public const int UnknownData40 = 0x10E4;
		public const int BlendTargetViewRotation = 0x10F0;
		public const int DesiredDirection = 0x10FC;
		public const int UnknownData41 = 0x1104;
		public const int InvulnerablilityBuff = 0x1108;
		public const int bInvulnerablilityEffectVisible = 0x1110;
		public const int UnknownData42 = 0x1111;
		public const int ComponentsToDestroyOnDedicatedServer = 0x1118;
		public const int ZombieCustomizationData = 0x1128;
		public const int bIsHoldingBreath = 0x1138;
		public const int UnknownData43 = 0x1139;
		public const int Health = 0x113C;
		public const int HealthMax = 0x1140;
		public const int GroggyHealth = 0x1144;
		public const int GroggyHealthMax = 0x1148;
		public const int DecreaseGroggyHealthPerSecond = 0x114C;
		public const int GroggyDamageWeight = 0x1150;
		public const int UnknownData44 = 0x1154;
		public const int GroggyDamageType = 0x1158;
		public const int HealthByRevive = 0x1160;
		public const int UnknownData45 = 0x1164;
		public const int GroggyToDieAkEvent = 0x1168;
		public const int BoostGauge = 0x1170;
		public const int BoostGaugeMax = 0x1174;
		public const int DecreaseTimerSecond = 0x1178;
		public const int DecreaseBoostGaugeByTime = 0x117C;
		public const int BuffWithBoostGauge = 0x1180;
		public const int MedKitClass = 0x1190;
		public const int FirstAidClass = 0x1198;
		public const int BandageClass = 0x11A0;
		public const int AdrenalineClass = 0x11A8;
		public const int PainKillerClass = 0x11B0;
		public const int EnergyDrinkClass = 0x11B8;
		public const int BoostItemClasses = 0x11C0;
		public const int HealItemClasses = 0x11D0;
		public const int GrenadeClass = 0x11E0;
		public const int MolotovClass = 0x11E8;
		public const int SmokeBombClass = 0x11F0;
		public const int FlashBangClass = 0x11F8;
		public const int UnknownData46 = 0x1200;
		public const int LaunchInstigator = 0x1204;
		public const int LaunchCauser = 0x120C;
		public const int UnknownData47 = 0x1214;
		public const int LaunchDamageTypeClass = 0x1218;
		public const int LastLaunchTime = 0x1220;
		public const int AuthorizedPlayerState = 0x1228;
		public const int ShoesSoundType = 0x1230;
		public const int UnknownData48 = 0x1231;
		public const int InteractorComponent = 0x1238;
		public const int InteractionComponent = 0x1240;
		public const int VehicleRiderComponent = 0x1248;
		public const int OutSidePlayerAreaEffectClass = 0x1250;
		public const int OutSidePlayerAreaEffect = 0x1258;
		public const int DBNOEffectClass = 0x1260;
		public const int DBNOEffect = 0x1268;
		public const int UnknownData49 = 0x1270;
		public const int ShadowMesh = 0x1450;
		public const int TargetingFOV = 0x1458;
		public const int AimingDelay = 0x145C;
		public const int UnknownData50 = 0x1460;
		public const int ScopingDelay = 0x1464;
		public const int AttackStateOffDelayTime = 0x1468;
		public const int HitStateOffDelayTime = 0x146C;
		public const int HitMePlayerStateOffDelayTime = 0x1470;
		public const int UnknownData51 = 0x1474;
		public const int DamageConfig = 0x14A8;
		public const int UnknownData52 = 0x14B0;
		public const int FallDamageFactor = 0x14B4;
		public const int FallDamageVelocityMin = 0x14B8;
		public const int bIsActiveRagdollActive = 0x14BC;
		public const int UnknownData53 = 0x14BD;
		public const int CorpseLifeSpan = 0x14C0;
		public const int UnknownData54 = 0x14C4;
		public const int JumpStartLocation_CP = 0x1518;
		public const int LandPredictedLocation_CP = 0x1524;
		public const int FallHeight_CP = 0x1530;
		public const int bIsVaulting_CP = 0x1534;
		public const int UnknownData55 = 0x1535;
		public const int VaultTimer_CP = 0x1538;
		public const int VaultEndVelocity_CP = 0x153C;
		public const int VaultLastLocation_CP = 0x1548;
		public const int bIsClimbing_CP = 0x1554;
		public const int bEndVaultToFall_CP = 0x1555;
		public const int UnknownData56 = 0x1556;
		public const int VaultEndVelocityVectorMutliplier = 0x1558;
		public const int VaultEndVelocityVectorClamp = 0x1564;
		public const int VaultingHelperRef = 0x1568;
		public const int bIsVaultingSystemEnabled = 0x1570;
		public const int UnknownData57 = 0x1571;
		public const int VaultingDirection_CP = 0x1574;
		public const int CurrentVaultData_CP = 0x1578;
		public const int bServerFinishedVault = 0x1580;
		public const int UnknownData58 = 0x1581;
		public const int JumpDelay = 0x1584;
		public const int JumpLastTimer = 0x1588;
		public const int bWantsToVault = 0x158C;
		public const int bWantsToCancelVault = 0x158D;
		public const int UnknownData59 = 0x158E;
		public const int VaultProbeLoopTime = 0x1590;
		public const int UnknownData60 = 0x1594;
		public const int AnimationUpdateRateSettings = 0x1598;
		public const int TO_CulledMovementTickrate = 0x1610;
		public const int TO_CulledActorTickInterval = 0x1614;
		public const int TO_MinimumDistance = 0x1618;
		public const int bRunTickOptimization = 0x161C;
		public const int bRunTickOptimization_Anim = 0x161D;
		public const int bRunTickOptimization_Movement = 0x161E;
		public const int UnknownData61 = 0x161F;
		public const int TO_RenderedTolerance = 0x1620;
		public const int bTickOptimization_Move_Active = 0x1624;
		public const int bTickOptimization_Anim_Active = 0x1625;
		public const int bTickOptimization_Actor_Active = 0x1626;
		public const int UnknownData62 = 0x1627;
		public const int GamepadReloadHoldTime = 0x162C;
		public const int GamepadUnarmHoldTime = 0x1630;
		public const int GamepadNextGunWeaponTabMaxTime = 0x1634;
		public const int UnknownData63 = 0x1638;
		public const int BluezoneInOut = 0x1688;
		public const int BluezoneInOutSoundEffect = 0x1690;
		public const int UnknownData64 = 0x1698;
	}

	public class UObserverTagWidget
	{
		public const int Character = 0x0240;
		public const int OffsetZ = 0x0248;
		public const int Distance = 0x024C;
	}

	public class AParachuteVehicle
	{
		public const int UnknownData00 = 0x0410;
		public const int OnRelease = 0x0420;
		public const int OnLand = 0x0430;
		public const int ReleaseSound_Local = 0x0440;
		public const int ReleaseSound_Remote = 0x0448;
		public const int LandSound_Local = 0x0450;
		public const int LandSound_Remote = 0x0458;
		public const int FallingStartSound_Local = 0x0460;
		public const int FallingStartSound_Remote = 0x0468;
		public const int AkSoundCom = 0x0470;
		public const int TslPawnInputBindingComponent = 0x0478;
		public const int MeshComponent = 0x0480;
		public const int ParachuteMovementComponent = 0x0488;
		public const int FreeFallMovementComponent = 0x0490;
		public const int VehicleSeatComponent = 0x0498;
		public const int InteractionComponent = 0x04A0;
		public const int LastDriver = 0x04A8;
		public const int UnknownData01 = 0x04B0;
		public const int FreeFallFirstPersonCameraName = 0x04B8;
		public const int FreeFallThirdPersonCameraName = 0x04C0;
		public const int FreeFallCameraPitchMin = 0x04C8;
		public const int FreeFallCameraPitchMax = 0x04CC;
		public const int ReleasingAltitude = 0x04D0;
		public const int ForceReleasingAltitude = 0x04D4;
		public const int UnknownData02 = 0x04D8;
		public const int SweepMoveHeight = 0x04F0;
		public const int LandingHeight = 0x04F4;
		public const int LandingDuration = 0x04F8;
		public const int UnknownData03 = 0x04FC;
		public const int LandingBuff = 0x0500;
		public const int UnknownData04 = 0x0508;
		public const int StuckCheckDistance = 0x0514;
		public const int StuckCheckDuration = 0x0518;
		public const int UnknownData05 = 0x051C;
		public const int UnknownData06 = 0x0528;
		public const int ForwardInputRepApplied = 0x0528;
		public const int ForwardInputRepIsForward = 0x0528;
		public const int RightInputRepApplied = 0x0528;
		public const int RightInputRepIsRight = 0x0528;
		public const int bIsReleased = 0x0528;
		public const int bIsDriven = 0x0528;
		public const int UnknownData07 = 0x0529;
		public const int SkinData = 0x0530;
		public const int InitialRotation = 0x0550;
		public const int InitialVelocity = 0x055C;
		public const int RideSocketOffset = 0x0568;
		public const int LeaveSocketOffset = 0x0574;
	}

	public class AReplicationTrigger
	{
		public const int UnknownData00 = 0x03B0;
		public const int TargetReplicatedActors = 0x03B8;
		public const int UnknownData01 = 0x03C8;
		public const int ReplicationGroupCount = 0x03CC;
		public const int UnknownData02 = 0x03D0;
		public const int ReplicationGroupIntervalSeconds = 0x03D4;
		public const int UnknownData03 = 0x03D8;
	}

	public class AReplicationTriggerManager
	{
		public const int TargetReplicatedActorClasses = 0x03B0;
		public const int TriggerRadius = 0x03C0;
		public const int TriggerInterval = 0x03C4;
		public const int Triggers = 0x03C8;
	}

	public class UReporterManager
	{
		public const int UnknownData00 = 0x0028;
	}

	public class URewardData
	{
		public const int DefaultScoreMultiplierByDamage = 0x0030;
		public const int DefaultScoreMultiplierByKill = 0x0034;
		public const int ScoreByReverseRanking = 0x0038;
		public const int ScoreMultiplierByRanking = 0x0048;
	}

	public class USceneInteractionComponent
	{
		public const int UnknownData00 = 0x03E0;
		public const int MaxInteractableDistance = 0x03F0;
		public const int UnknownData01 = 0x03F4;
		public const int InteractionVerb = 0x03F8;
		public const int InteractiveObjectName = 0x0410;
		public const int bUseTraceCheck = 0x0428;
		public const int UnknownData02 = 0x0429;
		public const int CastConfig = 0x0430;
		public const int UnknownData03 = 0x0460;
		public const int OnInteractBy = 0x0468;
		public const int ClientOnInteractBy = 0x0478;
		public const int UnknownData04 = 0x0488;
	}

	public class UDoorInteractionComponent
	{
		public const int UnknownData00 = 0x04F0;
		public const int DoorState = 0x04F8;
		public const int bReverseRotation = 0x04F9;
		public const int bIgnoreParentValidityCheck = 0x04F9;
		public const int UnknownData01 = 0x04FA;
		public const int SoundOffset = 0x04FC;
		public const int DoorDataAsset = 0x0508;
		public const int UnknownData02 = 0x0510;
		public const int AkAudioComponent = 0x06D0;
		public const int UnknownData03 = 0x06D8;
	}

	public class UDroppedItemInteractionComponent
	{
		public const int UnknownData00 = 0x04F0;
		public const int Item = 0x0528;
		public const int UnknownData01 = 0x0530;
		public const int StaticMeshComponent = 0x0538;
		public const int UnknownData02 = 0x0540;
	}

	public class UVehicleSeatInteractionComponent
	{
		public const int Rider = 0x04F0;
		public const int UnknownData00 = 0x04F8;
		public const int SeatIndex = 0x0504;
		public const int RiderType = 0x0508;
		public const int UnknownData01 = 0x0509;
		public const int LeaveSocketName = 0x0510;
		public const int ViewPitchMin = 0x0518;
		public const int ViewPitchMax = 0x051C;
		public const int ViewYawMin = 0x0520;
		public const int ViewYawMax = 0x0524;
		public const int CurvePitchMax = 0x0528;
		public const int CurvePitchMin = 0x0530;
		public const int FirstPersonCameraName = 0x0538;
		public const int ThirdPersonCameraName = 0x0540;
		public const int SeatAnimationType = 0x0548;
		public const int UnknownData02 = 0x0549;
		public const int SeatBlendspaceAiming = 0x0550;
		public const int SeatBlendspaceFPPAiming = 0x0558;
		public const int SeatAnimationIdle_Rifle = 0x0560;
		public const int SeatAnimationIdle_Melee = 0x0568;
		public const int SeatAnimationIdle_Unarmed = 0x0570;
		public const int SeatAnimationIdle_Grenade = 0x0578;
		public const int SeatIdleAO = 0x0580;
		public const int TransitionOutBlendspace = 0x0588;
		public const int TransitionInBlendspace = 0x0590;
		public const int bRestricWeaponUse = 0x0598;
		public const int UnknownData03 = 0x0599;
		public const int AllowedWeaponClasses = 0x05A0;
		public const int bCanOnlyFireWhileAiming = 0x05B0;
		public const int bUseEntryVelocityRestriction = 0x05B1;
		public const int UnknownData04 = 0x05B2;
		public const int MaxVelocityForEntry = 0x05B4;
		public const int InteractionBlockDuration = 0x05B8;
		public const int UnknownData05 = 0x05BC;
	}

	public class USimpleInterpolationMovement
	{
		public const int UnknownData00 = 0x0260;
		public const int LocationInterpTime = 0x0278;
		public const int UnknownData01 = 0x027C;
		public const int RotationInterpTime = 0x02B4;
		public const int UnknownData02 = 0x02B8;
		public const int bUseOnlyYawRotation = 0x02F0;
		public const int bUseSweepMove = 0x02F1;
		public const int bUseSafeInterpolation = 0x02F2;
		public const int UnknownData03 = 0x02F3;
		public const int ForceMoveTime = 0x02F4;
		public const int UnknownData04 = 0x02F8;
	}

	public class UFreeFallMovement
	{
		public const int MinPitch = 0x0300;
		public const int MaxPitch = 0x0304;
		public const int MaxLateralSpeed = 0x0308;
		public const int LateralAcceleration = 0x030C;
		public const int LateralDeceleration = 0x0310;
		public const int LateralBrakeDeceleration = 0x0314;
		public const int VerticalAcceleration = 0x0318;
		public const int VerticalDeceleration = 0x031C;
		public const int TerminalSpeed = 0x0320;
		public const int MinAdditiveTerminalSpeed = 0x0324;
		public const int MaxAdditiveTerminalSpeed = 0x0328;
		public const int RotationYawRate = 0x032C;
		public const int UnknownData00 = 0x0330;
		public const int InputUpdateTime = 0x0340;
		public const int UnknownData01 = 0x0344;
	}

	public class UParachuteVehicleMovement
	{
		public const int UnknownData00 = 0x0300;
		public const int MaxSpeed = 0x0304;
		public const int Acceleration = 0x0308;
		public const int Deceleration = 0x030C;
		public const int MaxRotationYawRate = 0x0310;
		public const int RotationYawAcceleration = 0x0314;
		public const int RotationYawDeceleration = 0x0318;
		public const int TerminalVelocity = 0x031C;
		public const int DecreaseTerminalVelocity = 0x0320;
		public const int UnknownData01 = 0x0324;
		public const int RotationYawReplicated = 0x032C;
		public const int RotationPitchReplicated = 0x0330;
		public const int InputUpdateTime = 0x0334;
		public const int UnknownData02 = 0x0338;
		public const int ParachuteDeployCoefficient = 0x0364;
		public const int YawSpeed = 0x0368;
		public const int MaxForwardPitch = 0x036C;
		public const int MaxBackwardPitch = 0x0370;
		public const int ForceForwardScale = 0x0374;
		public const int ForceForwardStaticSpeed = 0x0378;
		public const int VelocityLERPSpeedMin = 0x037C;
		public const int VelocityLERPSpeedMax = 0x0380;
		public const int VelocityLERPValueMin = 0x0384;
		public const int VelocityLERPValueMax = 0x0388;
		public const int DampingPitchMin = 0x038C;
		public const int DampingPitchMax = 0x0390;
		public const int DampingValueMin = 0x0394;
		public const int DampingValueMax = 0x0398;
		public const int ForceDownAngleMin = 0x039C;
		public const int ForceDownAngleMax = 0x03A0;
		public const int ForceGravityMax = 0x03A4;
		public const int ForceGravitySpeedMin = 0x03A8;
		public const int ForceGravitySpeedMax = 0x03AC;
		public const int ForceGravityValueMin = 0x03B0;
		public const int ForceGravityValueMax = 0x03B4;
		public const int RollSpeedMin = 0x03B8;
		public const int RollSpeedMax = 0x03BC;
		public const int RollAngleMin = 0x03C0;
		public const int RollAngleMax = 0x03C4;
		public const int RollInterpSpeed = 0x03C8;
		public const int FinalVelocitySpeedMin = 0x03CC;
		public const int FinalVelocitySpeedMax = 0x03D0;
		public const int FinalVelocityDampingMin = 0x03D4;
		public const int FinalVelocityDampingMax = 0x03D8;
		public const int UnknownData03 = 0x03DC;
		public const int TraceSphereRadius = 0x03E0;
		public const int TraceSphereOffset = 0x03E4;
		public const int GroundTraceStart = 0x03F0;
		public const int GroundTraceEnd = 0x03F4;
		public const int GroundTraceDampingMin = 0x03F8;
		public const int GroundTraceDampingMax = 0x03FC;
	}

	public class UTslAircraftVehicleMovement
	{
		public const int UnknownData00 = 0x0300;
	}

	public class UStanceComponent
	{
		public const int StanceTransitionData = 0x01E0;
		public const int CurrentStance = 0x0240;
		public const int UnknownData00 = 0x0241;
	}

	public class ATslPlayerStart
	{
		public const int MatchStartType = 0x03E0;
		public const int UnknownData00 = 0x03E1;
		public const int StartRadius = 0x03E4;
		public const int bRandomRotation = 0x03E8;
		public const int UnknownData01 = 0x03E9;
		public const int ActivationVolumes = 0x03F0;
		public const int UnknownData02 = 0x0400;
	}

	public class AStartActivationVolume
	{
		public const int UnknownData00 = 0x03E8;
	}

	public class AInventoryFacade
	{
		public const int AutoSwapEquipSlotID = 0x03B8;
		public const int Inventory = 0x03C8;
		public const int Equipment = 0x03D0;
	}

	public class AEquipment
	{
		public const int OnEquipmentUpdated = 0x03E8;
		public const int UnknownData00 = 0x03F8;
		public const int Items = 0x0428;
	}

	public class AInventory
	{
		public const int OnInventoryUpdated = 0x03E8;
		public const int Items = 0x03F8;
		public const int MaxSpace = 0x0408;
		public const int UnknownData00 = 0x040C;
	}

	public class AItemExplorerProxy
	{
		public const int OnChangeItemExplorerProxy = 0x0418;
		public const int UnknownData00 = 0x0428;
	}

	public class ACarePackageItem
	{
		public const int ParachuteClass = 0x0510;
		public const int SmokeFxClass = 0x0518;
		public const int SmokeAirFxClass = 0x0520;
		public const int LightFxClass = 0x0528;
		public const int SmokeTime = 0x0530;
		public const int LimitFallSpeed = 0x0534;
		public const int SmokeSocket = 0x0538;
		public const int SmokeAirSocket = 0x0540;
		public const int LightSocket = 0x0548;
		public const int ParachuteSocket = 0x0550;
		public const int LandSoundAk = 0x0558;
		public const int bIsFalling = 0x0560;
		public const int bIsPickupedItem = 0x0561;
		public const int bIsHideIconOnMap = 0x0562;
		public const int bIsTranslucentIconOnMap = 0x0563;
		public const int UnknownData00 = 0x0564;
		public const int SmokeFx = 0x0568;
		public const int SmokeAirFx = 0x0570;
		public const int LightFx = 0x0578;
		public const int Parachute = 0x0580;
		public const int UnknownData01 = 0x0588;
		public const int MovementComponent = 0x0590;
		public const int BuoyancyForceComponent = 0x0598;
		public const int AkComponent = 0x05A0;
		public const int UnknownData02 = 0x05A8;
	}

	public class AFloorSnapItemPackage
	{
		public const int RayLength = 0x0510;
		public const int bUseWaterSurface = 0x0514;
		public const int UnknownData00 = 0x0515;
		public const int WaterSurfaceThreshold = 0x0518;
		public const int UnknownData01 = 0x051C;
		public const int BuoyancyForceComponent = 0x0520;
	}

	public class ANearbyInteractiveItemExplorer
	{
		public const int ExplorableItems = 0x0418;
	}

	public class UThingSpawnProcessor
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UCombinedThingSpawnProcessor
	{
		public const int SubProcessorClasses = 0x0038;
		public const int SubProcessors = 0x0048;
	}

	public class UPackageSubThingSpawnProcessor
	{
		public const int RawItemSpawnDataTable = 0x0028;
		public const int RawItemSpawnTogetherDataTable = 0x0030;
		public const int RawSpotGroupProperties = 0x0038;
		public const int UnknownData00 = 0x0048;
	}

	public class UVehicleSubThingSpawnProcessor
	{
		public const int RawSpotGroupProperties = 0x0028;
		public const int RawVehicleSpawnDataTable = 0x0038;
		public const int SpawnZOffsetFromFloor = 0x0040;
		public const int UnknownData00 = 0x0044;
	}

	public class ATeam
	{
		public const int PlayerLocation = 0x03B0;
		public const int PlayerRotation = 0x03BC;
		public const int PlayerName = 0x03C8;
		public const int Health = 0x03D8;
		public const int HealthMax = 0x03D9;
		public const int GroggyHealth = 0x03DA;
		public const int GroggyHealthMax = 0x03DB;
		public const int MapMarkerPosition = 0x03DC;
		public const int bIsDying = 0x03E4;
		public const int bIsGroggying = 0x03E4;
		public const int bQuitter = 0x03E4;
		public const int bShowMapMarker = 0x03E4;
		public const int TeamVehicleType = 0x03E5;
		public const int UnknownData00 = 0x03E6;
		public const int BoostGauge = 0x03E8;
		public const int MemberNumber = 0x03EC;
		public const int UnknownData01 = 0x03ED;
		public const int TslCharacter = 0x03F0;
		public const int UnknownData02 = 0x03F8;
		public const int UniqueId = 0x0408;
	}

	public class AThingHolder
	{
		public const int UnknownData00 = 0x03B0;
	}

	public class AThingSpot
	{
		public const int SpotComponent = 0x03B0;
	}

	public class UThingSpotComponent
	{
		public const int SpotGroupType = 0x03E0;
		public const int UnknownData00 = 0x03E1;
		public const int RandomRotatorRange = 0x03E4;
		public const int UnknownData01 = 0x03EC;
	}

	public class UTslAccessoryComponent
	{
		public const int InitialTransformAttachmentScene = 0x03E0;
		public const int UnknownData00 = 0x0410;
	}

	public class ATslAchievement
	{
		public const int UnknownData00 = 0x03B0;
	}

	public class ATslAIController
	{
		public const int BlackboardComp = 0x04A8;
		public const int BehaviorComp = 0x04B0;
		public const int UnknownData00 = 0x04B8;
	}

	public class ATslAircraftVehicle
	{
		public const int AircraftParticles = 0x0410;
		public const int AttachedParticles = 0x0420;
		public const int MeshComponent = 0x0430;
		public const int MovementComponent = 0x0438;
		public const int SplineComponent = 0x0440;
		public const int UnknownData00 = 0x0448;
		public const int TotalFlyingTime = 0x0490;
		public const int UnknownData01 = 0x0494;
	}

	public class AAircraftCarePackage
	{
		public const int CarePackageItemSpawnerClass = 0x04A0;
		public const int CarePackageItemClass = 0x04A8;
		public const int DropCarePackageTableData = 0x04B0;
		public const int CarePackageItemSpawner = 0x04C0;
		public const int PassCarePackageAreas = 0x04C8;
		public const int PassCarePackageAreasRectangle = 0x04D8;
		public const int UnknownData00 = 0x04E8;
	}

	public class ATransportAircraftVehicle
	{
		public const int UnknownData00 = 0x04A0;
		public const int RideSound = 0x04C8;
		public const int LeaveSound = 0x04D0;
		public const int AkSoundCom = 0x04D8;
		public const int VehicleSeatComponent = 0x04E0;
		public const int ParachuteItem = 0x04E8;
		public const int InteractionComponent = 0x04F0;
		public const int bIsEnteredAtEjectionArea = 0x04F8;
		public const int UnknownData01 = 0x04F9;
		public const int bIsVisible = 0x04FA;
		public const int UnknownData02 = 0x04FB;
		public const int EjectPredictionTime = 0x04FC;
		public const int MaxEjectSpeed = 0x0500;
		public const int UnknownData03 = 0x0504;
	}

	public class ATslWheeledVehicle
	{
		public const int UnknownData00 = 0x0420;
		public const int ActivationTrigger = 0x0440;
		public const int Health = 0x0448;
		public const int HealthMax = 0x044C;
		public const int Fuel = 0x0450;
		public const int FuelMax = 0x0454;
		public const int bStabilizeActive = 0x0458;
		public const int UnknownData01 = 0x0459;
		public const int AirControlPitchInput = 0x045C;
		public const int SpeedKPH = 0x0460;
		public const int ThrottleInput = 0x0464;
		public const int RPM = 0x0468;
		public const int Brake = 0x046C;
		public const int LatMax = 0x0470;
		public const int LongSum = 0x0474;
		public const int WaterDepthMax = 0x0478;
		public const int SurfaceMax = 0x047C;
		public const int SuspensionMax = 0x0480;
		public const int FlatTireCount = 0x0484;
		public const int bDirtySpeedKPH = 0x0488;
		public const int bDirtyThrottleInput = 0x0488;
		public const int bDirtyRPM = 0x0488;
		public const int bDirtyWaterDepthMax = 0x0488;
		public const int bDirtyBrake = 0x0488;
		public const int bDetectedStartup = 0x0488;
		public const int bDetectedBraking = 0x0488;
		public const int UnknownData02 = 0x0489;
		public const int WheelsLatSlip = 0x0490;
		public const int WheelsLongSlip = 0x04A0;
		public const int WheelsSuspensionOffset = 0x04B0;
		public const int WheelsContactSurface = 0x04C0;
		public const int TestWheelsContactSurface_prev = 0x04D0;
		public const int WheelsSuspensionMaxDrop = 0x04E0;
		public const int WheelsSuspensionMaxRaise = 0x04F0;
		public const int NullSound = 0x0500;
		public const int ImpactSound = 0x0508;
		public const int LandingSound = 0x0568;
		public const int StartupSound = 0x05C8;
		public const int BreakSound = 0x05D0;
		public const int StopSound = 0x05D8;
		public const int CharacterHitSound = 0x05E0;
		public const int MaxClampThrottleInClutch = 0x05E8;
		public const int bApplyCustomAnimUpdaterateSettings = 0x05EC;
		public const int UnknownData03 = 0x05ED;
		public const int AnimUpdateRateSettings = 0x05F0;
		public const int bWantsToBoosting = 0x0668;
		public const int UnknownData04 = 0x0669;
		public const int TorqueMultiplierForBoosting = 0x066C;
		public const int UnknownData05 = 0x0670;
		public const int VehicleHitComponent = 0x0678;
		public const int VehicleCommonComponent = 0x0680;
		public const int VehicleSeatComponent = 0x0688;
		public const int VehicleEffectComponent = 0x0690;
		public const int VehicleSyncComponent = 0x0698;
		public const int VehicleTempComponent = 0x06A0;
		public const int TslPawnInputBindingComponent = 0x06A8;
		public const int TslHornComponent = 0x06B0;
		public const int AudioComEngine = 0x06B8;
		public const int BuoyancyForceComponent = 0x06C0;
		public const int SinkPoint = 0x06C8;
		public const int SinkBuffType = 0x06D0;
		public const int UnknownData06 = 0x06D8;
		public const int BuffComponent = 0x06E0;
		public const int ComponentsToDestroyOnDedicatedServer = 0x06E8;
		public const int bProcessAutoEject = 0x06F8;
		public const int UnknownData07 = 0x06F9;
		public const int AutoEjectGroundDistance = 0x06FC;
		public const int AutoEjectRoll = 0x0700;
		public const int AutoEjectPitch = 0x0704;
		public const int AutoEject_RiseRate = 0x0708;
		public const int AutoEject_FallRate = 0x070C;
		public const int UnknownData08 = 0x0710;
		public const int bRunStabilizeOnEntry = 0x0714;
		public const int UnknownData09 = 0x0715;
		public const int StabilizeInitialTimer = 0x0718;
		public const int StablizeCurrentTimer = 0x071C;
		public const int SteeringYawBias = 0x0720;
		public const int UnknownData10 = 0x0724;
	}

	public class ATslFloatingVehicle
	{
		public const int UnknownData00 = 0x0410;
		public const int MeshComponent = 0x0420;
		public const int BuoyancyForceComponent = 0x0428;
		public const int MovementComponent = 0x0430;
		public const int VehicleHitComponent = 0x0438;
		public const int VehicleCommonComponent = 0x0440;
		public const int VehicleSeatComponent = 0x0448;
		public const int VehicleEffectComponent = 0x0450;
		public const int VehicleSyncComponent = 0x0458;
		public const int VehicleTempComponent = 0x0460;
		public const int TslHornComponent = 0x0468;
		public const int TslPawnInputBindingComponent = 0x0470;
		public const int AudioComEngine = 0x0478;
		public const int ComponentsToDestroyOnDedicatedServer = 0x0480;
		public const int VehicleEnginePoint = 0x0490;
		public const int VehicleEngineRadius = 0x0498;
		public const int Health = 0x049C;
		public const int HealthMax = 0x04A0;
		public const int Fuel = 0x04A4;
		public const int FuelMax = 0x04A8;
		public const int UnknownData01 = 0x04AC;
	}

	public class UTslWheeledVehicleMovement
	{
		public const int WheelHealthPercentages = 0x0530;
		public const int UnknownData00 = 0x0540;
		public const int CustomTransmission = 0x0548;
		public const int UnknownData01 = 0x0568;
		public const int bAlwaysUseDirectInput = 0x056C;
		public const int UnknownData02 = 0x056D;
		public const int Anim_SteeringInputInterpSpeed = 0x0570;
		public const int Anim_InterpOfInterpSpeedScale = 0x0574;
		public const int Anim_InterpOfInterpSpeedAbs = 0x0578;
		public const int UnknownData03 = 0x057C;
		public const int Anim_SpeedForInputTypeSwitch = 0x0584;
		public const int UnknownData04 = 0x0588;
	}

	public class UTslFloatingVehicleMovement
	{
		public const int MaxAcceleration = 0x0260;
		public const int Acceleration = 0x0264;
		public const int StartAccelerationRate = 0x0268;
		public const int StopAccelerationRate = 0x026C;
		public const int MaxRotationYawAngle = 0x0270;
		public const int RotationYawAngle = 0x0274;
		public const int RotationYawRate = 0x0278;
		public const int UnknownData00 = 0x027C;
		public const int DirectionalAccelerationCurve = 0x0280;
		public const int SlideCompensationCurve = 0x0288;
		public const int BoostModifier = 0x0290;
		public const int bIsBoosting = 0x0294;
		public const int UnknownData01 = 0x0295;
		public const int ForwardInput = 0x0298;
		public const int RotationInput = 0x029C;
		public const int UnknownData02 = 0x02A0;
		public const int HitCharacterDuration = 0x02A4;
		public const int UnknownData03 = 0x02A8;
	}

	public class UTslCharacterMovement
	{
		public const int UnknownData00 = 0x0840;
		public const int MaxProneSpeed = 0x08A0;
		public const int MaxGroggySpeed = 0x08A4;
		public const int JumpedHalfHeight = 0x08A8;
		public const int JumpVelocityLossScale = 0x08AC;
		public const int SpeedToJumpModifier = 0x08B0;
		public const int MinJumpZVelocity = 0x08B4;
		public const int MaxJumpZVelocity = 0x08B8;
		public const int LandingJumpDecreaseModifier = 0x08BC;
		public const int RecoveryWalkSpeedRatePerSec = 0x08C0;
		public const int MinWalkSpeedModifier = 0x08C4;
		public const int WalkSpeedModifierUnit = 0x08C8;
		public const int MinStandingJumpXYSpeed = 0x08CC;
		public const int SpeedInWaterModifier = 0x08D0;
		public const int bUseCPVault = 0x08D4;
		public const int UnknownData01 = 0x08D5;
		public const int HeightFor200 = 0x0928;
		public const int HeightFor160 = 0x092C;
		public const int HeightFor120 = 0x0930;
		public const int HeightFor90 = 0x0934;
		public const int HeightFor60 = 0x0938;
		public const int SizeForNarrow = 0x093C;
		public const int SizeForSlide = 0x0940;
		public const int VelocityForMobile = 0x0944;
		public const int GlobalVaultScale = 0x0948;
		public const int VaultCancelDTScalar = 0x094C;
		public const int MinVelocityForStaticVaultCheck = 0x0950;
		public const int MaxVaultDistanceByVelocityInMap = 0x0954;
		public const int MaxVaultDistanceByVelocityOutMap = 0x095C;
		public const int CurrentVaultingTask = 0x0964;
		public const int UnknownData02 = 0x09A4;
		public const int CurrentVaultingData = 0x09A8;
		public const int V_Timer_CP = 0x09B0;
		public const int AnimMultiplierPreApex = 0x09B4;
		public const int AnimMultiplierPostApex = 0x09B8;
		public const int bIsVaulting_CP = 0x09BC;
		public const int UnknownData03 = 0x09BD;
		public const int CharacterRelLocation = 0x09C0;
		public const int LastVaultLocation = 0x09CC;
		public const int AveragedVelocity = 0x09D8;
		public const int LastVaultTime = 0x09E4;
		public const int VaultCancelAnimSpeed = 0x09E8;
		public const int bWantsToCancelVault = 0x09EC;
		public const int UnknownData04 = 0x09ED;
		public const int MaxSwimAcceleration = 0x0A50;
		public const int MaxZSpeedOutOfWaterModifier = 0x0A54;
		public const int MaxSwimmingRotationRate = 0x0A58;
		public const int SwimmingRotationAcceleration = 0x0A64;
		public const int MaxZSpeedOutOfWaterModifierForStandingSwimming = 0x0A70;
		public const int WaveRidingModifier = 0x0A74;
		public const int WaveRidingSmoothingFactor = 0x0A78;
		public const int WaveRidingModifierUnderWater = 0x0A7C;
		public const int StayingUnderWaterDepthBand = 0x0A80;
		public const int UnknownData05 = 0x0A84;
		public const int MaxUnderwaterSwimSpeed = 0x0A88;
		public const int MaxUnderwaterSwimAcceleration = 0x0A8C;
		public const int BrakingDecelerationUnderwaterSwimming = 0x0A90;
		public const int MaxUnderwaterSwimmingRotationRate = 0x0A94;
		public const int UnderwaterSwimmingRotationAcceleration = 0x0AA0;
		public const int MinimumHighAltitude = 0x0AAC;
		public const int UnknownData06 = 0x0AB0;
		public const int MaxFallLateralSpeedAtHighAltitude = 0x0AB4;
		public const int TerminalVelocityAtHighAltitude = 0x0AB8;
		public const int DecreaseTerminalVelocityAtHighAltitude = 0x0ABC;
		public const int MaxFallAccelerationAtHighAltitude = 0x0AC0;
		public const int FallRotationRateAtHighAltitude = 0x0AC4;
		public const int AirControlAtHighAltitude = 0x0AD0;
		public const int AirControlBoostMultiplierAtHighAltitude = 0x0AD4;
		public const int AirControlBoostVelocityThresholdAtHighAltitude = 0x0AD8;
		public const int UnknownData07 = 0x0ADC;
		public const int FallingDamageType = 0x0AE0;
		public const int EjectDamageCurve = 0x0AE8;
		public const int FallingDamageMinZCut = 0x0AF0;
		public const int FallingDamageVDampingZ = 0x0AF4;
		public const int FallingDamageFactor = 0x0AF8;
		public const int UnknownData08 = 0x0AFC;
		public const int UseBlockedHitDamage = 0x0B08;
		public const int UnknownData09 = 0x0B09;
	}

	public class UTslVehicleWheel
	{
		public const int Health = 0x0108;
		public const int HealthMax = 0x010C;
		public const int TireBoneName = 0x0110;
		public const int bUseTireLink = 0x0118;
		public const int UnknownData00 = 0x0119;
		public const int TireLinkIndex = 0x011C;
		public const int LongSlipSkidThreshold = 0x0120;
		public const int LateralSlipSkidThreshold = 0x0124;
		public const int SpringCompressionLandingThreshold = 0x0128;
		public const int bManualSuspensionSoundControl = 0x012C;
		public const int UnknownData01 = 0x012D;
		public const int WheelEffectOffset = 0x0130;
		public const int UnknownData02 = 0x013C;
		public const int RollEffect = 0x0140;
		public const int SkidAccelEffect = 0x0148;
		public const int SkidEffect = 0x0150;
		public const int PuncturedParticleClass = 0x0158;
		public const int PuncturedSparkParticleClass = 0x0160;
		public const int slipThresholdForPunkSpark = 0x0168;
		public const int UnknownData03 = 0x016C;
		public const int LandingSound = 0x0170;
		public const int bApplyForceOnPuncture = 0x0178;
		public const int UnknownData04 = 0x0179;
		public const int PunctureForce = 0x017C;
		public const int PunctureVelocityScalar = 0x0180;
		public const int UnknownData05 = 0x0184;
		public const int TslParticleRoll = 0x0190;
		public const int TslParticleSkid = 0x0198;
		public const int TslParticleAccelSkid = 0x01A0;
		public const int TslParticlePunctureSpark = 0x01A8;
		public const int UnknownData06 = 0x01B0;
		public const int AudioCom = 0x01B8;
		public const int MinZVelocityForSuspensionSound = 0x01C0;
		public const int UnknownData07 = 0x01C4;
		public const int TotalSpeedKmPerHour = 0x0200;
		public const int Slip = 0x0204;
		public const int UseRoll = 0x0208;
		public const int UseSkid = 0x0209;
		public const int UseAccelSkid = 0x020A;
		public const int bHasLastStatus = 0x020B;
		public const int UnknownData08 = 0x020C;
	}

	public class UTslAnimInstance
	{
		public const int WeaponFire = 0x0378;
		public const int WeaponFireCycle = 0x0388;
		public const int EquipPrimary = 0x0398;
		public const int EquipSecondary = 0x03A8;
		public const int EqupiSidearm = 0x03B8;
		public const int EquipMelee = 0x03C8;
		public const int EquipThrown = 0x03D8;
		public const int UnEquipPrimary = 0x03E8;
		public const int UnEquipSecondary = 0x03F8;
		public const int UnEqupiSidearm = 0x0408;
		public const int UnEquipMelee = 0x0418;
		public const int UnEquipThrown = 0x0428;
		public const int ToggleFireMode = 0x0438;
		public const int ReloadTactical = 0x0448;
		public const int ReloadCharge = 0x0458;
		public const int ReloadByOneStart = 0x0468;
		public const int ReloadByOneStop = 0x0478;
		public const int ReloadByOneSingle = 0x0488;
		public const int EquipThrownGrenade = 0x0498;
		public const int EquipThrownMolotov = 0x04A8;
		public const int EquipThrownOther = 0x04B8;
		public const int ThrowPrepare = 0x04C8;
		public const int ThrowCooking = 0x04D8;
		public const int ThrowStart = 0x04E8;
		public const int ThrowDrop = 0x04F8;
		public const int LandHeavy = 0x0508;
		public const int LandExtreme = 0x0518;
		public const int ReloadCancel = 0x0528;
		public const int CharacterPickup = 0x0538;
		public const int UnarmedAttack = 0x0548;
		public const int PowerupUsed = 0x0558;
		public const int ChangeCharacterAppearance = 0x0568;
		public const int OnCastStart = 0x0578;
		public const int OnCastCancel = 0x0588;
		public const int OnCastFinish = 0x0598;
		public const int UnknownData00 = 0x05A8;
		public const int CharacterReference = 0x05B0;
		public const int CharacterMesh_CP = 0x05B8;
		public const int PreEvalPawnState = 0x05C0;
		public const int UnknownData01 = 0x05C1;
		public const int LocomotionSpeed_CP = 0x05C4;
		public const int LocomotionSpeed2D_CP = 0x05C8;
		public const int bIsMoving_CP = 0x05CC;
		public const int UnknownData02 = 0x05CD;
		public const int LocomotionDirection_CP = 0x05D0;
		public const int LocomotionJumpDirection_CP = 0x05D4;
		public const int LeanYaw_CP = 0x05D8;
		public const int LastAbsoluteDirection_CP = 0x05DC;
		public const int ControlRotation_CP = 0x05E8;
		public const int ControlRotationLastMovement_CP = 0x05F4;
		public const int CharacterRotation_CP = 0x0600;
		public const int Stance_CP = 0x060C;
		public const int bIsSprintingFast_CP = 0x060D;
		public const int bIsSprinting_CP = 0x060E;
		public const int UnknownData03 = 0x060F;
		public const int WeaponGripType_CP = 0x0610;
		public const int SprintAlpha_CP = 0x0614;
		public const int SprintLocoAlpha_CP = 0x0618;
		public const int SprintValue_CP = 0x061C;
		public const int bLocalQuickThrowHigh_CP = 0x0620;
		public const int UnknownData04 = 0x0621;
		public const int LocalThrowModeSwitchAlpha_CP = 0x0624;
		public const int bIsJumping_CP = 0x0628;
		public const int bJumpForward_CP = 0x0629;
		public const int bIsSwimming_CP = 0x062A;
		public const int bIsUnderWater_CP = 0x062B;
		public const int bIsDBNO_CP = 0x062C;
		public const int DBNOEntryStance = 0x062D;
		public const int bIsReviving_CP = 0x062E;
		public const int bIsUpperbody_CP = 0x062F;
		public const int bIsTransitioning_CP = 0x0630;
		public const int UnknownData05 = 0x0631;
		public const int PlayerID_CP = 0x0634;
		public const int AirCraftIDAnim_CP = 0x0638;
		public const int bIsEquippingPistol_CP = 0x063C;
		public const int UnknownData06 = 0x063D;
		public const int PistolEquipMontageRefCP = 0x0640;
		public const int bIsFlying_CP = 0x0648;
		public const int bIsLocalPlayer = 0x0649;
		public const int UnknownData07 = 0x064A;
		public const int LocalPlayerAlpha = 0x064C;
		public const int bIsPunching_CP = 0x0650;
		public const int UnknownData08 = 0x0651;
		public const int PunchingAlpha_CP = 0x0654;
		public const int Weapon_CP = 0x0658;
		public const int bIsArmedWithGun_CP = 0x0659;
		public const int bIsArmedWithThrown_CP = 0x065A;
		public const int bIsPreparingThrow_CP = 0x065B;
		public const int ThrowableAdditionalAimYaw_CP = 0x065C;
		public const int CurrentRecoilMontage_CP = 0x0660;
		public const int GripBlendSpace_CP = 0x0668;
		public const int GripBlendSpaceLH_CP = 0x0670;
		public const int LHGripIndex_CP = 0x0678;
		public const int bIsReloading_CP = 0x067C;
		public const int UnknownData09 = 0x067D;
		public const int HandWeaponOffset_CP = 0x0680;
		public const int UnknownData10 = 0x068C;
		public const int WeaponInertia_CP = 0x0690;
		public const int ReloadAlpha_CP = 0x06C0;
		public const int HandWeaponOffsetAlpha_CP = 0x06C4;
		public const int FinalRecoilAlpha_CP = 0x06C8;
		public const int UnknownData11 = 0x06CC;
		public const int WeaponLocomotionBlendspace_CP = 0x06D0;
		public const int WeaponLocomotionBlendspace_Pistol = 0x06D8;
		public const int WeaponLocomotionBlendspace_SMG = 0x06E0;
		public const int WeaponLocomotionBlendspace_Rifle = 0x06E8;
		public const int WeaponLocomotionBlendspace_Sniper = 0x06F0;
		public const int WeaponLocomotionBlendspace_Pistol_FPP = 0x06F8;
		public const int WeaponLocomotionBlendspace_SMG_FPP = 0x0700;
		public const int WeaponLocomotionBlendspace_Rifle_FPP = 0x0708;
		public const int WeaponLocomotionBlendspace_Sniper_FPP = 0x0710;
		public const int WeaponInertiaX_Scalar_CP = 0x0718;
		public const int WeaponInertiaY_Scalar_CP = 0x071C;
		public const int WeaponInertiaX_Clamp_CP = 0x0720;
		public const int WeaponInertiaY_Clamp_CP = 0x0724;
		public const int WeaponInertia_InerpSpeed_CP = 0x0728;
		public const int WeaponInertiaX_Scalar_ADS_CP = 0x072C;
		public const int WeaponInertiaY_Scalar_ADS_CP = 0x0730;
		public const int WeaponInertiaX_Clamp_ADS_CP = 0x0734;
		public const int WeaponInertiaY_Clamp_ADS_CP = 0x0738;
		public const int WeaponInertia_InerpSpeed_ADS_CP = 0x073C;
		public const int WeaponInertia_InerpSpeed_YawScalar_CP = 0x0740;
		public const int WeaponInertia_YawToRollScalar_CP = 0x0744;
		public const int WeaponInertia_YawToRollScalar_ADS_CP = 0x0748;
		public const int WeaponInertiaRoll_Clamp_ADS_CP = 0x074C;
		public const int WeaponInertiaRoll_Clamp_CP = 0x0750;
		public const int WeaponInertia_Yaw_CP = 0x0754;
		public const int WeaponInertia_Pitch_CP = 0x0758;
		public const int WeaponInertia_Roll_CP = 0x075C;
		public const int SprintWeaponLoweringAlpha_CP = 0x0760;
		public const int RecoilRollValue_CP = 0x0764;
		public const int RecoilTimer_CP = 0x0768;
		public const int RecoilRollRand_CP = 0x076C;
		public const int RecoilTimerScale_CP = 0x0770;
		public const int UnknownData12 = 0x0774;
		public const int RecoilRollCurve_CP = 0x0778;
		public const int WeaponStabilityAlpha_CP = 0x0780;
		public const int WeaponStabilityRefSpeed_CP = 0x0784;
		public const int WeaponStabilityRefMapIn_CP = 0x0788;
		public const int WeaponStabilityRefMapOut_CP = 0x0790;
		public const int WeaponStabilityInterpSpeed_CP = 0x0798;
		public const int bIsAiming_CP = 0x079C;
		public const int bIsScoping_CP = 0x079D;
		public const int UnknownData13 = 0x079E;
		public const int WeaponAimState_CP = 0x07A0;
		public const int SprintAlphaModifier_CP = 0x07A4;
		public const int bIsAimingBackward_CP = 0x07A8;
		public const int UnknownData14 = 0x07A9;
		public const int Yaw_CP = 0x07AC;
		public const int RotationYaw_CP = 0x07B0;
		public const int Pitch_CP = 0x07B4;
		public const int YawNormalized_CP = 0x07B8;
		public const int DesiredPitch_CP = 0x07BC;
		public const int AimDirectionCardinal_CP = 0x07C0;
		public const int UnknownData15 = 0x07C1;
		public const int AORot_CP = 0x07C4;
		public const int AORotBackwards_CP = 0x07D0;
		public const int SwimmingPitch_CP = 0x07DC;
		public const int ForceAddAimOffset_CP = 0x07E0;
		public const int WeaponCollisionAlpha_CP = 0x07E4;
		public const int bWeaponObstructedHigh_CP = 0x07E8;
		public const int bIsFalling_CP = 0x07E9;
		public const int bWasFalling_CP = 0x07EA;
		public const int UnknownData16 = 0x07EB;
		public const int FallingAlpha_CP = 0x07EC;
		public const int FallingMap2D = 0x07F0;
		public const int FallingMapZ = 0x07F8;
		public const int bForceFall_CP = 0x0800;
		public const int UnknownData17 = 0x0801;
		public const int MontageFallingRifle_CP = 0x0808;
		public const int MontageFallingUnarmed_CP = 0x0810;
		public const int LandingAlpha_CP = 0x0818;
		public const int bLocalForceProne_CP = 0x081C;
		public const int UnknownData18 = 0x081D;
		public const int JumpHeight_CP = 0x0820;
		public const int FallHeight_CP = 0x0824;
		public const int JumpStartLocation_CP = 0x0828;
		public const int LandPredictionVector_CP = 0x0834;
		public const int LeanLeftAlpha_CP = 0x0840;
		public const int LeanRightAlpha_CP = 0x0844;
		public const int LeanTwoSideAlpha_CP = 0x0848;
		public const int LeanLeftApplyTranslation_CP = 0x084C;
		public const int LeanInterpSpeed_CP = 0x0850;
		public const int LeanInterpSpeedCollisionClamp_CP = 0x0854;
		public const int bUseLinearLeanInterp = 0x0858;
		public const int bIsFreefalling_CP = 0x0859;
		public const int bIsParachuting_CP = 0x085A;
		public const int UnknownData19 = 0x085B;
		public const int FreefallX_CP = 0x085C;
		public const int FreefallY_CP = 0x0860;
		public const int FreeFallAlpha_CP = 0x0864;
		public const int bIsParachuteLanding_CP = 0x0868;
		public const int bIsParachuteMoving_CP = 0x0869;
		public const int UnknownData20 = 0x086A;
		public const int Freefall_Yaw_CP = 0x086C;
		public const int Freefall_Pitch_CP = 0x0870;
		public const int bIsFreelooking_CP = 0x0874;
		public const int bIsMeleeAttacking_CP = 0x0875;
		public const int bLocalForceRotationHipLeft_CP = 0x0876;
		public const int bLocalForceRotationHipRight_CP = 0x0877;
		public const int bLocalForceRotationAimed_CP = 0x0878;
		public const int UnknownData21 = 0x0879;
		public const int RotationPlayrateAimed_CP = 0x087C;
		public const int RotationPlayrateAimedAdditiveSpine_CP = 0x0880;
		public const int LastRotation_CP = 0x0884;
		public const int Freelook_Body_CP = 0x0890;
		public const int Freelook_Delta_CP = 0x089C;
		public const int IdleIndex_CP = 0x08A8;
		public const int LastIdleIndex_CP = 0x08AC;
		public const int IdleTimer_CP = 0x08B0;
		public const int IdleTriggerRandom = 0x08B4;
		public const int IdleTriggerTimeMin_CP = 0x08B8;
		public const int IdleTriggerTimeVariation_CP = 0x08BC;
		public const int SlotPrimary_CP = 0x08C0;
		public const int SlotSecondary_CP = 0x08F0;
		public const int SlotMelee_CP = 0x0920;
		public const int SlotThrown_CP = 0x0950;
		public const int SlotPrimary_Offset_CP = 0x0980;
		public const int SlotSecondary_Offset_CP = 0x098C;
		public const int SlotPrimary_Location_CP = 0x0998;
		public const int SlotSecondary_Location_CP = 0x09A4;
		public const int SlotMelee_Location_CP = 0x09B0;
		public const int SlotThrown_Location_CP = 0x09BC;
		public const int SlotPrimary_Rotation_CP = 0x09C8;
		public const int SlotSecondary_Rotation_CP = 0x09D4;
		public const int SlotMelee_Rotation_CP = 0x09E0;
		public const int SlotThrown_Rotation_CP = 0x09EC;
		public const int AnimDynamicsStandAlpha_CP = 0x09F8;
		public const int AnimDynamicsStandSprintAlpha_CP = 0x09FC;
		public const int AnimDynamicsCrouchAlpha_CP = 0x0A00;
		public const int AnimDynamicsProneAlpha_CP = 0x0A04;
		public const int EFCoat_CP = 0x0A08;
		public const int bLocalFPP_CP = 0x0A14;
		public const int UnknownData22 = 0x0A15;
		public const int LocalFPPAlpha_CP = 0x0A18;
		public const int LocalFPPAlphaVehicleAimAO_CP = 0x0A1C;
		public const int bIsInAircraft_CP = 0x0A20;
		public const int bIsDriver_CP = 0x0A21;
		public const int bIsSitting_CP = 0x0A22;
		public const int bIsInVehicle_CP = 0x0A23;
		public const int LocalSteerInput_CP = 0x0A24;
		public const int LocalSteerInputMoto_CP = 0x0A28;
		public const int LocalStopMoto_CP = 0x0A2C;
		public const int LocalThrottleInput_CP = 0x0A30;
		public const int GasThighRot_CP = 0x0A34;
		public const int GasAnkleRot_CP = 0x0A40;
		public const int UnknownData23 = 0x0A4C;
		public const int GasKneeTransformX_CP = 0x0A50;
		public const int LocalBrakeInput_CP = 0x0A80;
		public const int UnknownData24 = 0x0A84;
		public const int BrakeKneeTransform_CP = 0x0A90;
		public const int BrakeAnkleRot_CP = 0x0AC0;
		public const int BackwardAOAlpha_CP = 0x0ACC;
		public const int AimBlendAlpha_CP = 0x0AD0;
		public const int bHasContact_CP = 0x0AD4;
		public const int UnknownData25 = 0x0AD5;
		public const int GroundContactMoto_CP = 0x0AD8;
		public const int AirControlPitchInput_CP = 0x0ADC;
		public const int DriverIK_CP = 0x0AE0;
		public const int PassengerIKAlpha_CP = 0x0B10;
		public const int DriverSpineLocWS_CP = 0x0B14;
		public const int VehicleSeatType_CP = 0x0B20;
		public const int bMotoHasDriver_CP = 0x0B21;
		public const int bVaultCanceled = 0x0B22;
		public const int bIsVaulting_CP = 0x0B23;
		public const int AnimHairAlpha = 0x0B24;
		public const int VaultTimer_CP = 0x0B28;
		public const int VaultTimerLast_CP = 0x0B2C;
		public const int LocalVaultType_CP = 0x0B30;
		public const int UnknownData26 = 0x0B31;
		public const int VaultAnimSequence_CP = 0x0B38;
		public const int VaultAnimLength_CP = 0x0B40;
		public const int UnknownData27 = 0x0B44;
		public const int VaultCurve_CP = 0x0B48;
		public const int VaultBlendInTime_CP = 0x0B50;
		public const int VaultBlendOutTime_CP = 0x0B54;
		public const int bEndVaultToFall_CP = 0x0B58;
		public const int UnknownData28 = 0x0B59;
		public const int VaultBlendOutProgressTime_CP = 0x0B5C;
		public const int VaultBlendOutExactTime_CP = 0x0B60;
		public const int VaultLastActionTimer_CP = 0x0B64;
		public const int VaultAnimTime_CP = 0x0B68;
		public const int VaultBlendOutTimeBuffer = 0x0B6C;
		public const int CurrentCastAnim_CP = 0x0B70;
		public const int bIsActiveRagdoll_CP = 0x0B71;
		public const int UnknownData29 = 0x0B72;
		public const int WeaponIKLH_CP = 0x0B74;
		public const int WeaponIKRH_CP = 0x0B78;
		public const int MontageIKLH_CP = 0x0B7C;
		public const int MontageIKRH_CP = 0x0B80;
		public const int IgnoreWeaponTransform_CP = 0x0B84;
		public const int PickupIKAlpha_CP = 0x0B88;
		public const int TargetIKRH_CP = 0x0B8C;
		public const int TargetIKLH_CP = 0x0B90;
		public const int ForceLegsFromAnim_CP = 0x0B94;
		public const int LastGunCache_CP = 0x0B98;
		public const int CachedWheeledVehicle_CP = 0x0BA0;
		public const int CachedFloatingVehicle_CP = 0x0BA8;
		public const int PassengerAimBS_CP = 0x0BB0;
		public const int PassengerTransitionOut_CP = 0x0BB8;
		public const int PassengerTransitionIn_CP = 0x0BC0;
		public const int PassengerIdle_Rifle_CP = 0x0BC8;
		public const int PassengerIdle_Unarmed_CP = 0x0BD0;
		public const int PassengerIdle_Grenade_CP = 0x0BD8;
		public const int PassengerIdle_Melee_CP = 0x0BE0;
		public const int CurveAimState_CP = 0x0BE8;
		public const int UnknownData30 = 0x0BF0;
		public const int bIsLOD1 = 0x0BF8;
		public const int bIsLOD2 = 0x0BF9;
		public const int bIsWearingCoat = 0x0BFA;
		public const int UnknownData31 = 0x0BFB;
		public const int AnimatedHairsAlpha = 0x0C04;
		public const int bIsParentalControl = 0x0C08;
		public const int UnknownData32 = 0x0C09;
		public const int MontageMeleeAttack1 = 0x0C10;
		public const int MontageMeleeAttack2 = 0x0C18;
		public const int MontageMeleeAttack3 = 0x0C20;
		public const int MontagePunchingAttack1 = 0x0C28;
		public const int MontagePunchingAttack2 = 0x0C30;
		public const int MontagePunchingAttack3 = 0x0C38;
		public const int FPPSprintAnimScalar = 0x0C40;
		public const int FPP_PrimaryAndSecondaryItemOffset = 0x0C44;
		public const int PunchingAlphaOneTarget_CP = 0x0C50;
		public const int PunchingAlphaInterpSpeed = 0x0C54;
		public const int SprintWeaponLoweringScalar_CP = 0x0C58;
		public const int ThrowStateSwitchInterpSpeed = 0x0C5C;
		public const int VaultingEvalTimeout = 0x0C60;
		public const int UnknownData33 = 0x0C64;
		public const int UnarmedAnimDB_CP = 0x0C68;
		public const int RifleAnimDB_CP = 0x0C70;
		public const int MeleeAnimDB_CP = 0x0C78;
		public const int GrenadeAnimDB_CP = 0x0C80;
		public const int UnknownData34 = 0x0C88;
		public const int DefaultSlotPrimary_Male_CP = 0x0C90;
		public const int DefaultSlotSecondary_Male_CP = 0x0CC0;
		public const int DefaultSlotMelee_Male_CP = 0x0CF0;
		public const int DefaultSlotThrown_Male_CP = 0x0D20;
		public const int DefaultSlotPrimary_Female_CP = 0x0D50;
		public const int DefaultSlotSecondary_Female_CP = 0x0D80;
		public const int DefaultSlotThrown_Female_CP = 0x0DB0;
		public const int DefaultSlotMelee_Female_CP = 0x0DE0;
		public const int SprintLocoTimeMultiplier = 0x0E10;
		public const int SprintLocoTimeMultiplier_FPP = 0x0E14;
		public const int SprintLocoTimeAlphaScalar = 0x0E18;
		public const int SprintLocoTimeAlphaScalar_FPP = 0x0E1C;
	}

	public class UTslDamageType
	{
		public const int DamageTypeCategory = 0x0040;
		public const int UnknownData00 = 0x0041;
		public const int KillIcon = 0x0048;
		public const int HitForceFeedback = 0x0060;
		public const int KilledForceFeedback = 0x0068;
		public const int bFallDamage = 0x0070;
		public const int UnknownData01 = 0x0071;
		public const int DamageRatioInfos = 0x0078;
		public const int HitReaction = 0x0088;
		public const int UnknownData02 = 0x0089;
	}

	public class ATslHUD
	{
		public const int OnPossessPawnChange = 0x0548;
		public const int OnDisplaySystemMessage = 0x0558;
		public const int OnDisplayKilledMessage = 0x0568;
		public const int OnKillCountChanged = 0x0578;
		public const int OnNotifyHit = 0x0588;
		public const int OnTeamPlayerJoin = 0x0598;
		public const int OnTeamPlayerRemove = 0x05A8;
		public const int OnNotifyStartBuff = 0x05B8;
		public const int OnNotifyHealAmount = 0x05C8;
		public const int OnNotifyRestrictingPlayArea = 0x05D8;
		public const int OnNotifyNextGasIn = 0x05E8;
		public const int OnNotifyDisplayMessage = 0x05F8;
		public const int OnNotifyWeaponChange = 0x0608;
		public const int OnNotifyWeaponUnarm = 0x0618;
		public const int OnNotifyHeal = 0x0628;
		public const int OnNotifyDropSlotOnOtherContainer = 0x0638;
		public const int OnNotifyBlockingWidgetOpened = 0x0648;
		public const int OnNotifyHealItemSelector_Gamepad = 0x0658;
		public const int BluezoneState = 0x0668;
		public const int bGpsReset = 0x066C;
		public const int bBluezoneReset = 0x066D;
		public const int bPlayzoneReset = 0x066E;
		public const int UnknownData00 = 0x066F;
		public const int GpsResetTimeCheck = 0x0670;
		public const int bUseHighlight = 0x0674;
		public const int UnknownData01 = 0x0675;
		public const int TimePlaceBg = 0x06A8;
		public const int PrimaryWeapBg = 0x06C0;
		public const int SecondaryWeapBg = 0x06D8;
		public const int Crosshair = 0x06F0;
		public const int UnknownData02 = 0x0768;
		public const int HitNotifyTexture = 0x07E0;
		public const int HUDMainTexture = 0x07E8;
		public const int HUDAssets02Texture = 0x07F0;
		public const int LowHealthOverlayTexture = 0x07F8;
		public const int BigFont = 0x0800;
		public const int NormalFont = 0x0808;
		public const int UnknownData03 = 0x0810;
		public const int SceneCaptureWorld = 0x0870;
		public const int UnknownData04 = 0x0878;
		public const int NextPlayzonePosition = 0x0888;
		public const int NextPlayzoneRadius = 0x0894;
		public const int CurrentPlayzonePosition = 0x0898;
		public const int CurrentPlayzoneRadius = 0x08A4;
		public const int UnknownData05 = 0x08A8;
		public const int SceneCapturePackageName = 0x08F8;
		public const int HighlightSession = 0x0908;
		public const int UnknownData06 = 0x0910;
	}

	public class UTslSettings
	{
		public const int DialogUMGWidgetClass = 0x0028;
		public const int bSupportKillcamEnable = 0x0030;
		public const int UnknownData00 = 0x0031;
		public const int MaxReplaysForNullStreamer = 0x0034;
		public const int RepDistance_Item = 0x0038;
		public const int RepDistance_Character = 0x003C;
		public const int RepDistance_Weapon = 0x0040;
		public const int RepDistance_Vehicle = 0x0044;
		public const int RepDistance_Parachute = 0x0048;
		public const int RepDistance_Door = 0x004C;
		public const int RepDistance_Window = 0x0050;
		public const int RepFrequency_Character = 0x0054;
		public const int RepFrequency_WheeledVehicle = 0x0058;
		public const int RepFrequency_FloatingVehicle = 0x005C;
		public const int RepFrequency_Parachute = 0x0060;
		public const int RepFrequency_Aircraft = 0x0064;
		public const int RepFrequency_CarePackage = 0x0068;
		public const int RepVehicle_SpawnDistance = 0x006C;
		public const int RepVehicle_UnspawnDistance = 0x0070;
		public const int RepVehicle_PhysicErrorCorrection = 0x0074;
		public const int CharacterCorrection_MaxSpeed = 0x0090;
		public const int CharacterCorrection_MaxSpeedPositionError = 0x0094;
		public const int CharacterCorrection_ZeroSpeedPositionError = 0x0098;
		public const int bBattlEyeEnabled = 0x009C;
		public const int bBattlEyeEnabledInPIE = 0x009D;
		public const int UnknownData01 = 0x009E;
		public const int BattlEyeReliablePacketIntervalOnClient = 0x00A0;
		public const int BattlEyeReliablePacketIntervalOnServer = 0x00A4;
		public const int bChineseLicensing = 0x00A8;
		public const int bKoreanRating = 0x00A9;
		public const int UnknownData02 = 0x00AA;
		public const int GameStateLogInterval = 0x00AC;
		public const int ServerStatLogInterval = 0x00B0;
		public const int CharacterPositionLogInterval = 0x00B4;
		public const int DestructibleComponentMaxDrawDistance = 0x00B8;
		public const int UnknownData03 = 0x00BC;
		public const int CharacterClassToPlay = 0x00C0;
		public const int BoneMapping = 0x00C8;
		public const int TestVehicleClasses = 0x00D8;
		public const int TestFloatingVehicleClasses = 0x00E8;
		public const int ChineseLicensingDefaultCustomizeData = 0x00F8;
		public const int StoppedWheeledVehicleSpeedThreshold = 0x0108;
		public const int StoppedFloatingVehicleSpeedThreshold = 0x010C;
		public const int LastDriverDuration = 0x0110;
		public const int InteractableDistanceToleranceOnDedicatedServer = 0x0114;
		public const int InteractableDistance_ItemDefault = 0x0118;
		public const int InteractableSpeed_ItemDefault = 0x011C;
		public const int InteractionCollisionForFPS = 0x0120;
		public const int InteractionCollisionForTPS = 0x0134;
		public const int bPreventFinishMatchInPIE = 0x0148;
		public const int bEnableInitialItemDonator = 0x0149;
		public const int UnknownData04 = 0x014A;
		public const int InventoryMaxSpaceDefault = 0x014C;
		public const int ErrorIconTexture = 0x0150;
		public const int LoadingIconTexture = 0x0158;
		public const int AssetsForPackageIntegrity = 0x0160;
		public const int UICrosshairDistance = 0x0170;
		public const int UICrosshairInterpSpeed = 0x0174;
		public const int UICrosshairDisableDistance = 0x0178;
		public const int UnknownData05 = 0x017C;
		public const int GameTimeMultiplier = 0x0188;
		public const int AimOffsetRayCast = 0x018C;
		public const int UnknownData06 = 0x018D;
		public const int MeleeWeaponPitchMin = 0x0190;
		public const int MeleeWeaponPitchMax = 0x0194;
		public const int EnableThrowLagCompensation = 0x0198;
		public const int FullRecoilRecovery = 0x0199;
		public const int UnknownData07 = 0x019A;
		public const int LevelLoadingBoostParameters = 0x019C;
		public const int UnknownData08 = 0x01AC;
		public const int NearClippingValues = 0x01B0;
		public const int CustomizableCategoryData = 0x01C0;
		public const int CustomizableActionNames = 0x01D0;
		public const int CustomizableAxisNames = 0x01E0;
		public const int CustomizableMouseSensitiveNames = 0x01F0;
		public const int CustomizableGamePadSensitiveNames = 0x0200;
		public const int SupportedQualityLevels = 0x0210;
		public const int SupportedScreenResolutions = 0x0220;
		public const int MouseSensitivityCurve = 0x0230;
		public const int GammaCurve = 0x0240;
		public const int CultureNames = 0x0250;
		public const int ColorBlindTypes = 0x0260;
		public const int CrosshairColors = 0x0270;
		public const int KeyInputModeNames = 0x0280;
		public const int MiniMapTypeList = 0x0290;
		public const int MinimumScreenResolutionRatio = 0x02A0;
		public const int MinimumScreenResolution = 0x02A4;
		public const int UnknownData09 = 0x02AC;
		public const int OverrideMarkerColorAndIcons = 0x02B0;
		public const int PunchClientHitLeeway_Attacker = 0x02C0;
		public const int PunchClientHitLeeway_Victim = 0x02C4;
		public const int ClientSideHitLeeway = 0x02C8;
		public const int LogClientSideHitLeeway = 0x02CC;
		public const int ClientSideOriginDistanceLeeway = 0x02D0;
		public const int TravelDistanceLeeway = 0x02D4;
		public const int AllowedHitLag = 0x02D8;
		public const int LogMinHitLag = 0x02DC;
		public const int HackDetectionSpeed = 0x02E0;
		public const int UnknownData10 = 0x02E4;
		public const int OverrideScalabilities = 0x02E8;
		public const int FakeDoorBlockMaxY = 0x02F8;
		public const int UnknownData11 = 0x02FC;
		public const int ReportCauses = 0x0300;
		public const int SubjectToReport = 0x0310;
		public const int FreelookRecoveryInterpSpeed = 0x0320;
		public const int UnknownData12 = 0x0324;
		public const int GamepadSensitiveMultiplier = 0x0328;
		public const int GamePadInnerDeadZone = 0x0378;
		public const int GamePadOutDeadZoneAcceleration = 0x037C;
		public const int GamePadOutMaxAxisValue = 0x0380;
		public const int GamePadAccelerationStandardFps = 0x0384;
		public const int AimAssistDecisionRadius = 0x0388;
		public const int bApplyInputValue = 0x038C;
		public const int bIgnorePadSensitive = 0x038D;
		public const int UnknownData13 = 0x038E;
		public const int InsensitiveZone = 0x0390;
		public const int UnknownData14 = 0x0394;
		public const int AimCameraAssists = 0x0398;
		public const int ADSCameraAssists = 0x03A8;
		public const int Scope2XCameraAssists = 0x03B8;
		public const int Scope4XCameraAssists = 0x03C8;
		public const int Scope8XCameraAssists = 0x03D8;
		public const int Scope15XCameraAssists = 0x03E8;
		public const int bIsESports = 0x03F8;
		public const int UnknownData15 = 0x03F9;
		public const int LoadedMouseSensitivityCurve = 0x0450;
		public const int LoadedGammaCurve = 0x0458;
		public const int CharacterStudioRenderTarget = 0x0460;
		public const int AnimatableHairNames = 0x0468;
		public const int NotifyDistanceLimitMap = 0x0478;
	}

	public class UTslGameInstance
	{
		public const int PersistentUClassPaths = 0x00F0;
		public const int PersistentUClasses = 0x0100;
		public const int WelcomeScreenMap = 0x0110;
		public const int bUseLobbyWidget = 0x0120;
		public const int UnknownData00 = 0x0121;
		public const int LobbyWidgetZOrder = 0x0124;
		public const int LobbyLink = 0x0128;
		public const int VivoxManager = 0x0130;
		public const int ReporterManager = 0x0138;
		public const int StartParamter = 0x0140;
		public const int UnknownData01 = 0x01C0;
		public const int LobbyWidgetClass = 0x0288;
		public const int UnknownData02 = 0x0290;
		public const int LobbyWidget = 0x03D0;
		public const int UnknownData03 = 0x03D8;
		public const int ReplayKillEventItems = 0x0480;
		public const int OnEnumerateReplayKillEventsDone = 0x0490;
		public const int UnknownData04 = 0x04A0;
		public const int ReplayGroggyEventItems = 0x0540;
		public const int OnEnumerateReplayGroggyEventsDone = 0x0550;
		public const int UnknownData05 = 0x0560;
		public const int ReplayItemList = 0x0570;
		public const int UnknownData06 = 0x0580;
		public const int OnGetReplayListDone = 0x05B8;
		public const int OnGotoTimelineDone = 0x05C8;
		public const int OnRecordStarted = 0x05D8;
		public const int OnDownloadZippedReplayProgressDelegate = 0x05E8;
		public const int OnDownloadZippedReplayCompleteDelegate = 0x05F8;
		public const int UnknownData07 = 0x0608;
		public const int MaxReplaysForNullStreamer = 0x0630;
		public const int NumReplaysForNullStreamer = 0x0634;
		public const int NumReplaysToKeepForNullStreamer = 0x0638;
		public const int UnknownData08 = 0x063C;
		public const int OnKeepAndDeleteOldestReplaysDoneDelegate = 0x0640;
		public const int UnknownData09 = 0x0650;
		public const int GameEventObserver = 0x0658;
		public const int UnknownData10 = 0x0660;
		public const int ReplaySummaryForPlayback = 0x0678;
		public const int OnGetReplaySummaryDone = 0x06F8;
		public const int bIsStartedFromReplayListMap = 0x0708;
		public const int UnknownData11 = 0x0709;
		public const int CachedDemoPlayerState = 0x0710;
		public const int UnknownData12 = 0x0718;
	}

	public class ALobbyHUD
	{
		public const int UnknownData00 = 0x09B0;
		public const int CameraTransitionCurve = 0x09B8;
		public const int CameraTransitionElapsedTime = 0x09C0;
		public const int bIsCameraTransitionPlaying = 0x09C4;
		public const int LastCameraState = 0x09C5;
		public const int FromCameraState = 0x09C6;
		public const int ToCameraState = 0x09C7;
		public const int MainMenuStreamingLevelName = 0x0A18;
		public const int CustomizationStreamingLevelName = 0x0A20;
		public const int FadeInOutCurve = 0x0A28;
		public const int LobbyPPE = 0x0A30;
		public const int FadeInOutEffectElapsedTime = 0x0A38;
		public const int bIsFadeInOutEffectPlaying = 0x0A3C;
		public const int UnknownData01 = 0x0A3D;
		public const int TimerHandle_FadeInOut = 0x0A40;
		public const int MainMenuPPE = 0x0A48;
		public const int BlurChangingState = 0x0A50;
		public const int bInitCameraTransition = 0x0A51;
		public const int UnknownData02 = 0x0A52;
		public const int OnCreateCharacter = 0x0A58;
		public const int OnDestroyCharacter = 0x0A68;
		public const int StartURL = 0x0A78;
		public const int CommonBinders = 0x0A88;
		public const int AkSound = 0x0A98;
		public const int MainCamera = 0x0AA0;
		public const int UnknownData03 = 0x0AA8;
		public const int LobbyCharacterMaleClass = 0x0AC8;
		public const int LobbyCharacterFemaleClass = 0x0AD0;
		public const int UnknownData04 = 0x0AD8;
		public const int ViewTargetTransitionParams = 0x0B28;
		public const int UnknownData05 = 0x0B38;
	}

	public class ATslWelcomeBaseHUD
	{
		public const int UnknownData00 = 0x0548;
		public const int OnStateChanged = 0x0558;
		public const int UnknownData01 = 0x0568;
	}

	public class ATslEntryPlayerController
	{
		public const int VivoxComponent = 0x06F0;
	}

	public class APerfBotPlayerController
	{
		public const int AmmoClips = 0x0A18;
		public const int UnknownData00 = 0x0A1C;
		public const int WeaponType = 0x0A20;
		public const int UnknownData01 = 0x0A28;
	}

	public class ATslDemoSpectator
	{
		public const int UnknownData00 = 0x0A18;
	}

	public class ATslBotAIController
	{
		public const int UnknownData00 = 0x04A8;
	}

	public class ACharacterBreathBuff
	{
		public const int BreathPerTick = 0x0410;
		public const int UnknownData00 = 0x0414;
	}

	public class UTslCameraComponent
	{
		public const int UnknownData00 = 0x0990;
	}

	public class ATslCharacterProxy
	{
		public const int UnknownData00 = 0x07E0;
		public const int ArmedWeapons = 0x07E8;
		public const int WeaponAnimInfoComponent = 0x07F8;
		public const int WeaponUpdateIntervalSeconds = 0x0800;
		public const int UnknownData01 = 0x0804;
	}

	public class UTslCharacterSpringArmComponent
	{
		public const int UnknownData00 = 0x0470;
		public const int DefaultSocketOffset = 0x0474;
		public const int IndoorSocketOffset = 0x0480;
		public const int LeanLeftDefaultSocketOffsetAddition = 0x048C;
		public const int LeanRightDefaultSocketOffsetAddition = 0x0498;
		public const int LeftShoulderAimingSocketOffset = 0x04A4;
		public const int RightShoulderAimingSocketOffset = 0x04B0;
		public const int LeanLeftAimedSocketOffsetAddition = 0x04BC;
		public const int LeanRightAimedSocketOffsetAddition = 0x04C8;
		public const int SprintSocketOffsetAddition = 0x04D4;
		public const int CrouchSocketOffsetZAddition = 0x04E0;
		public const int CrouchSocketOffsetMovementZAddition = 0x04E4;
		public const int ProneScoketOffsetZAddition = 0x04E8;
		public const int SocketOffsetInterpSpeed = 0x04EC;
		public const int DefaultTargetOffset = 0x04F0;
		public const int IndoorTargetOffset = 0x04FC;
		public const int AimingTargetOffset = 0x0508;
		public const int TargetOffsetInterpSpeed = 0x0514;
		public const int TargetOffsetInterpSpeed_Vaulting = 0x0518;
		public const int DefaultSpringArmLength = 0x051C;
		public const int IndoorSpringArmLength = 0x0520;
		public const int AimingSpringArmLength = 0x0524;
		public const int BlockingCompressOffset = 0x0528;
		public const int BlockingCompressCrouchOffset = 0x052C;
		public const int SpringArmLengthInterpSpeed = 0x0530;
		public const int AimingSpringArmLengthInterpSpeed = 0x0534;
		public const int VaultingSpringArmLengthInterpSpeed = 0x0538;
		public const int UnknownData01 = 0x053C;
		public const int SpringArmRestoreInterpSpeed = 0x0540;
		public const int UnknownData02 = 0x0544;
	}

	public class UTslCharacterValidateLocationComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int InvalidUndergroundCheckInterval = 0x01EC;
		public const int UnknownData01 = 0x01F0;
		public const int InvalidUndergroundCheckLength = 0x01F4;
		public const int MaxAdjustRange = 0x01F8;
		public const int MaxAdjustCount = 0x01FC;
	}

	public class UTslChatWidgetStyle
	{
		public const int ChatStyle = 0x0030;
	}

	public class UTslCheatManager
	{
		public const int UnknownData00 = 0x0078;
	}

	public class UTslCoherentWidget
	{
		public const int WidgetBinderClass = 0x0490;
		public const int WidgetBinder = 0x0498;
	}

	public class UTslConsole
	{
		public const int UnknownData00 = 0x0130;
	}

	public class UTslConsoleSetting
	{
		public const int AutoCompleteItemPaths = 0x0070;
		public const int AutoCompleteItemKinds = 0x0080;
		public const int AutoCompleteVehiclePaths = 0x0090;
		public const int AutoCompleteMaleBody = 0x00A0;
		public const int AutoCompleteMaleHair = 0x00B0;
		public const int AutoCompleteMaleFace = 0x00C0;
		public const int AutoCompleteFemaleBody = 0x00D0;
		public const int AutoCompleteFemaleHair = 0x00E0;
		public const int AutoCompleteFemaleFace = 0x00F0;
	}

	public class ATslDamageField
	{
		public const int UnknownData00 = 0x03B0;
		public const int DamageRadius = 0x03B4;
		public const int DamageFieldFX = 0x03B8;
		public const int Damage = 0x03C0;
		public const int DamageInterval = 0x03C4;
		public const int DamageType = 0x03C8;
		public const int UnknownData01 = 0x03D0;
		public const int DebuffTemplate = 0x03E0;
	}

	public class ATslDamageFieldContainer
	{
		public const int UnknownData00 = 0x03B0;
		public const int DamageFieldLayouts = 0x03B8;
		public const int UnknownData01 = 0x03C8;
		public const int DamageFieldTemplate = 0x03D0;
		public const int FlameInWall = 0x03D8;
		public const int UnknownData02 = 0x03D9;
		public const int FlameMaxCountInWall = 0x03DC;
		public const int FlameDelayInWall = 0x03E0;
		public const int UnknownData03 = 0x03E4;
	}

	public class ATslDestructibleContainer
	{
		public const int bFlag = 0x03B0;
		public const int UnknownData00 = 0x03B1;
	}

	public class ATslDoor
	{
		public const int DoorMeshComponent = 0x03C0;
		public const int AkSound = 0x03C8;
		public const int Interaction = 0x03D0;
		public const int UnknownData00 = 0x03D8;
		public const int DoorDestructibleMesh = 0x03F8;
		public const int bDoorOpened = 0x0400;
		public const int bReverseRotation = 0x0400;
		public const int UnknownData01 = 0x0401;
		public const int OpenAngle = 0x0404;
		public const int OpenSound = 0x0408;
		public const int CloseSound = 0x0410;
		public const int OpenCurve = 0x0418;
		public const int OpenCurveDuration = 0x0420;
		public const int UnknownData02 = 0x0424;
		public const int CloseCurve = 0x0428;
		public const int CloseCurveDuration = 0x0430;
		public const int PointDamageImpulse = 0x0434;
		public const int PointDamageRadius = 0x0438;
		public const int BreakingRadius = 0x043C;
		public const int BreakingImpulse = 0x0440;
		public const int BreakingMinDamage = 0x0444;
		public const int DamageAccumulateTimeout = 0x0448;
		public const int UnknownData03 = 0x044C;
		public const int TopImpactSoketName = 0x0450;
		public const int CenterImpactSoketName = 0x0458;
		public const int BottomImpactSoketName = 0x0460;
		public const int UnknownData04 = 0x0468;
		public const int DoorBreakingState = 0x0630;
		public const int UnknownData05 = 0x0631;
	}

	public class ATslExplosionEffect
	{
		public const int ExplosionFX = 0x03B0;
		public const int ExplosionLight = 0x03B8;
		public const int ExplosionLightFadeOut = 0x03C0;
		public const int UnknownData00 = 0x03C4;
		public const int ExplosionSound = 0x03C8;
		public const int DecalEffectDataSet = 0x03D0;
		public const int DecalSpawnDelayTime = 0x0538;
		public const int UnknownData01 = 0x053C;
		public const int SurfaceHit = 0x0540;
		public const int UnknownData02 = 0x05C8;
	}

	public class ATslFence
	{
		public const int SplineComponent = 0x03B0;
		public const int BeginSelector = 0x03B8;
		public const int UnknownData00 = 0x03B9;
		public const int BeginMesh1 = 0x03C0;
		public const int BeginMesh2 = 0x03C8;
		public const int BeginMesh3 = 0x03D0;
		public const int BeginMesh4 = 0x03D8;
		public const int EndSelector = 0x03E0;
		public const int UnknownData01 = 0x03E1;
		public const int EndMesh1 = 0x03E8;
		public const int EndMesh2 = 0x03F0;
		public const int EndMesh3 = 0x03F8;
		public const int EndMesh4 = 0x0400;
		public const int bUseRandomForMiddle = 0x0408;
		public const int bUseMiddleSegmentsInOrder = 0x0409;
		public const int UnknownData02 = 0x040A;
		public const int UnitLengthForMiddle = 0x040C;
		public const int UnitSpacingForMiddle = 0x0410;
		public const int PivotOffsetForMiddle = 0x0414;
		public const int RandomStreamForMiddle = 0x0418;
		public const int MiddleMesh1 = 0x0420;
		public const int MiddleMesh2 = 0x0428;
		public const int MiddleMesh3 = 0x0430;
		public const int MiddleMesh4 = 0x0438;
		public const int FenceCollisionProfile = 0x0440;
		public const int UnknownData03 = 0x0448;
	}

	public class UTslReactionData
	{
		public const int DestroyDelay = 0x0030;
		public const int VehicleReactionData = 0x0034;
		public const int RadialDamageReactionData = 0x0040;
		public const int PointDamageReactionData = 0x004C;
		public const int DependancyCountBySibling = 0x005C;
		public const int PhysicsReactionSoundAk = 0x0060;
		public const int DestructibleReactionSoundAk = 0x0068;
	}

	public class UTslReactionComponent
	{
		public const int UnknownData00 = 0x09C0;
		public const int bPendingDestroy = 0x09C8;
		public const int UnknownData01 = 0x09C9;
		public const int ReactionData = 0x09D0;
		public const int ReactionDM = 0x09D8;
		public const int UnknownData02 = 0x09E0;
	}

	public class ATslBreakableFence
	{
		public const int ReactionData = 0x0450;
		public const int BeginDestuctible1 = 0x0458;
		public const int BeginDestuctible2 = 0x0460;
		public const int BeginDestuctible3 = 0x0468;
		public const int BeginDestuctible4 = 0x0470;
		public const int EndDestuctible1 = 0x0478;
		public const int EndDestuctible2 = 0x0480;
		public const int EndDestuctible3 = 0x0488;
		public const int EndDestuctible4 = 0x0490;
		public const int MiddleDestuctible1 = 0x0498;
		public const int MiddleDestuctible2 = 0x04A0;
		public const int MiddleDestuctible3 = 0x04A8;
		public const int MiddleDestuctible4 = 0x04B0;
	}

	public class UTslPerformanceTestComponent
	{
		public const int UnknownData00 = 0x01E0;
	}

	public class ATslGameMode
	{
		public const int MalePawnClass = 0x0480;
		public const int PerfBotPlayerControllerClass = 0x0488;
		public const int ModeControllerClass = 0x0490;
		public const int AdditionalModeControllerClasses = 0x0498;
		public const int InitialItemDonatorClass = 0x04A8;
		public const int MatchPreparerClasses = 0x04B0;
		public const int MatchStartType = 0x04C0;
		public const int CameraViewBehaviour = 0x04C1;
		public const int PlayerRespawn = 0x04C2;
		public const int UnknownData00 = 0x04C3;
		public const int PostMatchWaitingTime = 0x04C4;
		public const int CustomGamePostMatchWaitingTime = 0x04C8;
		public const int ESportsPostMatchWaitingTime = 0x04CC;
		public const int ServerQuitAfterLeavingMapTime = 0x04D0;
		public const int MinPlayers = 0x04D4;
		public const int PlayerSpawnTryMaxCount = 0x04D8;
		public const int bEnablePerfBotInPIE = 0x04DC;
		public const int bEnablePerfBotLogin = 0x04DD;
		public const int bIsPerfBotSpawnToRandomPosition = 0x04DE;
		public const int bCanRestartPerfBot = 0x04DF;
		public const int bEnableObserverInPIE = 0x04E0;
		public const int IsBattleRoyale = 0x04E1;
		public const int bStartPlayerAtMatchStart = 0x04E2;
		public const int bShouldSpawnAtStartSpot = 0x04E3;
		public const int UnknownData01 = 0x04E4;
		public const int bIsEditorTestZombieMode = 0x04E5;
		public const int bIsCustomGame = 0x04E6;
		public const int bCanAllSpectate = 0x04E7;
		public const int CustomGameUpdateCharacterInfo = 0x04E8;
		public const int UnknownData02 = 0x04FC;
		public const int LimitCustomStringParameters = 0x0500;
		public const int MultiplierBlueZone = 0x0510;
		public const int BlueZoneCentralizationFactor = 0x0514;
		public const int MultiplierCarePackage = 0x0518;
		public const int RedZoneCustomOption = 0x051C;
		public const int BlueZoneCustomOptions = 0x0538;
		public const int WarmupTime = 0x0548;
		public const int EditorTestTeamMemberCount = 0x054C;
		public const int RewardDataMap = 0x0550;
		public const int RewardData = 0x05A0;
		public const int WinnerPlayerState = 0x05A8;
		public const int WinnerTeam = 0x05B0;
		public const int UnknownData03 = 0x05B4;
		public const int ItemSpawnProcessorClass = 0x05B8;
		public const int ThingSpawnProcessorClass = 0x05C0;
		public const int BasicBeltItemClassForNoBelt = 0x05C8;
		public const int UnknownData04 = 0x05D0;
		public const int ItemSpawnProcessor = 0x05D8;
		public const int ThingSpawnProcessor = 0x05E0;
		public const int InitialItemDonator = 0x05E8;
		public const int MatchPreparer = 0x05F0;
		public const int ModeController = 0x05F8;
		public const int DroppedItemGridManager = 0x0600;
		public const int AdditinalModeControllers = 0x0608;
		public const int UnknownData05 = 0x0618;
		public const int JoinedUserPlayerStateMap = 0x06B0;
		public const int Teams = 0x0700;
		public const int UnknownData06 = 0x0710;
	}

	public class UTslGameUserSettings
	{
		public const int ScreenScale = 0x0108;
		public const int Gamma = 0x010C;
		public const int bIsLanMatch = 0x0110;
		public const int bIsMasterSoundMute = 0x0111;
		public const int UnknownData00 = 0x0112;
		public const int MasterSoundVolume = 0x0114;
		public const int bIsEffectSoundMute = 0x0118;
		public const int UnknownData01 = 0x0119;
		public const int EffectSoundVolume = 0x011C;
		public const int bIsUISoundMute = 0x0120;
		public const int UnknownData02 = 0x0121;
		public const int UISoundVolume = 0x0124;
		public const int bIsBGMSoundMute = 0x0128;
		public const int UnknownData03 = 0x0129;
		public const int BGMSoundVolume = 0x012C;
		public const int bIsVoiceInputMute = 0x0130;
		public const int bIsVoiceOutputMute = 0x0131;
		public const int UnknownData04 = 0x0132;
		public const int VoiceInputVolume = 0x0134;
		public const int VoiceOutputVolume = 0x0138;
		public const int bUsePushToTalk = 0x013C;
		public const int bUseGlobalVoice = 0x013D;
		public const int bUseTeamVoice = 0x013E;
		public const int bSavedGraphicOption = 0x013F;
		public const int bMotionBlur = 0x0140;
		public const int UnknownData05 = 0x0141;
		public const int CultureName = 0x0148;
		public const int CustomInputSettins = 0x0158;
		public const int SelectMiniMapIndex = 0x01B0;
		public const int FpsCameraFov = 0x01B4;
		public const int bUseForceFeedback = 0x01B8;
		public const int UnknownData06 = 0x01B9;
		public const int ColorBlindType = 0x01BC;
		public const int CrosshairColorString = 0x01C0;
		public const int GearProfile1 = 0x01D0;
		public const int GearProfile2 = 0x01E0;
		public const int FppWeaponIconShowType = 0x01F0;
		public const int TpsWeaponIconShowType = 0x01F1;
		public const int FppEquipableItemIconShowType = 0x01F2;
		public const int bUseCharacterCapture = 0x01F3;
		public const int WorldMapZoomSpeedLevel = 0x01F4;
		public const int bIconKillfeedEnabled = 0x01F8;
		public const int InputModeCrouch = 0x01F9;
		public const int InputModeProne = 0x01FA;
		public const int InputModeWalk = 0x01FB;
		public const int bToggleSprint = 0x01FC;
		public const int InputModeHoldRotation = 0x01FD;
		public const int InputModeHoldBreath = 0x01FE;
		public const int InputModePeek = 0x01FF;
		public const int InputModeMap = 0x0200;
		public const int InputModeADS = 0x0201;
		public const int bEditorApplyOverrideScalability = 0x0202;
		public const int bUseFreeLookInterp = 0x0203;
		public const int bUseKillcam = 0x0204;
		public const int bPreloadingMap = 0x0205;
		public const int UnknownData07 = 0x0206;
		public const int PreloadingMaps = 0x0208;
		public const int OnGameUserSettingApplied = 0x0218;
	}

	public class ATslGameSession
	{
		public const int UnknownData00 = 0x03C8;
	}

	public class ATslGameState
	{
		public const int MatchId = 0x0410;
		public const int MatchShortGuid = 0x0420;
		public const int bIsCustomGame = 0x0430;
		public const int bIsWinnerZombieTeam = 0x0431;
		public const int UnknownData00 = 0x0432;
		public const int NumTeams = 0x0434;
		public const int RemainingTime = 0x0438;
		public const int MatchElapsedMinutes = 0x043C;
		public const int bTimerPaused = 0x0440;
		public const int UnknownData01 = 0x0441;
		public const int NumJoinPlayers = 0x0444;
		public const int NumAlivePlayers = 0x0448;
		public const int NumAliveZombiePlayers = 0x044C;
		public const int NumAliveTeams = 0x0450;
		public const int NumStartPlayers = 0x0454;
		public const int NumStartTeams = 0x0458;
		public const int SafetyZonePosition = 0x045C;
		public const int SafetyZoneRadius = 0x0468;
		public const int PoisonGasWarningPosition = 0x046C;
		public const int PoisonGasWarningRadius = 0x0478;
		public const int RedZonePosition = 0x047C;
		public const int RedZoneRadius = 0x0488;
		public const int TotalReleaseDuration = 0x048C;
		public const int ElapsedReleaseDuration = 0x0490;
		public const int TotalWarningDuration = 0x0494;
		public const int ElapsedWarningDuration = 0x0498;
		public const int bIsGasRelease = 0x049C;
		public const int bIsTeamMatch = 0x049D;
		public const int bIsZombieMode = 0x049E;
		public const int UnknownData02 = 0x049F;
		public const int ElapsedGasReleaseDuration = 0x04A0;
		public const int LerpSafetyZonePosition = 0x04A4;
		public const int LerpSafetyZoneRadius = 0x04B0;
		public const int SafetyZoneBeginPosition = 0x04B4;
		public const int SafetyZoneBeginRadius = 0x04C0;
		public const int MatchStartType = 0x04C4;
		public const int UnknownData03 = 0x04C5;
		public const int LevelAttribute = 0x04C8;
		public const int UnknownData04 = 0x04D0;
	}

	public class UTslGameViewportClient
	{
		public const int UnknownData00 = 0x0610;
		public const int DialogUMGWidget = 0x0640;
		public const int UnknownData01 = 0x0648;
	}

	public class UTslGlassWindowComponent
	{
		public const int DestructibleMesh = 0x09C0;
		public const int DestroyDelayAfterDestructed = 0x09C8;
		public const int UnknownData00 = 0x09CC;
		public const int DestructSound = 0x09D0;
		public const int DestructSoundOcclusionRefreshInterval = 0x09D8;
		public const int UnknownData01 = 0x09DC;
		public const int DestructibleComponent = 0x09E0;
		public const int bReplicatedOnClient = 0x09E8;
		public const int bDestroyed = 0x09E8;
		public const int UnknownData02 = 0x09E9;
	}

	public class UTslGunAnimInstance
	{
		public const int WeaponFire = 0x0378;
		public const int WeaponFireCycle = 0x0388;
		public const int TriggerOn = 0x0398;
		public const int TriggerOff = 0x03A8;
		public const int Reload1 = 0x03B8;
		public const int Reload2 = 0x03C8;
		public const int ReloadByOneStart = 0x03D8;
		public const int ReloadByOneSingle = 0x03E8;
		public const int ReloadByOneEnd = 0x03F8;
		public const int WeaponCharge = 0x0408;
		public const int FireSelect = 0x0418;
		public const int CancelReload = 0x0428;
		public const int Name_FireMode_Semi = 0x0438;
		public const int Name_FireMode_Burst = 0x0440;
		public const int Name_FireMode_Fullauto = 0x0448;
	}

	public class UTslHealthGaugeData
	{
		public const int HealthGaugeColors = 0x0030;
		public const int WarningRage = 0x0040;
		public const int GroggyColorCurve = 0x0048;
	}

	public class UTslHornComponent
	{
		public const int LongHornStartingTime = 0x01E0;
		public const int CurrHornKeyPressedTime = 0x01E4;
		public const int bHornKeyDown = 0x01E8;
		public const int bPlayingLongHorn = 0x01E9;
		public const int UnknownData00 = 0x01EA;
		public const int HornPlayInfo = 0x01EC;
		public const int UnknownData01 = 0x01F4;
		public const int HornSounds_Local = 0x01F8;
		public const int HornSounds_Remote = 0x0208;
		public const int UnknownData02 = 0x0218;
	}

	public class ATslImpactEffect
	{
		public const int DefaultFX = 0x03B0;
		public const int ConcreteFX = 0x03B8;
		public const int DirtFX = 0x03C0;
		public const int WaterFX = 0x03C8;
		public const int MetalFX = 0x03D0;
		public const int WoodFX = 0x03D8;
		public const int GlassFX = 0x03E0;
		public const int GrassFX = 0x03E8;
		public const int FleshFX = 0x03F0;
		public const int AkSound = 0x03F8;
		public const int DecalEffectDataSet = 0x0400;
		public const int SurfaceHit = 0x0568;
		public const int ParticleCom = 0x05F0;
		public const int AKCom = 0x05F8;
	}

	public class UTslInstancedGlassWindowComponent
	{
		public const int DestructibleMesh = 0x0BC0;
		public const int DestroyDelayAfterDestructed = 0x0BC8;
		public const int UnknownData00 = 0x0BCC;
		public const int DestructSound = 0x0BD0;
		public const int DestructSoundOcclusionRefreshInterval = 0x0BD8;
		public const int bReplicatedOnClient = 0x0BDC;
		public const int UnknownData01 = 0x0BDD;
		public const int DestroyedInstances = 0x0BF0;
		public const int PendingDestroyInstances = 0x0C00;
		public const int UnknownData02 = 0x0C10;
	}

	public class UTslInstancedReactionComponent
	{
		public const int PendingDestroyInstances = 0x0BC0;
		public const int ReactionData = 0x0BD0;
		public const int ReactionDM = 0x0BD8;
		public const int UnknownData00 = 0x0BE0;
	}

	public class ATslLevelScriptActor
	{
		public const int WeatherLevelInfos = 0x03B8;
		public const int GlobalMPC = 0x03C8;
		public const int SelectedWeatherLevelIndex = 0x03D0;
		public const int UnknownData00 = 0x03D4;
	}

	public class ATslLobbyLevelScriptActor
	{
		public const int MainMenuStreamingLevelName = 0x03B8;
		public const int CustomizationStreamingLevelName = 0x03C0;
	}

	public class UTslPersistentUser
	{
		public const int Gamma = 0x0028;
		public const int AimSensitivity = 0x002C;
		public const int bInvertedYAxis = 0x0030;
		public const int UnknownData00 = 0x0031;
		public const int ScreenScalePercentage = 0x0034;
		public const int UnknownData01 = 0x0038;
	}

	public class UTslLocalPlayer
	{
		public const int PersistentUser = 0x01C8;
	}

	public class UTslMenuItemWidgetStyle
	{
		public const int MenuItemStyle = 0x0030;
	}

	public class UTslMenuSoundsWidgetStyle
	{
		public const int SoundsStyle = 0x0030;
	}

	public class UTslMenuWidgetStyle
	{
		public const int MenuStyle = 0x0030;
	}

	public class ATslModularBuilding
	{
		public const int UnknownData00 = 0x03B0;
	}

	public class ATslParticle
	{
		public const int bAutoDestroyOnParticleFinish = 0x03B0;
		public const int bAutoPlaySound = 0x03B1;
		public const int UnknownData00 = 0x03B2;
		public const int DefaultParameters = 0x03B8;
		public const int AttachParentType = 0x03C8;
		public const int UnknownData01 = 0x03C9;
		public const int AttachSocketName = 0x03D0;
		public const int AttachLocationRule = 0x03D8;
		public const int AttachRotationRule = 0x03D9;
		public const int AttachScaleRule = 0x03DA;
		public const int UnknownData02 = 0x03DB;
		public const int ParticleSystem = 0x03E0;
		public const int AkSound = 0x03E8;
		public const int UnknownData03 = 0x03F0;
	}

	public class ATslParticleBulletTrail
	{
		public const int TargetDestanation = 0x0408;
		public const int BulletSpeed = 0x0414;
		public const int UnknownData00 = 0x0418;
	}

	public class ATslParticleEnvironment
	{
		public const int UnknownData00 = 0x0408;
		public const int AutoParticleActivateDistance = 0x0418;
		public const int AutoPlayDistance = 0x041C;
		public const int UnknownData01 = 0x0420;
	}

	public class ATslPassArea
	{
		public const int SphereComponent = 0x03B0;
		public const int Radius = 0x03B8;
		public const int UnknownData00 = 0x03BC;
	}

	public class ATslPassAreaRectangle
	{
		public const int BoxComponent = 0x03B0;
		public const int Width = 0x03B8;
		public const int Height = 0x03BC;
	}

	public class UTslPawnInputBindingComponent
	{
		public const int OnOwnerPossessed = 0x01E0;
		public const int OnOwnerUnPossessed = 0x01F0;
	}

	public class ATslPhysicsVolume
	{
		public const int OceanManager = 0x03F8;
		public const int DefaultWaterSplash = 0x0400;
		public const int VehicleWaterSplash = 0x0408;
		public const int WaterSplashMuteTypes = 0x0410;
		public const int UnknownData00 = 0x0420;
	}

	public class ATslPlayerCameraManager
	{
		public const int UnknownData00 = 0x1BB0;
	}

	public class ATslPlayerState
	{
		public const int Ranking = 0x0440;
		public const int UnknownData00 = 0x0444;
		public const int AccountId = 0x0448;
		public const int bKilled = 0x0458;
		public const int bShowMapMarker = 0x0459;
		public const int UnknownData01 = 0x045A;
		public const int MapMarkerPosition = 0x045C;
		public const int UnknownData02 = 0x0464;
		public const int ReplicatedCastableItems = 0x0468;
		public const int bEmptyReplicatedCastableItems = 0x0478;
		public const int ObserverAuthorityType = 0x0479;
		public const int UnknownData03 = 0x047A;
		public const int TeamNumber = 0x047C;
		public const int bIsZombie = 0x0480;
		public const int UnknownData04 = 0x0481;
		public const int PlayerScores = 0x0484;
		public const int PlayerStatistics = 0x0490;
		public const int PlayerStatisticsForOwner = 0x0494;
		public const int UnknownData05 = 0x04A4;
		public const int ReplicatedEquipableItems = 0x0550;
		public const int UnknownData06 = 0x0560;
		public const int bQuitter = 0x057C;
		public const int UnknownData07 = 0x057D;
		public const int LastHitTime = 0x067C;
		public const int CurrentAttackerPlayerNetId = 0x0680;
	}

	public class ATslPostProcessEffect
	{
		public const int TargetPostProcessVolumeName = 0x03B0;
		public const int PostProcessMaterials = 0x03B8;
		public const int DefaultPostProcessEffectParameter = 0x03C8;
		public const int PostProcessEffectDynamicMaterialStates = 0x03D8;
		public const int PostProcessVolume = 0x03E8;
		public const int UnknownData00 = 0x03F0;
	}

	public class ATslWeapon_Projectile
	{
		public const int ProjectileConfig = 0x0AE0;
	}

	public class ATslProjectile
	{
		public const int UnknownData00 = 0x03B0;
		public const int MovementComp = 0x03B8;
		public const int CollisionComp = 0x03C0;
		public const int ParticleComp = 0x03C8;
		public const int MeshComp = 0x03D0;
		public const int MeshConstraint = 0x03D8;
		public const int MeshInitialRotationRate = 0x03E0;
		public const int bSyncServerAndClientRotation = 0x03EC;
		public const int UnknownData01 = 0x03ED;
		public const int HideMeshAtExplosion = 0x03FC;
		public const int ExplosionInWater = 0x03FD;
		public const int ExplosionRotationType = 0x03FE;
		public const int UnknownData02 = 0x03FF;
		public const int ParticleToMeshAttachPointName = 0x0400;
		public const int UnknownData03 = 0x0408;
		public const int ExplosionTemplate = 0x0410;
		public const int ExplosionTemplateInAir = 0x0418;
		public const int ExplosionTemplateInWater = 0x0420;
		public const int ImpactSound = 0x0428;
		public const int AkComp = 0x0430;
		public const int UnknownData04 = 0x0438;
		public const int ExplodeState = 0x0440;
		public const int bActiveParticle = 0x0441;
		public const int bDoTick = 0x0441;
		public const int UnknownData05 = 0x0442;
		public const int ClientMeshRotation = 0x0444;
		public const int ServerMeshRotation = 0x0450;
		public const int VelocityStopStepDistance = 0x045C;
		public const int LastStepLocation = 0x0460;
		public const int StepBuffer = 0x046C;
		public const int FinalInterpSpeed = 0x0470;
		public const int bConstantInterpStep = 0x0474;
		public const int UnknownData06 = 0x0475;
		public const int VelocityCheckTimerTick = 0x0478;
		public const int bPropagateEffectActor = 0x047C;
		public const int UnknownData07 = 0x047D;
		public const int ProjectileConfig = 0x0480;
		public const int ReplicatedEffectActor = 0x04B0;
		public const int UnknownData08 = 0x04B8;
	}

	public class ATslProjectileMolotov
	{
		public const int MolotovSimulation = 0x04E8;
		public const int UnknownData00 = 0x04E9;
		public const int DamageFieldContainerTemplate = 0x04F0;
		public const int DamageFieldContainerInWallTemplate = 0x04F8;
		public const int DamageFieldTemplate = 0x0500;
		public const int DamageFieldTemplateInWall = 0x0508;
		public const int FragmentProjectileClass = 0x0510;
		public const int ImpactMaxCount = 0x0518;
		public const int UnknownData01 = 0x051C;
	}

	public class ATslProjectileRedZone
	{
		public const int CreateSound = 0x04E8;
	}

	public class UTslReactionDoorComponent
	{
		public const int UnknownData00 = 0x09C0;
		public const int ReactionDoorData = 0x09C8;
		public const int DoorDestructibleMesh = 0x09D0;
		public const int DoorBreakingState = 0x09D8;
		public const int UnknownData01 = 0x09D9;
	}

	public class UTslSceneCaptureComponent2D
	{
		public const int UnknownData00 = 0x0A20;
		public const int World = 0x0A28;
	}

	public class UTslSceneCaptureWorld
	{
		public const int UnknownData00 = 0x0028;
		public const int World = 0x0050;
		public const int UnknownData01 = 0x0058;
	}

	public class ATslServerParticle
	{
		public const int bAutoDestroyOnParticleFinish = 0x03B0;
		public const int bAutoPlaySound = 0x03B1;
		public const int UnknownData00 = 0x03B2;
		public const int ParticleSystem = 0x03B8;
		public const int AkSound = 0x03C0;
		public const int UnknownData01 = 0x03C8;
	}

	public class UTslSingleton
	{
		public const int UnknownData00 = 0x0028;
		public const int WeaponsPenetrationConfig = 0x0138;
	}

	public class UTslSmokePropagationComponent
	{
		public const int UnknownData00 = 0x03E0;
		public const int SmokeParticle = 0x03E8;
		public const int UnknownData01 = 0x03F0;
		public const int BlockingActorTemplate = 0x0410;
		public const int HalfHeightGlobal = 0x0418;
		public const int HalfHeightLocalScalar = 0x041C;
		public const int GlobalRadius = 0x0420;
		public const int GlobalAngle = 0x0424;
		public const int RadialTryCount = 0x0428;
		public const int LoopCount = 0x042C;
		public const int LastWorkerIndex = 0x0430;
		public const int MaxDistanceFromHost = 0x0434;
		public const int CeilingTraceDistance = 0x0438;
		public const int MainParticleVelocityScale_First = 0x043C;
		public const int MainParticleVelocityScale_Second = 0x0448;
		public const int MainParticleVelocityScale_Third = 0x0454;
		public const int HorizontalRayTraceOffset = 0x0460;
		public const int HorizontalRayRadiusScalar = 0x0464;
		public const int HorizontalRayPropagateOffset = 0x0468;
		public const int BlockerGroundTraceOffset = 0x046C;
		public const int LowChildVelocityStaticVector = 0x0470;
		public const int HighChildVelocityStaticVector = 0x047C;
		public const int LowChildVelocityInMap = 0x0488;
		public const int LowChildVelocityOutMap = 0x0490;
		public const int HighChildVelocityInMap = 0x0498;
		public const int HighChildVelocityOutMap = 0x04A0;
		public const int CurrentRadialRay = 0x04A8;
		public const int CurrentSpawnedChildCount = 0x04AC;
		public const int MaxTicksAllowed = 0x04B0;
		public const int MaxChildrenAllowed = 0x04B4;
		public const int CustomTickInterval = 0x04B8;
		public const int StartDelay = 0x04BC;
		public const int bDebugPropagation = 0x04C0;
		public const int bDebugTick = 0x04C1;
		public const int UnknownData02 = 0x04C2;
		public const int ParticleLifetime = 0x04C4;
		public const int ParticleLifetimeRandomOffset = 0x04C8;
		public const int ParticleToObjectLifeScale = 0x04D0;
		public const int UnknownData03 = 0x04D4;
	}

	public class ATslSpectatorPawn
	{
		public const int ReplayHUD = 0x0438;
		public const int LevelAttribute_BattleRoyalRule = 0x0440;
		public const int LevelAttribute_Erangel = 0x0448;
		public const int LevelAttribute_Desert = 0x0450;
		public const int PlayerInfoMinDistance = 0x0458;
		public const int PlayerInfoMaxDistance = 0x045C;
		public const int FreeCameraSpringArmComponent = 0x0460;
		public const int FreeCameraComponent = 0x0468;
		public const int FollowCameraSpringArmComponent = 0x0470;
		public const int FollowCameraComponent = 0x0478;
		public const int AudioListener = 0x0480;
		public const int UnknownData00 = 0x0488;
		public const int DeathFollowBlendTime = 0x048C;
		public const int DeathFollowBlendFunc = 0x0490;
		public const int UnknownData01 = 0x0491;
		public const int DeathFollowBlendExp = 0x0494;
		public const int DeathFollowTime = 0x0498;
		public const int UnknownData02 = 0x049C;
		public const int DeathFollowDistance = 0x04A0;
		public const int UnknownData03 = 0x04A4;
		public const int DeathFollowBone = 0x04A8;
		public const int UnknownData04 = 0x04B0;
		public const int LocationUpdateIntervalSeconds = 0x04B4;
		public const int UnknownData05 = 0x04B8;
		public const int LimitMinFreeCamFov = 0x04BC;
		public const int LimitMaxFreeCamFov = 0x04C0;
		public const int UnknownData06 = 0x04C4;
		public const int FollowCameraZoomSpeed = 0x04D0;
		public const int LimitTargetArmLength = 0x04D4;
		public const int DeathCharacter = 0x04D8;
		public const int SpectatableCheckLength = 0x04E0;
		public const int SpectatableCheckScreenRatio = 0x04E4;
		public const int UnknownData07 = 0x04E8;
		public const int OutlineEffectClass = 0x0500;
		public const int OutlineEffect = 0x0508;
		public const int ArrObPos = 0x0510;
		public const int UnknownData08 = 0x0520;
		public const int ReplayZoneEffectClass = 0x0590;
		public const int ReplayZoneEffect = 0x0598;
		public const int OnPlayerInfoDistanceDelegate = 0x05A0;
		public const int UnknownData09 = 0x05B0;
	}

	public class UTslSpectatorPawnMovement
	{
		public const int UnknownData00 = 0x0280;
		public const int FastMoveModifier = 0x0284;
		public const int SlowMoveModifier = 0x0288;
		public const int MinFreeMoveSpeed = 0x028C;
		public const int MaxFreeMoveSpeed = 0x0290;
		public const int MinFreeMoveSpeedHeight = 0x0294;
		public const int MaxFreeMoveSpeedHeight = 0x0298;
		public const int AbsoluteMinZ = 0x029C;
		public const int AbsoluteMaxZ = 0x02A0;
		public const int UnknownData01 = 0x02A4;
	}

	public class UTslStreamer
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UFoliageCollisionStreamer
	{
		public const int bEnabled = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int MinDistance = 0x004C;
		public const int MaxQueryDistance = 0x0050;
		public const int MaxSimulationDistance = 0x0054;
		public const int bUseOnlyQueryAndPhysics = 0x0058;
		public const int UnknownData01 = 0x0059;
	}

	public class ULODActorStreamer
	{
		public const int bEnabled = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int PreLoadDistance = 0x004C;
		public const int PerFrameShowCount = 0x0050;
		public const int PerFrameShowCountLimit = 0x0054;
		public const int MinDrawDistanceOverride = 0x0058;
		public const int UnknownData01 = 0x0068;
	}

	public class UParticleEnvrionmentStreamer
	{
		public const int bEnabled = 0x0048;
		public const int UnknownData00 = 0x0049;
		public const int ToleranceDeactiveDistance = 0x004C;
		public const int UnknownData01 = 0x0050;
	}

	public class ATslStreamerManager
	{
		public const int UnknownData00 = 0x03B0;
		public const int StreamerClasses = 0x03B8;
		public const int TslStreamers = 0x03C8;
	}

	public class UTslThrowableTrajectoryViewComponent
	{
		public const int SplineSegmentMesh = 0x0910;
		public const int SplineSegmentMeshMaterial = 0x0918;
		public const int SegmentMeshScale = 0x0920;
		public const int ImpactMesh = 0x0928;
		public const int ImpactMeshMaterial = 0x0930;
		public const int ImpactMeshScale = 0x0938;
		public const int UnknownData00 = 0x0944;
		public const int UnknownData01 = 0x0944;
		public const int PredictionTime = 0x0998;
		public const int DistanceScaleFactor = 0x099C;
		public const int MaterialParam_NearDepthFadeOrigin = 0x09A0;
		public const int MaterialParam_FarDepthFadeOrigin = 0x09A8;
		public const int SplineGenerationAngThresholdDeg = 0x09B0;
		public const int UnknownData02 = 0x09B4;
		public const int ImpactMeshComponent = 0x09C0;
		public const int SplineMeshArray = 0x09C8;
		public const int SplineSegmentMeshMaterialDynamic = 0x09D8;
	}

	public class UTslUserWidget
	{
		public const int InputComponentAxis = 0x0240;
		public const int CachedTslCharacter = 0x0248;
		public const int CachedTslGameState = 0x0250;
		public const int CachedViewTargetTslCharacter = 0x0258;
	}

	public class UBlockInputUserWidget
	{
		public const int bWhiteList = 0x0260;
		public const int UnknownData00 = 0x0261;
		public const int BlockActions = 0x0268;
		public const int BlockAxises = 0x0278;
		public const int bGenerateEventOnOpen = 0x0288;
		public const int bLockMouseCursorInViewport = 0x0289;
		public const int UnknownData01 = 0x028A;
	}

	public class UUmgBaseWidget
	{
		public const int bUseEmergingAnimation = 0x0260;
		public const int bUseVanishingAnimation = 0x0260;
		public const int UnknownData00 = 0x0261;
		public const int EmergingAnimationBinder = 0x0268;
		public const int VanishingAnimationBinder = 0x0288;
		public const int UnknownData01 = 0x02A8;
		public const int PendingVisibility = 0x02C0;
		public const int UnknownData02 = 0x02C1;
		public const int VanishingStartTime = 0x02C4;
	}

	public class UTslXboxTeamManageWidget
	{
		public const int TeamMemberVerticalBox_Binder = 0x0290;
	}

	public class UBluezoneGpsBaseWidget
	{
		public const int BluezoneGaugeImageBinder = 0x02C8;
		public const int BluezoneTimeTextBinder = 0x02F0;
		public const int PlayerIconImageBinder = 0x0310;
		public const int MovingAnimationBinder = 0x0338;
		public const int WarningAnimationList = 0x0358;
		public const int ReleasingTextAnimationList = 0x0368;
		public const int EnterNextPlayzoneAnimBinder = 0x0378;
		public const int LeaveNextPlayzoneAnimBinder = 0x0398;
		public const int WidgetEmergingAnimBinder = 0x03B8;
		public const int WidgetVanishingAminBinder = 0x03D8;
		public const int PlayZoneStartParmName = 0x03F8;
		public const int BluezoneEndParamName = 0x0400;
		public const int ColorMultiplyParmName = 0x0408;
		public const int InNextPlayzoneColorMultiply = 0x0410;
		public const int WarningTimeTextFormat = 0x0420;
		public const int ReleaseTimeText = 0x0438;
		public const int BluezoneResetSequence = 0x0450;
		public const int PlayzoneResetSequence = 0x04F0;
		public const int PlayerIconResetSequence = 0x0590;
		public const int UnknownData00 = 0x0630;
	}

	public class UCharacterStanceBaseWidget
	{
		public const int StanceIconImageBinder = 0x02C8;
		public const int IconStateParamName = 0x02F0;
	}

	public class UEquipableItemIconBaseWidget
	{
		public const int EquipSlotID = 0x02C8;
		public const int UnknownData00 = 0x02C9;
		public const int DurabilityColorSet = 0x02D0;
		public const int bUseWrning = 0x02E0;
		public const int UnknownData01 = 0x02E1;
		public const int WarningRange = 0x02E4;
		public const int IconVisibilityType = 0x02EC;
		public const int UnknownData02 = 0x02ED;
		public const int IconImageBinder = 0x02F0;
		public const int IconTexParamName = 0x0318;
		public const int IconColorParamName = 0x0320;
		public const int DefaultColor = 0x0328;
		public const int WarningAnimBinder = 0x0338;
		public const int NoBagSpaceAnimBinder = 0x0358;
	}

	public class UInteractionBaseWidget
	{
		public const int MainLayer = 0x02C8;
		public const int InteractionMessageTextBinder = 0x02E8;
		public const int InteractionMessageTextBgBinder = 0x0308;
		public const int AdditionalTextBinder = 0x0328;
		public const int SuitableWeaponImageBinder = 0x0348;
		public const int SuitableWeaponImageHeight = 0x0370;
		public const int UnknownData00 = 0x0374;
		public const int KeyImageBinder = 0x0378;
		public const int InteractionKeyTextBinder = 0x03A0;
		public const int AdditionalMessageBlinkingBinder = 0x03C0;
		public const int AdditionalMessageNormalBinder = 0x03E0;
		public const int ShowAnimationBinder = 0x0400;
		public const int HiddenAnimationBinder = 0x0420;
		public const int SwitchAnimationBinder = 0x0440;
		public const int SwitchAnimationResetBinder = 0x0460;
		public const int InteractionInputMethodSwitcherBinder = 0x0480;
		public const int InteractionKeyName = 0x04A0;
		public const int ProgressCircle_Binder = 0x04A8;
		public const int InteractionTextColor_Interactable = 0x04D0;
		public const int InteractionTextShadowColor_Interactable = 0x04E0;
		public const int InteractionTextColor_NotInteractable = 0x04F0;
		public const int InteractionTextShadowColor_NotInteractable = 0x0500;
		public const int UnknownData01 = 0x0510;
	}

	public class UKillCountBaseWidget
	{
		public const int KillCountTextBinder = 0x02C8;
		public const int IncreasingAnimBinder = 0x02E8;
		public const int IncreasingKillCountDisplayTime = 0x0308;
		public const int LastKillCount = 0x030C;
		public const int bLastWantShow = 0x0310;
		public const int UnknownData00 = 0x0311;
		public const int IncreasingKillCountDisplayStartTime = 0x0314;
	}

	public class ULifeGaugeBaseWidget
	{
		public const int LifeGaugeColorData = 0x02C8;
		public const int LifeGaugeImageBinder = 0x02D0;
		public const int LifeGaugeRatioValueParamName = 0x02F8;
		public const int LifeGaugeColorParamName = 0x0300;
		public const int HealAmountImageBinder = 0x0308;
		public const int HitEffectLayer = 0x0330;
		public const int HealAmountRatioValueParamName = 0x0350;
		public const int HealAmountRatioSartParamName = 0x0358;
		public const int HealAmountRatioEndParamName = 0x0360;
		public const int HealAmountColorParamName = 0x0368;
		public const int HealEffectTimeCurve = 0x0370;
		public const int HitEffectClass = 0x0378;
		public const int Item_Heal_FirstAid = 0x0380;
		public const int Item_Heal_MedKit = 0x0388;
		public const int WarningAnimationBinder = 0x0390;
		public const int GroggyAnimationBinder = 0x03B0;
		public const int UnknownData00 = 0x03D0;
	}

	public class ULifeGaugeEffectBaseWidget
	{
		public const int UnknownData00 = 0x02C8;
		public const int OldLifeRatioParamName = 0x02D8;
		public const int CurrentLifeRatioParamName = 0x02E0;
		public const int LifeEffectBinder = 0x02E8;
		public const int LifeEffectAnimationFloatCurveList = 0x0310;
		public const int LifeEffectAnimationVectorCurveList = 0x0320;
		public const int LifeEffectBackgroundBinder = 0x0330;
		public const int LifeEffectBgAnimationFloatCurveList = 0x0358;
		public const int LifeEffectBgAnimationVectorCurveList = 0x0368;
		public const int bAutoDestroyOnEffectPlayFinish = 0x0378;
		public const int UnknownData01 = 0x0379;
	}

	public class ULifeGaugeHitEffectBaseWidget
	{
		public const int AlphaCurveList = 0x02C8;
		public const int HitEffectImage = 0x02D8;
		public const int BaseColorParamName = 0x0300;
		public const int ColorLerpParamName = 0x0308;
		public const int BrightAlphaParamName = 0x0310;
		public const int HitEffectAlphaParamName = 0x0318;
		public const int HitEffectStartParamName = 0x0320;
		public const int HitEffectEndParamName = 0x0328;
		public const int UnknownData00 = 0x0330;
	}

	public class ULifeGaugeTemplateBaseWidget
	{
		public const int LifeGaugeColorData = 0x02C8;
		public const int LifeGaugeImageBinder = 0x02D0;
		public const int LifeGaugeRatioValueParamName = 0x02F8;
		public const int LifeGaugeColorParamName = 0x0300;
		public const int WarningAnimationBinder = 0x0308;
		public const int BackgroundImageBinder = 0x0328;
		public const int bOverrideLifeGaugeMaterial = 0x0350;
		public const int UnknownData00 = 0x0351;
		public const int OverrideLifeGaugeMaterial = 0x0358;
		public const int bOverrideBackgroundMaterial = 0x0360;
		public const int UnknownData01 = 0x0361;
		public const int OverrideBackgroundMaterial = 0x0368;
		public const int bUseEffect = 0x0370;
		public const int UnknownData02 = 0x0371;
		public const int DamageEffectClass = 0x0378;
		public const int HealEffectClass = 0x0380;
		public const int HealAmountEffectClass = 0x0388;
		public const int EffectLayerBinder = 0x0390;
		public const int DamageEffectMax = 0x03B0;
		public const int HealEffectMax = 0x03B4;
		public const int UnknownData03 = 0x03B8;
		public const int DamageEffects = 0x03D0;
		public const int HealEffects = 0x03E0;
		public const int HealAmountEffect = 0x03F0;
	}

	public class UMapCarePackageItemIconBaseWidget
	{
		public const int IconImageBorderBinder = 0x02C8;
		public const int IconImageBinder = 0x02E8;
		public const int IconStateParamName = 0x0310;
		public const int IconColorParamName = 0x0318;
		public const int UnknownData00 = 0x0320;
	}

	public class UMapCharacterIconBaseWidget
	{
		public const int IconImageBorderBinder = 0x02C8;
		public const int IconImageBinder = 0x02E8;
		public const int IconStateParamName = 0x0310;
		public const int IconRotationParamName = 0x0318;
		public const int IconColorParamName = 0x0320;
		public const int PlayerNameBoderBinder = 0x0328;
		public const int PlayerNameBinder = 0x0348;
		public const int ObserverMuzzleFlashBoderBinder = 0x0368;
		public const int ObserverMuzzleFlashWidgetBinder = 0x0388;
		public const int LifeGaugeBorderBinder = 0x03A8;
		public const int LifeGaugeWidgetBinder = 0x03C8;
		public const int AttackedAnimBinder = 0x03E8;
		public const int HittedAnimBinder = 0x0408;
		public const int GroggyAnimBinder = 0x0428;
		public const int FadeOutAnimBinder = 0x0448;
		public const int ButtonBInder = 0x0468;
		public const int UnknownData00 = 0x0488;
		public const int bTeamNumber = 0x0498;
		public const int UnknownData01 = 0x0499;
		public const int TeamNumberText = 0x04A0;
		public const int RiderLayerBinder = 0x04C0;
		public const int RiderIconClass = 0x04E0;
		public const int DisplayNameFormatWithOtherPlayer = 0x04E8;
		public const int MyDirectionIcon = 0x0500;
		public const int TeamDirectionIcon = 0x0508;
		public const int SpectatedIconBorder = 0x0510;
		public const int NameTagColorImageBinder = 0x0530;
		public const int UnknownData02 = 0x0558;
		public const int PendingIconMaterial = 0x0570;
		public const int RiderIconList = 0x0578;
	}

	public class UMapGridWidget
	{
		public const int MapImageBinder = 0x02C8;
		public const int MyMarkerLayerBinder = 0x02F0;
		public const int TeamMarkerLayerBinder = 0x0310;
		public const int MapMarkerClass = 0x0330;
		public const int MyMapIconLayerBinder = 0x0338;
		public const int OtherMapIconLayerBinder = 0x0358;
		public const int CarePackageItemIconLayerBinder = 0x0378;
		public const int MapCharacterIconClass = 0x0398;
		public const int MapCarePackageItemIconClass = 0x03A0;
		public const int ObserverPlayerIconHitEffectClass = 0x03A8;
		public const int bShowName = 0x03B0;
		public const int bIsMinimap = 0x03B1;
		public const int UnknownData00 = 0x03B2;
		public const int RedzoneImageBinder = 0x03B8;
		public const int RedzoneColorParamName = 0x03E0;
		public const int RedzoneColorSet = 0x03E8;
		public const int ImageSizeBoxBinder = 0x03F8;
		public const int BluezoneColorSet = 0x0418;
		public const int Desaturation = 0x0428;
		public const int Contrast = 0x042C;
		public const int ZoomLevel = 0x0430;
		public const int ShowGridZoomLevel = 0x0434;
		public const int ViewRatioCurve = 0x0438;
		public const int bRectangleViewMode = 0x0440;
		public const int UnknownData01 = 0x0441;
		public const int GridFont = 0x0448;
		public const int FontTypeFace = 0x0450;
		public const int GridTextHorizentalArray = 0x0458;
		public const int GridTextVerticalArray = 0x0468;
		public const int ColorLargeGrid = 0x0478;
		public const int ColorSmallGrid = 0x0488;
		public const int ColorText = 0x0498;
		public const int ColorSafetyZone = 0x04A8;
		public const int ThicknessLargeGrid = 0x04B8;
		public const int ThicknessSmallGrid = 0x04BC;
		public const int ColorPoisonGasWarning = 0x04C0;
		public const int bDrawGridLine = 0x04D0;
		public const int bDrawGridText = 0x04D1;
		public const int bDrawNextPlayzoneGuideLine = 0x04D2;
		public const int bUseZOrderSort = 0x04D3;
		public const int bUseTeamMemberColor = 0x04D4;
		public const int bRemoveDeadIcon = 0x04D5;
		public const int UnknownData02 = 0x04D6;
		public const int DefaultIconNameTagColor = 0x04D8;
		public const int UnknownData03 = 0x04E8;
		public const int MatInst = 0x04F8;
		public const int UnknownData04 = 0x0500;
		public const int MyMapMarker = 0x0518;
		public const int TeamPlayerMarkers = 0x0520;
		public const int MyCharacterMapIcon = 0x0570;
		public const int OtherCharacterMapIcons = 0x0578;
		public const int MapCarePackageItemIcons = 0x05C8;
		public const int ReplicatedCharacterListUpdateTimer = 0x0618;
		public const int ReplicatedCarePackageItemListUpdateTimer = 0x0620;
		public const int ReplicatedCharacterList = 0x0628;
		public const int ReplicatedCarePackageItemList = 0x0638;
		public const int ShowMarkerOnwerList = 0x0648;
		public const int UnknownData05 = 0x0658;
		public const int MyOrTeamIconMaterial = 0x0678;
		public const int OtherCharacterIconMaterial = 0x0680;
		public const int CloseMySelf = 0x0688;
		public const int OnHideOwner = 0x0698;
	}

	public class UMapMarkerBaseWidget
	{
		public const int MarkerImageBinder = 0x02C8;
		public const int MarkerColorParmName = 0x02F0;
		public const int MarkerEmergingAnimBinder = 0x02F8;
		public const int UnknownData00 = 0x0318;
	}

	public class UMiniMapBaseWidget
	{
		public const int MapWidgetBinder = 0x02C8;
		public const int UnknownData00 = 0x02E8;
	}

	public class UNetworkProblemBaseWidget
	{
		public const int CheckElapsedTime = 0x02C8;
		public const int UnknownData00 = 0x02CC;
		public const int IconBlinkingAnimBinder = 0x02D0;
	}

	public class UReplayProblemBaseWidget
	{
		public const int CheckElapsedTime = 0x02C8;
		public const int UnknownData00 = 0x02CC;
		public const int IconBlinkingAnimBinder = 0x02D0;
	}

	public class URiderIconWidget
	{
		public const int RiderIcon = 0x02C8;
	}

	public class UTeamMarkWidget
	{
		public const int TeamMember = 0x02C8;
		public const int OffsetZ = 0x02D0;
		public const int DeadMarkInvisibleTime = 0x02D4;
		public const int DeadMarkInvisibleDistance = 0x02D8;
		public const int DefaultImageAlpha = 0x02DC;
		public const int DefaultTextAlpha = 0x02E0;
		public const int AmingImageAlpha = 0x02E4;
		public const int ScopingImageAlpha = 0x02E8;
		public const int AmingTextAlpha = 0x02EC;
		public const int ScopingTextAlpha = 0x02F0;
		public const int OffScreenEdgeSize = 0x02F4;
		public const int OffScreenImageEdgeSize = 0x02FC;
		public const int AnimationMaxDistance = 0x0304;
		public const int StateSwitcherBinder = 0x0308;
		public const int PlayerNameTextBinder = 0x0328;
		public const int OutLineImageBinder = 0x0348;
		public const int DirectionImageBinder = 0x0370;
		public const int NormalImageBinder = 0x0398;
		public const int GroggyImageBinder = 0x03C0;
		public const int DeadImageBinder = 0x03E8;
		public const int VehicleImageBinder = 0x0410;
		public const int ParachuteImageBinder = 0x0438;
		public const int QuitterImageBinder = 0x0460;
		public const int ScaleOpacityByDistanceAnim = 0x0488;
		public const int ImageMarkBorderBinder = 0x04A8;
		public const int OutScreenImage = 0x04C8;
		public const int GroggyImage = 0x04D0;
		public const int VehicleImage = 0x04D8;
		public const int ParachuteImage = 0x04E0;
		public const int UnknownData00 = 0x04E8;
	}

	public class UTeamOverallKillCountBaseWidget
	{
		public const int TeamOverallKillCountTextBinder = 0x02C8;
		public const int LastTeamOverallKillCount = 0x02E8;
		public const int bLastWantShow = 0x02EC;
		public const int UnknownData00 = 0x02ED;
	}

	public class UTslAdaptiveCrosshairWidget
	{
		public const int WeaponClass = 0x02C8;
		public const int bIsShowWidget = 0x02C9;
		public const int UnknownData00 = 0x02CA;
		public const int ColorBlindColors = 0x02D0;
		public const int AdaptiveCrosshair_Binder = 0x02E0;
		public const int CanvasBase_Binder = 0x0308;
		public const int CenterCenter_Binder = 0x0328;
		public const int CenterCrosshair_Binder = 0x0348;
		public const int CenterD_Binder = 0x0368;
		public const int CenterDOT_Binder = 0x0388;
		public const int CenterL_Binder = 0x03B0;
		public const int CenterR_Binder = 0x03D0;
		public const int CenterU_Binder = 0x03F0;
		public const int Pistol_C_Binder = 0x0410;
		public const int Pistol_C_Gradient_Binder = 0x0438;
		public const int Pistol_L_Binder = 0x0460;
		public const int Pistol_R_Binder = 0x0488;
		public const int Rifle_D_Binder = 0x04B0;
		public const int Rifle_D_Arrow_Binder = 0x04D8;
		public const int Rifle_L_Binder = 0x0500;
		public const int Rifle_L_Arrow_Binder = 0x0528;
		public const int Rifle_R_Binder = 0x0550;
		public const int Rifle_R_Arrow_Binder = 0x0578;
		public const int Rifle_U_Binder = 0x05A0;
		public const int Rifle_U_Arrow_Binder = 0x05C8;
		public const int Shotgun_D_Binder = 0x05F0;
		public const int Shotgun_L_Binder = 0x0618;
		public const int Shotgun_R_Binder = 0x0640;
		public const int Shotgun_U_Binder = 0x0668;
	}

	public class UTslAlivePlayerInfoWidget
	{
		public const int CachedTslGS = 0x02C8;
		public const int ColorOverlay_Binder = 0x02D0;
		public const int Warning_Binder = 0x02F0;
		public const int Increasing_Binder = 0x0310;
		public const int Decreasing_Binder = 0x0330;
		public const int Default_Binder = 0x0350;
		public const int AdditionalInfo_Binder = 0x0370;
		public const int SurvivorCount_Binder = 0x0390;
		public const int bIsReplaying = 0x03B0;
		public const int bIsHidden = 0x03B1;
		public const int UnknownData00 = 0x03B2;
		public const int CurrentCount = 0x03B4;
		public const int DisplayCount = 0x03B8;
		public const int WhileAnimCount = 0x03BC;
	}

	public class UTslKeyDisplayWidget
	{
		public const int OnKeyInputed = 0x02C8;
		public const int KeyReceiverWidgets = 0x02D8;
		public const int KeyReceiverWidgetBinders = 0x02E8;
		public const int InputName = 0x02F8;
		public const int CategoryName = 0x0300;
		public const int DisplayText = 0x0308;
		public const int bGamepad = 0x0320;
		public const int bAxisInput = 0x0321;
		public const int UnknownData00 = 0x0322;
		public const int AxisScale = 0x0324;
	}

	public class UTslKeyOptionWidget
	{
		public const int ScrollBox_Binder = 0x02C8;
		public const int KeySettingWidgets = 0x02E8;
		public const int MouseSettingWidgetClass = 0x02F8;
		public const int MouseSettingWidget = 0x0300;
		public const int KeySettingWidgetClass = 0x0308;
		public const int GamePadSettingWidgetClass = 0x0310;
		public const int GamePadSettingWidget = 0x0318;
		public const int CategoryOrder = 0x0320;
	}

	public class UTslKeySettingWidget
	{
		public const int OnKeyChanged = 0x02C8;
		public const int KeyDisplayWidgetClass = 0x02D8;
		public const int KeyScrollBoxBinder = 0x02E0;
		public const int KeyDisplayWidgets = 0x0300;
		public const int DisplayText = 0x0310;
		public const int CategoryName = 0x0328;
	}

	public class UTslBoostGaugeWidget
	{
		public const int MID_Gauge0_21 = 0x02C8;
		public const int MID_Gauge20_61 = 0x02D0;
		public const int MID_Gauge60_91 = 0x02D8;
		public const int MID_Gauge90_101 = 0x02E0;
		public const int VanishingAnimBinder = 0x02E8;
		public const int WarningAnimBinder = 0x0308;
		public const int EmergingAnimBinder = 0x0328;
		public const int Boost0_20ImageBinder = 0x0348;
		public const int Boost20_60ImageBinder = 0x0368;
		public const int Boost60_90ImageBinder = 0x0388;
		public const int Boost90_100ImageBinder = 0x03A8;
		public const int DisplayingBoost = 0x03C8;
		public const int bIsWarning = 0x03CC;
		public const int bIsVanished = 0x03CD;
		public const int UnknownData00 = 0x03CE;
	}

	public class UTslBreatheBarWidget
	{
		public const int TslHudCached = 0x02C8;
		public const int TslPlayerControllerCached = 0x02D0;
		public const int BreathGaugeLayer_Binder = 0x02D8;
		public const int BreathGaugeBG_Binder = 0x02F8;
		public const int Breathing_Binder = 0x0320;
		public const int Drowning_Binder = 0x0340;
		public const int Vanishing_Binder = 0x0360;
		public const int Emerging_Binder = 0x0380;
		public const int Cooldown_Binder = 0x03A0;
		public const int BreathRatioDisplay = 0x03C0;
		public const int BreathRatio = 0x03C4;
		public const int LerpTolerance = 0x03C8;
		public const int LerpTime = 0x03CC;
		public const int BreathImgColor_Less_101 = 0x03D0;
		public const int BreathImgColor_Less_51 = 0x03E0;
		public const int BreathImgColor_Less_11 = 0x03F0;
		public const int bIsVanishing = 0x0400;
		public const int bEventBound = 0x0401;
		public const int bIsCooldown = 0x0402;
		public const int UnknownData00 = 0x0403;
	}

	public class UTslBuffIconListWidget
	{
		public const int RunBuffIconBlock_Binder = 0x02C8;
		public const int RunBuffIcon_Binder = 0x02E8;
		public const int HealBuffIconBlock_Binder = 0x0310;
		public const int HealBuffIcon_Binder = 0x0330;
		public const int HealBuffIconTex = 0x0358;
		public const int RunBuffIconTex = 0x0360;
	}

	public class UTslCastableItemIconWidget
	{
		public const int CastableItemType = 0x02C8;
		public const int UnknownData00 = 0x02C9;
		public const int ItemIcon = 0x02D0;
		public const int ItemIconRatio = 0x02D8;
		public const int NormalColor = 0x02DC;
		public const int NoItemColor = 0x02EC;
		public const int UnknownData01 = 0x02FC;
		public const int Icon_Binder = 0x0300;
		public const int ItemCountText_Binder = 0x0320;
		public const int WidgetBorder_Binder = 0x0340;
		public const int IconSizeBox_Binder = 0x0360;
	}

	public class UTslCompassMarkerWidget
	{
		public const int CompassMarkerImageBinder = 0x02C8;
		public const int MarkerNumber = 0x02F0;
		public const int XViewSize = 0x02F4;
		public const int bShow = 0x02F8;
		public const int UnknownData00 = 0x02F9;
	}

	public class UTslCompassWidget
	{
		public const int MI_Compass = 0x02C8;
		public const int MID_Compass = 0x02D0;
		public const int CompassImageBinder = 0x02D8;
		public const int MarkerImageBinder = 0x0300;
		public const int MyOverlayBinder = 0x0328;
		public const int TeamOverlayBinder = 0x0348;
		public const int CompassMarkerWidgetClass = 0x0368;
		public const int MyCompassMarkerWidget = 0x0370;
		public const int TeamMarkerWidgetOfTeam = 0x0378;
		public const int DivisionLevel = 0x0388;
		public const int Offset = 0x038C;
		public const int bClockwise = 0x0390;
		public const int UnknownData00 = 0x0391;
		public const int Width = 0x0394;
		public const int bIsInitilzed = 0x0398;
		public const int UnknownData01 = 0x0399;
	}

	public class UTslConfirmationDialogWidget
	{
		public const int UnknownData00 = 0x02C8;
	}

	public class UTslGroggyCircleWidget
	{
		public const int MID_ProgressCircle = 0x02C8;
		public const int MI_ProgressCircle = 0x02D0;
		public const int CircleImageBinder = 0x02D8;
		public const int CrossImageBinder = 0x0300;
	}

	public class UTslHealItemSelectorWidget
	{
		public const int InventoryCached = 0x02C8;
		public const int HealItemSelectorTimer = 0x02D0;
		public const int WidgetHideTimer = 0x02D8;
		public const int LastSelectedHealItemType = 0x02E0;
		public const int UnknownData00 = 0x02E1;
		public const int HealItemDatas = 0x02E8;
		public const int ItemIcon_Binder = 0x02F8;
		public const int InitialPosition = 0x0320;
		public const int OffsetWhenTpsWeaponIconEnabled = 0x0328;
	}

	public class UTslInventoryCapacityWidget
	{
		public const int GameMaxSpace = 0x02C8;
		public const int UnknownData00 = 0x02CC;
		public const int InventoryCached = 0x02D0;
	}

	public class UTslKeyReceiverWidget
	{
		public const int OnKeyReceived = 0x02C8;
		public const int OriginKey = 0x02D8;
		public const int FirstDownKey = 0x02F8;
		public const int CurrentDownKey = 0x0310;
		public const int LastDownedKey = 0x0330;
		public const int bFocused = 0x0350;
		public const int bEnableInput = 0x0351;
		public const int bIsKeyUp = 0x0352;
		public const int bAxisInput = 0x0353;
		public const int AxisScale = 0x0354;
		public const int MouseButtons = 0x0358;
	}

	public class UTslKillMessageListWidget
	{
		public const int KillMessageWidgetClass = 0x02C8;
		public const int KillMessageWidgetArray = 0x02D0;
		public const int FadeoutStartTime = 0x02E0;
		public const int UnknownData00 = 0x02E4;
	}

	public class UTslKillMessageWidget
	{
		public const int OnVanishAnimationFinished = 0x02C8;
		public const int Vanish_Binder = 0x02D8;
		public const int CauseOfDeathDatas = 0x02F8;
		public const int ConditionOfDeathDatas = 0x0308;
	}

	public class UTslLobbyNameTagWidget
	{
		public const int NickName_Binder = 0x02C8;
		public const int HostImage_Binder = 0x02E8;
		public const int ReadyImage_Binder = 0x0310;
		public const int VoiceImage_Binder = 0x0338;
		public const int bTestAlwaysShowIcons = 0x0360;
		public const int UnknownData00 = 0x0361;
		public const int SlotIndex = 0x0364;
		public const int NameTagOffsetTranslation = 0x0368;
		public const int bIsHost = 0x0374;
		public const int bIsReady = 0x0375;
		public const int bIsSpeaking = 0x0376;
		public const int UnknownData01 = 0x0377;
	}

	public class UTslObserverPlayerInfoWidget
	{
		public const int TeamColorsCached = 0x02C8;
		public const int UnArmedIcon = 0x02D8;
		public const int UnArmedIconRatio = 0x02E0;
		public const int UnknownData00 = 0x02E4;
		public const int CachedCharacter = 0x02E8;
		public const int OldAmmoCount = 0x02F0;
		public const int UnknownData01 = 0x02F4;
		public const int AmmoIncreasingAnimBinder = 0x02F8;
		public const int AmmoDecreasingAnimBinder = 0x0318;
		public const int UserNameText_Binder = 0x0338;
		public const int TeamNumberText_Binder = 0x0358;
		public const int AmmoCountText_Binder = 0x0378;
		public const int KillCountText_Binder = 0x0398;
		public const int LifeGaugeTemplateWidget_Binder = 0x03B8;
		public const int WeaponIconImageBinder = 0x03D8;
		public const int WeaponIconImageSizeBoxBinder = 0x0400;
		public const int WeaponIconTextureParmName = 0x0420;
		public const int WeaponIconColorParmName = 0x0428;
		public const int WeaponColor_Armed = 0x0430;
		public const int WeaponColor_Normal = 0x0440;
		public const int WeaponColorSet_NoReload = 0x0450;
	}

	public class UTslTeamInfoListWidget
	{
		public const int TeamInfoWidgetList = 0x02C8;
		public const int TeamInfoWidgetClass = 0x02D8;
		public const int VerticalBoxBinder = 0x02E0;
	}

	public class UTslTeamInfoWidget
	{
		public const int bBindVoiceChatEvent = 0x02C8;
		public const int bSpeaking = 0x02C9;
		public const int UnknownData00 = 0x02CA;
		public const int TeamHpAreaBinder = 0x02D0;
		public const int TeamInfoAreaBinder = 0x02F0;
		public const int InfoIconBorderBinder = 0x0310;
		public const int InfoIconBinder = 0x0330;
		public const int SpeakingImageBinder = 0x0358;
		public const int MarkerIconBorderBinder = 0x0380;
		public const int MarkerImageBinder = 0x03A0;
		public const int BoostImageBinder = 0x03C8;
		public const int bUdateTeamNameColor = 0x03F0;
		public const int UnknownData01 = 0x03F1;
		public const int TeamNameBinder = 0x03F8;
		public const int OnSpeakAnimBinder = 0x0418;
		public const int HealthGaugeWidgetBinder = 0x0438;
		public const int ColorBlindColorSet = 0x0458;
		public const int TeamMemberColorBinder = 0x0468;
		public const int PlayerIconImageBinder = 0x0490;
		public const int Team = 0x04B8;
		public const int QuitColor = 0x04C0;
	}

	public class UTslTeamWidget
	{
		public const int TeamMarkWidgets = 0x02C8;
		public const int TeamMarkWidgetClass = 0x02D8;
		public const int TeamMarkerLayerBinder = 0x02E0;
	}

	public class UTslXboxTeamManageInfoWidget
	{
		public const int MemberNumber = 0x02C8;
		public const int UnknownData00 = 0x02CC;
		public const int UserName = 0x02D0;
		public const int bIsVoiceMute = 0x02D8;
		public const int UnknownData01 = 0x02D9;
	}

	public class UVehicleFuelBaseWidget
	{
		public const int OilGaugeImageBinder = 0x02C8;
		public const int OilGaugeBgImageBinder = 0x02F0;
		public const int OilArrowImageBinder = 0x0318;
		public const int GaugeBodyBinder = 0x0340;
		public const int NormalColor = 0x0360;
		public const int FuelEmptyColor = 0x0370;
		public const int GaugePramName = 0x0380;
	}

	public class UVehicleSeatInfoBaseWidget
	{
		public const int SeatIndex = 0x02C8;
		public const int UnknownData00 = 0x02CC;
		public const int StateParamName = 0x02D0;
		public const int SeatImageBinder = 0x02D8;
		public const int CachedVehiclePawn = 0x0300;
		public const int CachedSeatComponent = 0x0308;
	}

	public class UVehicleStanceBaseWidget
	{
		public const int VehicleIconAreaBinder = 0x02C8;
		public const int SpeedTextBinder = 0x02E8;
		public const int LifeGaugeWidgetBinder = 0x0308;
		public const int FuelGaugeWidgetBinder = 0x0328;
		public const int CachedVehiclePawn = 0x0348;
		public const int CachedVehicleIconWidget = 0x0350;
	}

	public class UVehicleWheelInfoBaseWidget
	{
		public const int WheelIndex = 0x02C8;
		public const int UnknownData00 = 0x02CC;
		public const int WheelImageBinder = 0x02D0;
		public const int PunctureImageBinder = 0x02F8;
		public const int CachedVehiclePawn = 0x0320;
		public const int CachedVehicleMovement = 0x0328;
	}

	public class UVersionInfoBaseWidget
	{
		public const int WithNickNameFormat = 0x02C8;
		public const int WithOutNickNameFormat = 0x02E0;
		public const int VersionInfoTextBinder = 0x02F8;
	}

	public class UWeaponSlotBaseWidget
	{
		public const int bListInSlot = 0x02C8;
		public const int UnknownData00 = 0x02C9;
		public const int WeaponIndex = 0x02CC;
		public const int ListSlotNoReloadGuideType = 0x02D0;
		public const int bUseWeaponIcon = 0x02D1;
		public const int UnknownData01 = 0x02D2;
		public const int WeaponIconImageBinder = 0x02D8;
		public const int WeaponIconImageSizeBoxBinder = 0x0300;
		public const int WeaponIconImageSizeBoxHeight = 0x0320;
		public const int UnknownData02 = 0x0324;
		public const int WeaponIconTextureParmName = 0x0328;
		public const int WeaponIconColorParmName = 0x0330;
		public const int WeaponColor_Armed = 0x0338;
		public const int WeaponColor_Normal = 0x0348;
		public const int WeaponColor_Unarmed = 0x0358;
		public const int ScaleUpAnimBinder = 0x0368;
		public const int ScaleDownAnimBinder = 0x0388;
		public const int WeaponColorSet_NoReload = 0x03A8;
		public const int bUseAmmoTextAndIcon = 0x03B8;
		public const int UnknownData03 = 0x03B9;
		public const int WeaponHandsOnLoadedAmmoCountTextBinder = 0x03C0;
		public const int WeaponListLoadedAmmoCountTextBinder = 0x03E0;
		public const int AmmoIncreasingAnimBinder = 0x0400;
		public const int AmmoDecreasingAnimBinder = 0x0420;
		public const int WeaponHandsOnUnloadedAmmoCountTextBinder = 0x0440;
		public const int UnloadedAmmoIncreasingAnimBinder = 0x0460;
		public const int UnloadedAmmoDecreasingAnimBinder = 0x0480;
		public const int WeaponHandsOnAmmoIconBinder = 0x04A0;
		public const int AmmoTexParamName = 0x04C8;
		public const int bUseWeaponFiringModeTextBinder = 0x04D0;
		public const int UnknownData04 = 0x04D1;
		public const int WeaponFiringModeTextBinder = 0x04D8;
		public const int bZeroingDistancebUseText = 0x04F8;
		public const int UnknownData05 = 0x04F9;
		public const int ZeroingDistanceBlockBinder = 0x0500;
		public const int ZeroingdistanceTextBinder = 0x0520;
		public const int ZeroDistIncreasingAnimBinder = 0x0540;
		public const int ZeroDistDecreasingAnimBinder = 0x0560;
		public const int ZeroingTextFormat = 0x0580;
		public const int ZeroingNA = 0x0598;
		public const int WeaponIconBackground = 0x05B0;
		public const int AmmoAndFringModeBackground = 0x05D0;
		public const int SlotBackgroundAlpha_Armed = 0x05F0;
		public const int SlotBackgroundAlpha_Unarmed = 0x05F4;
		public const int SlotBackgroundAlpha_Normal = 0x05F8;
		public const int UnknownData06 = 0x05FC;
	}

	public class UWeaponSlotHudBaseWidget
	{
		public const int CurrentWeaponSlotWidgetBinder = 0x02C8;
		public const int FadeInWeaponSlotAnimBinder = 0x02E8;
		public const int FadeOutWeaponSlotAnimBinder = 0x0308;
		public const int FadeInUnarmedWeaponSlotAminBinder = 0x0328;
		public const int FadeOutUnarmedWeaponSlotAminBinder = 0x0348;
		public const int WeaponSlotWidgetBinderList = 0x0368;
		public const int WeaponSlotListBorderBinder = 0x0378;
		public const int FadeInSlotListAminBinder = 0x0398;
		public const int FadeOutSlotListAminBinder = 0x03B8;
		public const int SlotOffsetMultiply = 0x03D8;
		public const int SlotPadding = 0x03DC;
		public const int MovingSequence = 0x03E0;
		public const int UnknownData00 = 0x0480;
		public const int FinishTimer = 0x04B0;
		public const int CachedWeaponProcessor = 0x04B8;
	}

	public class UTslVehicleAnimInstance
	{
		public const int UnknownData00 = 0x0890;
		public const int Rot_Steering_Right = 0x0894;
		public const int Rot_Steering_Final = 0x08A0;
		public const int Rot_Speed_Left = 0x08AC;
		public const int Rot_Speed_Right = 0x08B8;
		public const int SpeedMax = 0x08C4;
		public const int Rot_Speed_Final = 0x08C8;
		public const int Rot_RPM_Left = 0x08D4;
		public const int Rot_RPM_Right = 0x08E0;
		public const int RPMMax = 0x08EC;
		public const int bTickIndicators = 0x08F0;
		public const int bUseAbsoluteSteeringRotation = 0x08F1;
		public const int UnknownData01 = 0x08F2;
		public const int Rot_RPM_Final = 0x08F4;
		public const int VehicleRef = 0x0900;
		public const int VehicleMovementRef = 0x0908;
	}

	public class UTslVehicleCommonComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int OnRepair = 0x01E8;
		public const int OnDeath = 0x01F8;
		public const int OnHealthChange = 0x0208;
		public const int OnFuelChange = 0x0218;
		public const int SimpleBodyBoneName = 0x0228;
		public const int ComplexBodyBoneNames = 0x0230;
		public const int MainComplexBodyBoneName = 0x0240;
		public const int ComplexCollisionProfileName = 0x0248;
		public const int bIsDying = 0x0250;
		public const int bIsBroken = 0x0250;
		public const int UnknownData01 = 0x0251;
		public const int Health = 0x0254;
		public const int HealthMax = 0x0258;
		public const int Fuel = 0x025C;
		public const int FuelMax = 0x0260;
		public const int UnknownData02 = 0x0264;
		public const int VehicleExplosionDamageType = 0x0268;
		public const int CharacterDamageIgnores = 0x0270;
		public const int VehicleUI = 0x0280;
		public const int UnknownData03 = 0x0288;
	}

	public class UVehicleSurfaceAudioData
	{
		public const int EventIn = 0x0030;
		public const int EventOut = 0x0038;
	}

	public class UTslVehicleEffectComponent
	{
		public const int MeshComponent = 0x01E0;
		public const int EngineSoundComponent = 0x01E8;
		public const int VehicleEffectInfo = 0x01F0;
		public const int MufflerEffect = 0x02E0;
		public const int Muffler2Effect = 0x02E8;
		public const int BoostEffect = 0x02F0;
		public const int Boost2Effect = 0x02F8;
		public const int DamagedEffect = 0x0300;
		public const int ExplosionEffect = 0x0308;
		public const int FrontTrailEffect = 0x0310;
		public const int RearTrailEffect = 0x0318;
		public const int ThrusterEffect = 0x0320;
		public const int Thruster2Effect = 0x0328;
		public const int FrontFoamLeftEffect = 0x0330;
		public const int FrontFoamRightEffect = 0x0338;
		public const int UnknownData00 = 0x0340;
		public const int TrailSpeedThreshold = 0x035C;
		public const int FrontFoamSpawnThreshold = 0x0360;
		public const int bRPMOverride = 0x0364;
		public const int UnknownData01 = 0x0365;
		public const int bUseNewChassisAudio = 0x0378;
		public const int UnknownData02 = 0x0379;
		public const int Curve_EngineAudio = 0x0380;
		public const int bUseDopplerEffect = 0x0388;
		public const int UnknownData03 = 0x0389;
		public const int bUseNewSurfaceAudio = 0x03E0;
		public const int UnknownData04 = 0x03E1;
		public const int MeasuredWheelIndices = 0x03E8;
		public const int MeasuredWheelIndicesSlip = 0x03F8;
		public const int MeasuredWheelIndicesSpin = 0x0408;
		public const int MeasuredWheelIndicesBrake = 0x0418;
		public const int SuspenionOffsetForContact = 0x0428;
		public const int SurfaceActivationValue = 0x042C;
		public const int SurfaceDeactivationValue = 0x0430;
		public const int DT_Multiplier = 0x0434;
		public const int MinVelocityForSurfaceCheck = 0x0438;
		public const int MinSlip = 0x043C;
		public const int MinSpin = 0x0440;
		public const int MinVelocityForBreak = 0x0444;
		public const int BrakeNoDriverMultiplier = 0x0448;
		public const int VelocityInterpSpeed = 0x044C;
		public const int SlipInterpSpeed = 0x0450;
		public const int SpinInterpSpeed = 0x0454;
		public const int BreakInterpSpeed = 0x0458;
		public const int bDebugVisualizedMeasuredWheels = 0x045C;
		public const int UnknownData05 = 0x045D;
		public const int AngularVelocityCoefficient = 0x0460;
		public const int LateralVelocityCoeffictient = 0x0464;
		public const int LateralVelocityClamp = 0x0468;
		public const int bProcessShiftStart = 0x046C;
		public const int bProcessShiftEnd = 0x046D;
		public const int bProcessReverse = 0x046E;
		public const int UnknownData06 = 0x046F;
		public const int GearUpSound_Start = 0x0470;
		public const int GearDownSound_Start = 0x0478;
		public const int GearUpSound_End = 0x0480;
		public const int GearDownSound_End = 0x0488;
		public const int GearReverseSound = 0x0490;
		public const int UnknownData07 = 0x0498;
		public const int ApplyDestroyedMaterialDelay = 0x0578;
		public const int UnknownData08 = 0x057C;
	}

	public class UTslVehicleHitComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int MeshComponent = 0x01E8;
		public const int HitCharacterDuration = 0x01F0;
		public const int UnknownData01 = 0x01F4;
		public const int LeaveCharacterIgnoreDuration = 0x0248;
		public const int CharacterHitMinimumVehicleSpeed = 0x024C;
		public const int CharacterDamageVelocityUnitMultiplier = 0x0250;
		public const int CharacterDamageMassUnitMultiplier = 0x0254;
		public const int CharacterDamageSpeedCurve = 0x0258;
		public const int CharacterDamageMassCurve = 0x0260;
		public const int MinimumCharacterDamage = 0x0268;
		public const int CharacterLaunchSpeedMultiplier = 0x026C;
		public const int MinimumCharacterLaunchSpeed = 0x0270;
		public const int PhysicsImpulseMultiplier = 0x0274;
		public const int VoidPhysicalMaterial = 0x0278;
		public const int PhysicsImpactModifier = 0x0280;
		public const int PhysicsImpactModifierUpsideDown = 0x0284;
		public const int PhysicsImpactAbsorption = 0x0288;
		public const int PhysicsImpactAbsorptionUpsideDown = 0x028C;
		public const int PhysicsImpactAbsorptionRider = 0x0290;
		public const int PhysicsImpactAbsorptionRiderUpsideDown = 0x0294;
		public const int PhysicsImpactVehicleDamageMultiplier = 0x0298;
		public const int PhysicsImpactRiderDamageMultiplier = 0x029C;
		public const int VehicleHitDamageType = 0x02A0;
		public const int UnknownData02 = 0x02A8;
		public const int ExplosionBaseDamage = 0x02AC;
		public const int ExplosionMinimumDamage = 0x02B0;
		public const int ExplosionRadiusInner = 0x02B4;
		public const int ExplosionRadiusOuter = 0x02B8;
		public const int ExplosionDamageFalloff = 0x02BC;
		public const int ExplosionDamageType = 0x02C0;
		public const int ExplosionDamagePreventionChannel = 0x02C8;
		public const int UnknownData03 = 0x02C9;
		public const int ImpulseLimitationSpeedThreshold = 0x02D8;
		public const int CollectTime = 0x02DC;
		public const int UnknownData04 = 0x02E0;
		public const int DebugHitHistory = 0x02F0;
		public const int UnknownData05 = 0x0300;
		public const int HitAbsorberTypes = 0x0308;
		public const int UnknownData06 = 0x0318;
	}

	public class UTslVehicleSeatComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int OnLeave = 0x01E8;
		public const int OnDriverRide = 0x01F8;
		public const int OnDriverLeave = 0x0208;
		public const int OnPostDriverRide = 0x0218;
		public const int OnPostDriverLeave = 0x0228;
		public const int SeatInfos = 0x0238;
		public const int Seats = 0x0248;
		public const int bUseSeatCamera = 0x0258;
		public const int bDoFlipCheck = 0x0259;
		public const int UnknownData01 = 0x025A;
		public const int FlipForce = 0x025C;
		public const int bDoEntryAngleCheck = 0x0260;
		public const int UnknownData02 = 0x0261;
		public const int MinEntryAngle = 0x0264;
		public const int bDampenPlayerVelocityOnLeave = 0x0268;
		public const int UnknownData03 = 0x0269;
		public const int OnLeaveVelocityMultiplier = 0x026C;
		public const int bUseActiveStabilize = 0x0270;
		public const int UnknownData04 = 0x0271;
		public const int LastDriver = 0x0274;
		public const int UnknownData05 = 0x027C;
	}

	public class UTslVehicleSyncComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int MinCorrectionInterval = 0x01EC;
		public const int UnknownData01 = 0x01F0;
		public const int SendingToServerIntervalAtClient = 0x01F4;
		public const int UnknownData02 = 0x01F8;
		public const int SendingReliableHitToServerIntervalAtClient = 0x0200;
		public const int UnknownData03 = 0x0204;
		public const int AllowedMaxDistanceSqAtServer = 0x0208;
		public const int StationaryCorrectionIntervalAtClient = 0x020C;
		public const int UnknownData04 = 0x0210;
		public const int StationaryCorrectionSpeedThresholdSq = 0x0214;
		public const int StationaryCorrectionThresholdDistanceSq = 0x0218;
		public const int UnknownData05 = 0x021C;
	}

	public class UTslViewTargetTempComponent
	{
		public const int UnknownData00 = 0x01E0;
	}

	public class ATslWeapon_Trajectory
	{
		public const int TrajectoryGravityZ = 0x0AE0;
		public const int RecoilSpreadScale = 0x0AE4;
		public const int FireAtViewPoint = 0x0AE8;
		public const int UnknownData00 = 0x0AE9;
		public const int DefaultTimerFrequency = 0x0AEC;
		public const int CrouchSpreadModifier = 0x0AF0;
		public const int ProneSpreadModifier = 0x0AF4;
		public const int WalkSpread = 0x0AF8;
		public const int RunSpread = 0x0AFC;
		public const int JumpSpread = 0x0B00;
		public const int UnknownData01 = 0x0B04;
		public const int TrajectoryConfig = 0x0B08;
		public const int RecoilInfo = 0x0B88;
		public const int ImpactTemplate = 0x0BF0;
		public const int TrailFX = 0x0BF8;
		public const int TrailTargetParam = 0x0C50;
		public const int UnknownData02 = 0x0C58;
		public const int WeaponSpread = 0x0C70;
		public const int RecoilModifier_Stand = 0x0C74;
		public const int RecoilModifier_Crouch = 0x0C78;
		public const int RecoilModifier_Prone = 0x0C7C;
		public const int VerticalRecoilMin = 0x0C80;
		public const int VerticalRecoilMax = 0x0C84;
		public const int UnknownData03 = 0x0C88;
	}

	public class ATslWeapon_Melee
	{
		public const int AttackSoundAk = 0x07D8;
		public const int AttackAnims = 0x07E0;
		public const int Damage = 0x07F0;
		public const int WeaponImpact = 0x07F4;
		public const int DamageType = 0x07F8;
		public const int HitCheckType = 0x0800;
		public const int UnknownData00 = 0x0801;
		public const int AllowedHitRangeLeeway = 0x0804;
		public const int ImpactTemplate = 0x0808;
		public const int HitCapsuleComponent = 0x0810;
		public const int UnknownData01 = 0x0818;
	}

	public class ATslWeapon_Throwable
	{
		public const int ThrowableConfig = 0x07D8;
		public const int UnknownData00 = 0x0878;
		public const int ThrowableState = 0x0890;
		public const int UnknownData01 = 0x0891;
		public const int ThrowWeaponSocketName = 0x0898;
		public const int PawnMotionContributionMultiplier = 0x08A0;
		public const int UnknownData02 = 0x08AC;
		public const int CookingEffect = 0x08B0;
		public const int RingAttachment = 0x08B8;
	}

	public class ATslMotorbikeVehicle
	{
		public const int bUseKickstandStabilize = 0x0728;
		public const int UnknownData00 = 0x0729;
		public const int MinSuspensionOffsetForContact = 0x072C;
		public const int bStabilizeOnServer = 0x0730;
		public const int UnknownData01 = 0x0731;
		public const int KickstandStabilizeDamping = 0x0734;
		public const int KickstandMaxAngVelocity = 0x0738;
		public const int DefaultAngularDamping = 0x073C;
		public const int KickstandStabilizeTorqueScalar = 0x0740;
		public const int KickstandStabilizeRollScalar = 0x0744;
		public const int KickstandStabilizeRollMinRange = 0x0748;
		public const int MinVelocityForStabilizeOverride = 0x074C;
		public const int StabilizeBone_Low = 0x0750;
		public const int StabilizeBone_High = 0x0758;
		public const int Curve_Roll = 0x0760;
		public const int Curve_RollReturn = 0x0768;
		public const int Curve_Steer = 0x0770;
		public const int Curve_Yaw = 0x0778;
		public const int Curve_Torque = 0x0780;
		public const int StabStaticVector = 0x0788;
		public const int StabStaticVectorKickstand = 0x0794;
		public const int StabNoDriverVector = 0x07A0;
		public const int StabX_Velocity_In = 0x07AC;
		public const int StabX_Velocity_Out = 0x07B4;
		public const int StabX_Pitch_In = 0x07BC;
		public const int StabX_Pitch_Out = 0x07C4;
		public const int StabZ_Velocity_In = 0x07CC;
		public const int StabZ_Velocity_Out = 0x07D4;
		public const int StabZ_Roll_In = 0x07DC;
		public const int StabZ_Roll_Out = 0x07E4;
		public const int StabZ_Pitch_In = 0x07EC;
		public const int StabZ_Pitch_Out = 0x07F4;
		public const int StabTorque_In = 0x07FC;
		public const int StabTorque_Out = 0x0804;
		public const int StabTorque_ForceScalar = 0x080C;
		public const int StabTorque_Pitch_In = 0x0810;
		public const int StabTorque_Pitch_Out = 0x0818;
		public const int bUseFlipping = 0x0820;
		public const int UnknownData02 = 0x0821;
		public const int FlippingForce = 0x0824;
		public const int InitialFlipTimer = 0x0828;
		public const int MinVelocityForFlipping = 0x082C;
		public const int UnknownData03 = 0x0830;
		public const int ContactAlpha_RiseRate = 0x0834;
		public const int ContactAlpha_FallRate = 0x0838;
		public const int ContactAlpha_LowerClamp = 0x083C;
		public const int ContactAlpha_MapPitchIn = 0x0840;
		public const int ContactAlpha_MapRollIn = 0x0848;
		public const int AirControlF_VelMap = 0x0850;
		public const int AirControlB_VelMap = 0x0858;
		public const int AirControlL_VelMap = 0x0860;
		public const int AirControlR_VelMap = 0x0868;
		public const int AirControlQ_VelMap = 0x0870;
		public const int AirControlE_VelMap = 0x0878;
		public const int AirControl_FB_Torque = 0x0880;
		public const int AirControl_LR_Torque = 0x0884;
		public const int AirControl_QE_Torque = 0x0888;
		public const int bStabilizeInAir = 0x088C;
		public const int UnknownData04 = 0x088D;
		public const int StabilizeAirPercentage = 0x0890;
		public const int FC_PitchUp = 0x0894;
		public const int FC_PitchDown = 0x0898;
		public const int UnknownData05 = 0x089C;
		public const int bKickstandStabilize = 0x08CD;
		public const int UnknownData06 = 0x08CE;
	}

	public class ATslMotorbikeVehicle_Sidecar
	{
		public const int Sidecar_COM_Y_Left = 0x08D0;
		public const int Sidecar_COM_Y_Right = 0x08D4;
		public const int Sidecar_StabilizerHigh_StaticCOM = 0x08D8;
		public const int UnknownData00 = 0x08E4;
	}

	public class UTslWheelEffectType
	{
		public const int Sound = 0x0030;
		public const int DefaultFxClass = 0x0038;
		public const int ConcreteFxClass = 0x0040;
		public const int DirtFxClass = 0x0048;
		public const int WaterFxClass = 0x0050;
		public const int MetalFxClass = 0x0058;
		public const int WoodFxClass = 0x0060;
		public const int GrassFxClass = 0x0068;
		public const int GlassFxClass = 0x0070;
		public const int RockFxClass = 0x0078;
		public const int SandFxClass = 0x0080;
		public const int DefaultMinSpeed = 0x0088;
		public const int ConcreteMinSpeed = 0x008C;
		public const int DirtMinSpeed = 0x0090;
		public const int WaterMinSpeed = 0x0094;
		public const int MetalMinSpeed = 0x0098;
		public const int WoodMinSpeed = 0x009C;
		public const int GrassMinSpeed = 0x00A0;
		public const int GlassMinSpeed = 0x00A4;
		public const int RockMinSpeed = 0x00A8;
		public const int SandMinSpeed = 0x00AC;
	}

	public class UVehicleRiderComponent
	{
		public const int SeatIndex = 0x01E0;
		public const int UnknownData00 = 0x01E4;
		public const int LastVehiclePawn = 0x0220;
		public const int UnknownData01 = 0x0228;
	}

	public class ATslVehicleSeatActor
	{
		public const int RiderType = 0x0438;
		public const int UnknownData00 = 0x0439;
	}

	public class UVivoxResponse
	{
		public const int UnknownData00 = 0x0028;
	}

	public class USignInResponse
	{
		public const int UnknownData00 = 0x0098;
	}

	public class UChannelResponse
	{
		public const int UnknownData00 = 0x0098;
	}

	public class UKeyRevokeResponse
	{
		public const int UnknownData00 = 0x0098;
	}

	public class UKeyAddResponse
	{
		public const int UnknownData00 = 0x0098;
	}

	public class UVivoxBaseComponent
	{
		public const int UnknownData00 = 0x01E0;
		public const int OnParticipantMuteChanged = 0x01E8;
		public const int UnknownData01 = 0x01F8;
		public const int ConnectionInfo = 0x0200;
		public const int UnknownData02 = 0x0220;
		public const int TeamChannelUrl = 0x0228;
		public const int GlobalChannelUrl = 0x0238;
		public const int UnknownData03 = 0x0248;
		public const int ResetFailureDelaySeconds = 0x024C;
		public const int UnknownData04 = 0x0250;
		public const int UpdatePositionIntervalSeconds = 0x0268;
		public const int UnknownData05 = 0x026C;
		public const int UserInputVolumeModifier = 0x0278;
		public const int UserOutputVolumeModifier = 0x027C;
	}

	public class UVivoxComponent
	{
		public const int UnknownData00 = 0x0280;
		public const int SuddenMovementDistance = 0x02AC;
		public const int SuddenMovementModifier = 0x02B0;
		public const int SuddenMovementModifierDuration = 0x02B4;
		public const int SuddenMovementModifierRestoreDuration = 0x02B8;
		public const int UnknownData01 = 0x02BC;
		public const int bEnableObserverTeamChat = 0x02C0;
		public const int UnknownData02 = 0x02C1;
	}

	public class UVivoxLobbyComponent
	{
		public const int UnknownData00 = 0x0280;
	}

	public class UVivoxManager
	{
		public const int World = 0x0028;
		public const int UnknownData00 = 0x0030;
		public const int ConnectionInfo = 0x0038;
		public const int bUseEphmeralChannel = 0x0058;
		public const int UnknownData01 = 0x0059;
		public const int AuthId = 0x0060;
		public const int AuthPwd = 0x0070;
		public const int AccessTokenExpirationTime = 0x0080;
		public const int Issuer = 0x0088;
		public const int Key = 0x0098;
		public const int UnknownData02 = 0x00A8;
		public const int SignIn = 0x00B8;
		public const int KeyAdd = 0x00C0;
		public const int KeyRevoke = 0x00C8;
		public const int Channels = 0x00D0;
		public const int UnknownData03 = 0x00E0;
		public const int PlayerControllers = 0x00F0;
		public const int ProximalMaxRange = 0x0100;
		public const int ProximalClampingDistance = 0x0104;
		public const int ProximalDistanceModel = 0x0108;
		public const int UnknownData04 = 0x010C;
	}

	public class UWeaponAnimInfoComponent
	{
		public const int WeaponAttachPointRifle = 0x01E0;
		public const int WeaponAttachPointThrowable = 0x01E8;
		public const int WeaponAttachPointMelee = 0x01F0;
		public const int MeshComponent = 0x01F8;
		public const int CharacterAccessory_Primary = 0x0200;
		public const int CharacterAccessory_Secondary = 0x0208;
		public const int CharacterAccessory_Sidearm = 0x0210;
		public const int CharacterAccessory_Melee = 0x0218;
		public const int CharacterAccessory_Thrown = 0x0220;
		public const int WeaponLeftHandIKAttachPoint = 0x0228;
		public const int UnknownData00 = 0x0230;
	}

	public class UCharacterWeaponAnimInfoComponent
	{
		public const int WeaponAttachPointPistolSitting = 0x0240;
		public const int WeaponAttachPointRifleDriving = 0x0248;
		public const int WeaponAttachPointRifleSitting = 0x0250;
		public const int WeaponAttachPointRifleAim = 0x0258;
		public const int WeaponAttachPointThrowableDriving = 0x0260;
		public const int WeaponAttachPointMeleeDriving = 0x0268;
	}

	public class UWeaponClone
	{
		public const int UnknownData00 = 0x0028;
		public const int ClonedWeapon = 0x0038;
	}

	public class UWeaponsPenetrationConfig
	{
		public const int MaterialConfigOverrides = 0x0080;
		public const int WeaponConfigOverrides = 0x0120;
		public const int DeflectionRange = 0x01C0;
		public const int MaxSurfacesNum = 0x01C4;
		public const int MinImpactAngleDeg = 0x01C8;
		public const int MinDetectableHollowSize = 0x01CC;
		public const int MinOutSpeed = 0x01D0;
		public const int MinWaterSpeed = 0x01D4;
	}

}
