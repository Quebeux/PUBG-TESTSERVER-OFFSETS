/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UActionInputEventHolder
	{
		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class ATslBaseHUD
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int MainUMGHudClass = 0x0498;

		///<summary><![CDATA[TArray<UAkAudioBank * >]]></summary>
		public const int AutoLoadAudioBanks = 0x04A0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x04B0;

		///<summary><![CDATA[TArray<UActionInputEventHolder * >]]></summary>
		public const int ActionInputEventHolderArray = 0x04B8;

		///<summary><![CDATA[TMap<FString,FTslWidgetState>]]></summary>
		public const int WidgetStateMap = 0x04C8;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int UseMouseWidgetStack = 0x0518;

		///<summary><![CDATA[UUserWidget *]]></summary>
		public const int MainUMGHud = 0x0528;

		///<summary><![CDATA[TArray<UBlockInputUserWidget * >]]></summary>
		public const int BlockInputWidgetList = 0x0530;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0540;

	}

	public class AAirborneEjectionArea
	{
		///<summary><![CDATA[USphereComponent *]]></summary>
		public const int SphereComponent = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x03B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03BC;

	}

	public class UAnimDB
	{
		///<summary><![CDATA[FAnimInfo]]></summary>
		public const int Stand_Info = 0x0030;

		///<summary><![CDATA[FAnimInfo]]></summary>
		public const int Crouch_Info = 0x0098;

		///<summary><![CDATA[FAnimInfo]]></summary>
		public const int Prone_Info = 0x0100;

		///<summary><![CDATA[float]]></summary>
		public const int BlendSpaceSpeed_Walk = 0x0168;

		///<summary><![CDATA[float]]></summary>
		public const int BlendSpaceSpeed_Run = 0x016C;

		///<summary><![CDATA[float]]></summary>
		public const int BlendSpaceSpeed_Sprint = 0x0170;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0174;

	}

	public class UAnimNotify_AkEvent_Advanced
	{
		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int AkAudioEvent = 0x0038;

		///<summary><![CDATA[FString]]></summary>
		public const int EventName = 0x0040;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachName = 0x0050;

		///<summary><![CDATA[FVector]]></summary>
		public const int CustomRelativeLocation = 0x0058;

		///<summary><![CDATA[bool]]></summary>
		public const int bFollow = 0x0064;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseMinActivationDistance = 0x0065;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseActivationDistanceByAttenuation = 0x0066;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x0067;

		///<summary><![CDATA[float]]></summary>
		public const int MinActivationDistance = 0x0068;

		///<summary><![CDATA[bool]]></summary>
		public const int bPlayCameraShake = 0x006C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x006D;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CameraShake = 0x0070;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int AffectedCameras = 0x0078;

	}

	public class UAnimNotify_CharacterAnimationNotify
	{
		///<summary><![CDATA[FName]]></summary>
		public const int NotifyName = 0x0038;

	}

	public class UAnimNotify_UnarmedAttack
	{
		///<summary><![CDATA[FName]]></summary>
		public const int NotifyName = 0x0038;

	}

	public class UAnimNotify_WeaponAnimationNotify
	{
		///<summary><![CDATA[FName]]></summary>
		public const int NotifyName = 0x0038;

	}

	public class UAsyncStaticMeshComponent
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnStaticMeshLoaded = 0x09C0;

		///<summary><![CDATA[TAssetPtr<UStaticMesh>]]></summary>
		public const int StaticMeshAsset = 0x09D0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x09F0;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int ErrorStaticMesh = 0x09F8;

		///<summary><![CDATA[FName]]></summary>
		public const int ClientCollisionProfileNameOverride = 0x0A00;

		///<summary><![CDATA[TAssetPtr<UStaticMesh>]]></summary>
		public const int PendingStaticMeshAsset = 0x0A08;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0A28;

	}

	public class UBluezoneInOutComponent
	{
		///<summary><![CDATA[unsigned char[0xE0]]]></summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class UBluezoneInOutSoundEffectComponent
	{
		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int BluezoneInSoundAk = 0x01E0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int BluezoneOutSoundAk = 0x01E8;

	}

	public class UBTDecorator_HasLoSTo
	{
		///<summary><![CDATA[FBlackboardKeySelector]]></summary>
		public const int EnemyKey = 0x0068;

	}

	public class ATslBuff
	{
		///<summary><![CDATA[FName]]></summary>
		public const int OverlapId = 0x03B0;

		///<summary><![CDATA[TEnumAsByte<EBuffOverlapSolveMethod>]]></summary>
		public const int OverlapSolveMethod = 0x03B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03B9;

		///<summary><![CDATA[float]]></summary>
		public const int BuffTickInterval = 0x03BC;

		///<summary><![CDATA[float]]></summary>
		public const int BuffTickFirstDelay = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int BuffDuration = 0x03C4;

		///<summary><![CDATA[bool]]></summary>
		public const int Infinite = 0x03C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03C9;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachSocket = 0x03D0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AttachServerPaticleClass = 0x03D8;

		///<summary><![CDATA[bool]]></summary>
		public const int IsDebuff = 0x03E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x03E1;

		///<summary><![CDATA[UBuffComponet *]]></summary>
		public const int OwnerBuffComponent = 0x03E8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData03 = 0x03F0;

		///<summary><![CDATA[ATslServerParticle *]]></summary>
		public const int AttachedServerPaticle = 0x0400;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0408;

	}

	public class UBuffComponet
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class UCameraSettings
	{
		///<summary><![CDATA[float]]></summary>
		public const int CameraPitchMinStand = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int CameraPitchMaxStand = 0x002C;

		///<summary><![CDATA[float]]></summary>
		public const int CameraYawMinStand = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int CameraYawMaxStand = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int CameraPitchMinProne = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int CameraPitchMaxProne = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int CameraYawMinProne = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int CameraYawMaxProne = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int FPSShowOnHighScopingFOV = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int TPSShowOnHighScopingFOV = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int CameraPitchMinInVehicle = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int CameraPitchMaxInVehicle = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int CameraYawMinInVehicle = 0x0058;

		///<summary><![CDATA[float]]></summary>
		public const int CameraYawMaxInVehicle = 0x005C;

		///<summary><![CDATA[FName]]></summary>
		public const int HeadBoneName = 0x0060;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HideMaterialsWhenCameraIsInHead = 0x0068;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HideMaterialsOnScopeMode = 0x0078;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int HideMaterialsOnHighScopeMode = 0x0088;

	}

	public class UCastComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnCancelCast = 0x01E8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x01F8;

	}

	public class UCharacterBreathComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[float]]></summary>
		public const int Breath = 0x01E8;

		///<summary><![CDATA[float]]></summary>
		public const int BreathMax = 0x01EC;

		///<summary><![CDATA[FVector]]></summary>
		public const int BreathPointOffsetAtStand = 0x01F0;

		///<summary><![CDATA[FVector]]></summary>
		public const int BreathPointOffsetAtCrouch = 0x01FC;

		///<summary><![CDATA[FVector]]></summary>
		public const int BreathPointOffsetAtProne = 0x0208;

		///<summary><![CDATA[FVector]]></summary>
		public const int BreathPointOffsetAtGroggy = 0x0214;

		///<summary><![CDATA[UClass *]]></summary>
		public const int RestorationBuff = 0x0220;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ApneaDebuff = 0x0228;

		///<summary><![CDATA[UClass *]]></summary>
		public const int HoldBreathDebuff = 0x0230;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumBreathStartHoldingBreath = 0x0238;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x023C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SprintDebuff = 0x0240;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumBreathStartSprinting = 0x0248;

		///<summary><![CDATA[unsigned char[0x24]]]></summary>
		public const int UnknownData02 = 0x024C;

	}

	public class ACharacterStudio
	{
		///<summary><![CDATA[USpringArmComponent *]]></summary>
		public const int SpringArmComponent = 0x03B0;

		///<summary><![CDATA[UCameraComponent *]]></summary>
		public const int CameraComponent = 0x03B8;

		///<summary><![CDATA[USceneCaptureComponent2D *]]></summary>
		public const int SceneCaptureComponent = 0x03C0;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int TextureTarget = 0x03C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseDynamicResolution = 0x03D0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03D1;

		///<summary><![CDATA[float]]></summary>
		public const int MaxViewDistance = 0x03D4;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MaleCharacterProxyClass = 0x03D8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FemaleCharacterProxyClass = 0x03E0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03E8;

		///<summary><![CDATA[FTransform]]></summary>
		public const int CharacterInitialTransform = 0x03F0;

		///<summary><![CDATA[ATslCharacterProxy *]]></summary>
		public const int CharacterProxy = 0x0420;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int CharacterRotationPivot = 0x0428;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int SceneCaptureMaterial = 0x0430;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0438;

	}

	public class UCoherentCommonBinder
	{
		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[FString]]></summary>
		public const int DefaultLobbyUrl = 0x0088;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0098;

	}

	public class UCoherentWidgetBinder
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x00A0;

	}

	public class ATslPlayerController
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnShowReplayTimeline = 0x06F0;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x0700;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData01 = 0x0728;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsSpectated = 0x0728;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0729;

		///<summary><![CDATA[FVector]]></summary>
		public const int CameraPeekLeftMove = 0x072C;

		///<summary><![CDATA[FVector]]></summary>
		public const int CameraPeekRightMove = 0x0738;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData03 = 0x0744;

		///<summary><![CDATA[ECameraViewBehaviour]]></summary>
		public const int CameraViewBehaviour = 0x0754;

		///<summary><![CDATA[unsigned char[0x23]]]></summary>
		public const int UnknownData04 = 0x0755;

		///<summary><![CDATA[FVector_NetQuantizeNormal]]></summary>
		public const int SpectatorAccumViewRotation = 0x0778;

		///<summary><![CDATA[EObserverAuthorityType]]></summary>
		public const int ObserverAuthorityType = 0x0784;

		///<summary><![CDATA[unsigned char[0x33]]]></summary>
		public const int UnknownData05 = 0x0785;

		///<summary><![CDATA[UActorComponent *]]></summary>
		public const int InteractionTargetComponent = 0x07B8;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int SpectatorViewCharacter = 0x07C0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData06 = 0x07C8;

		///<summary><![CDATA[ATslAchievement *]]></summary>
		public const int Achievement = 0x07D8;

		///<summary><![CDATA[UMeshComponent *]]></summary>
		public const int SpectatorScopeMesh = 0x07E0;

		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData07 = 0x07E8;

		///<summary><![CDATA[TArray<FNearClippingLevelOverZ>]]></summary>
		public const int NearClippingLevelsOverZ = 0x0840;

		///<summary><![CDATA[float]]></summary>
		public const int MaxValidPing = 0x0850;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultFOV = 0x0854;

		///<summary><![CDATA[float]]></summary>
		public const int InteractGamepadHoldTime = 0x0858;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x085C;

		///<summary><![CDATA[UVivoxComponent *]]></summary>
		public const int VivoxComponent = 0x0860;

		///<summary><![CDATA[TArray<ATeam * >]]></summary>
		public const int Teams = 0x0868;

		///<summary><![CDATA[TArray<TWeakObjectPtr<ATslCharacter>>]]></summary>
		public const int ReplicateTeamMembers = 0x0878;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData09 = 0x0888;

		///<summary><![CDATA[TArray<TWeakObjectPtr<ATslCharacter>>]]></summary>
		public const int ReplicateCharacter = 0x08D8;

		///<summary><![CDATA[TArray<TWeakObjectPtr<ACarePackageItem>>]]></summary>
		public const int ReplicateCarePackageItemList = 0x08E8;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData10 = 0x08F8;

		///<summary><![CDATA[float]]></summary>
		public const int DeathResultDelaySeconds = 0x0918;

		///<summary><![CDATA[unsigned char[0x90]]]></summary>
		public const int UnknownData11 = 0x091C;

		///<summary><![CDATA[FPingPongSummary]]></summary>
		public const int PingPongSummary = 0x09AC;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData12 = 0x09B8;

	}

	public class ADeployedItem
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ItemType = 0x03B0;

		///<summary><![CDATA[int]]></summary>
		public const int StackCount = 0x03B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03BC;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int SceneComponent = 0x03C0;

	}

	public class ASubActor
	{
		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int NetOwnerCharacter = 0x03B0;

	}

	public class AItemSlotContainer
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B8;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnCreateAndShowContextMenuWidget = 0x03C0;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnDestroyContextMenuWidget = 0x03D0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03E0;

	}

	public class AItemExplorer
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03E8;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnUpdateItemList = 0x03F0;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnClearItemList = 0x0400;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0410;

	}

	public class UItem
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bStackable = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUsable = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsConsumable = 0x0038;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDisableSpawnInGame = 0x0038;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0039;

		///<summary><![CDATA[int]]></summary>
		public const int StackCount = 0x003C;

		///<summary><![CDATA[FText]]></summary>
		public const int ItemName = 0x0040;

		///<summary><![CDATA[FText]]></summary>
		public const int ItemCategory = 0x0058;

		///<summary><![CDATA[FText]]></summary>
		public const int ItemDetailedName = 0x0070;

		///<summary><![CDATA[FText]]></summary>
		public const int ItemDescription = 0x0088;

		///<summary><![CDATA[float]]></summary>
		public const int ItemMaxInteractableDistance = 0x00A0;

		///<summary><![CDATA[int]]></summary>
		public const int StackCountMax = 0x00A4;

		///<summary><![CDATA[float]]></summary>
		public const int SpacePerItem = 0x00A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x00AC;

		///<summary><![CDATA[TAssetPtr<UStaticMesh>]]></summary>
		public const int DroppedMesh = 0x00B0;

		///<summary><![CDATA[float]]></summary>
		public const int DroppedMeshScale = 0x00D0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x00D4;

		///<summary><![CDATA[TAssetPtr<UTexture>]]></summary>
		public const int Icon = 0x00D8;

		///<summary><![CDATA[TAssetPtr<UTexture>]]></summary>
		public const int ToolTipIcon = 0x00F8;

		///<summary><![CDATA[float]]></summary>
		public const int IconSizeRatio = 0x0118;

		///<summary><![CDATA[float]]></summary>
		public const int ToolTipIconSizeRatio = 0x011C;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int DropSoundAk = 0x0120;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int PickUpSoundAk = 0x0128;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int InventoryPutSoundAk = 0x0130;

		///<summary><![CDATA[int]]></summary>
		public const int SortPriority = 0x0138;

		///<summary><![CDATA[int]]></summary>
		public const int LobbyItemID = 0x013C;

		///<summary><![CDATA[FLobbyItemDesc]]></summary>
		public const int LobbyItemDesc = 0x0140;

		///<summary><![CDATA[EItemCategory]]></summary>
		public const int Category = 0x0198;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData04 = 0x0199;

		///<summary><![CDATA[FName]]></summary>
		public const int SubCategory = 0x01A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsToy = 0x01A8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x01A9;

		///<summary><![CDATA[FString]]></summary>
		public const int Note = 0x01B0;

	}

	public class AItemPackage
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0418;

		///<summary><![CDATA[FText]]></summary>
		public const int PackageName = 0x0428;

		///<summary><![CDATA[FText]]></summary>
		public const int PackageCategory = 0x0440;

		///<summary><![CDATA[FText]]></summary>
		public const int PackageDetailedName = 0x0458;

		///<summary><![CDATA[FText]]></summary>
		public const int PackageDescription = 0x0470;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int PackageIcon = 0x0488;

		///<summary><![CDATA[float]]></summary>
		public const int PackageIconSizeRatio = 0x0490;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0494;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int PackageToolTipIcon = 0x0498;

		///<summary><![CDATA[float]]></summary>
		public const int PackageToolTipIconSizeRatio = 0x04A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x04A4;

		///<summary><![CDATA[TAssetPtr<UStaticMesh>]]></summary>
		public const int PackageMesh = 0x04A8;

		///<summary><![CDATA[UBoxComponent *]]></summary>
		public const int BoxComponent = 0x04C8;

		///<summary><![CDATA[UOnceInteractionComponent *]]></summary>
		public const int InteractionComponent = 0x04D0;

		///<summary><![CDATA[bool]]></summary>
		public const int DestroyByEmptyItem = 0x04D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x04D9;

		///<summary><![CDATA[TArray<UItem * >]]></summary>
		public const int Items = 0x04E0;

		///<summary><![CDATA[FString]]></summary>
		public const int CreatorName = 0x04F0;

		///<summary><![CDATA[int]]></summary>
		public const int SortPriority = 0x0500;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData04 = 0x0504;

	}

	public class ADeployedItemPackage
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ItemPackageType = 0x03B0;

		///<summary><![CDATA[TArray<FPackagedItemInfo>]]></summary>
		public const int ItemInfos = 0x03B8;

	}

	public class UDoorDataAsset
	{
		///<summary><![CDATA[float]]></summary>
		public const int OpenAngle = 0x0030;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0034;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int OpenCurve = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int OpenCurveDuration = 0x0040;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0044;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CloseCurve = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int CloseCurveDuration = 0x0050;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0054;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int OpenSound = 0x0058;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int CloseSound = 0x0060;

	}

	public class UTslReactionDoorData
	{
		///<summary><![CDATA[float]]></summary>
		public const int PointDamageImpulse = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int PointDamageRadius = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int BreakingRadius = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int BreakingImpulse = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int BreakingMinDamage = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int DamageAccumulateTimeout = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int ZombieDamageAccumulateTimeout = 0x0048;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x004C;

		///<summary><![CDATA[FName]]></summary>
		public const int TopImpactSoketName = 0x0050;

		///<summary><![CDATA[FName]]></summary>
		public const int CenterImpactSoketName = 0x0058;

		///<summary><![CDATA[FName]]></summary>
		public const int BottomImpactSoketName = 0x0060;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int DestructibleSoundAk = 0x0068;

	}

	public class UDoorFrameComponent
	{
		///<summary><![CDATA[FTransform]]></summary>
		public const int DoorTransform = 0x09C0;

		///<summary><![CDATA[FVector]]></summary>
		public const int SoundOffsetFromDoor = 0x09F0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x09FC;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int DoorStaticMesh = 0x0A00;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int DoorDestructibleMesh = 0x0A08;

		///<summary><![CDATA[UDoorDataAsset *]]></summary>
		public const int DoorDataAsset = 0x0A10;

		///<summary><![CDATA[UTslReactionDoorData *]]></summary>
		public const int ReactionDoorData = 0x0A18;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0A20;

	}

	public class ADroppedItem
	{
		///<summary><![CDATA[UItem *]]></summary>
		public const int Item = 0x03B0;

	}

	public class ADroppedItemGridManager
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxGridSize = 0x03B0;

		///<summary><![CDATA[int]]></summary>
		public const int MaxGridLayerNum = 0x03B4;

		///<summary><![CDATA[int]]></summary>
		public const int MaxItemNumPerGroup = 0x03B8;

		///<summary><![CDATA[unsigned char[0xA4]]]></summary>
		public const int UnknownData00 = 0x03BC;

	}

	public class ADroppedItemGroup
	{
		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int RandomSpawnRadius = 0x03B4;

		///<summary><![CDATA[int]]></summary>
		public const int MaxRandomSpawnCount = 0x03B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03BC;

	}

	public class UExportableDataAsset
	{
		///<summary><![CDATA[FDirectoryPath]]></summary>
		public const int JsonSaveDirectory = 0x0030;

		///<summary><![CDATA[FString]]></summary>
		public const int JsonSaveFileName = 0x0040;

	}

	public class ULobbyCustomizableData
	{
		///<summary><![CDATA[TArray<FLobbyFaceElement>]]></summary>
		public const int Faces = 0x0050;

		///<summary><![CDATA[TArray<FLobbyHairElement>]]></summary>
		public const int Hairs = 0x0060;

	}

	public class ULobbyItemExporter
	{
		///<summary><![CDATA[FString]]></summary>
		public const int LocJsonSaveFileName = 0x0050;

	}

	public class AFlashBangCaptureActor
	{
		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int SceneRootComponent = 0x03B0;

		///<summary><![CDATA[USceneCaptureComponent2D *]]></summary>
		public const int SceneCapture = 0x03B8;

		///<summary><![CDATA[APawn *]]></summary>
		public const int PlayerPawnReference = 0x03C0;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int CaptureTexture = 0x03C8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x03D0;

	}

	public class UGameEventObserver
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMatchStarted = 0x0028;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnMatchEnded = 0x0038;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKillOtherPlayer = 0x0048;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDie = 0x0058;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDamage = 0x0068;

	}

	public class UGameStateListenerComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnGameModeEvent = 0x01E8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x01F8;

	}

	public class UTableGeneralItemSpawner
	{
		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawItemSpawnDataTable = 0x0028;

		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawItemSpawnTogetherDataTable = 0x0030;

		///<summary><![CDATA[TArray<FGeneralItemSpawnProb>]]></summary>
		public const int SpawnProbArray = 0x0038;

		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UHackReporterComponent
	{
		///<summary><![CDATA[unsigned char[0x180]]]></summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class UHighlightSession
	{
		///<summary><![CDATA[FHighlightRecordConfig]]></summary>
		public const int Config_Kill = 0x0028;

		///<summary><![CDATA[FHighlightRecordConfig]]></summary>
		public const int Config_KillGroggy = 0x0034;

		///<summary><![CDATA[FHighlightRecordConfig]]></summary>
		public const int Config_Die = 0x0040;

		///<summary><![CDATA[FHighlightRecordConfig]]></summary>
		public const int Config_DieGroggy = 0x004C;

		///<summary><![CDATA[FHighlightRecordConfig]]></summary>
		public const int Config_EndMatch = 0x0058;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0064;

		///<summary><![CDATA[ATslHUD *]]></summary>
		public const int TslHUD = 0x0068;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData01 = 0x0070;

	}

	public class UInteractionComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxInteractableDistance = 0x01E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01EC;

		///<summary><![CDATA[FText]]></summary>
		public const int InteractionVerb = 0x01F0;

		///<summary><![CDATA[FText]]></summary>
		public const int InteractiveObjectName = 0x0208;

		///<summary><![CDATA[FCastConfig]]></summary>
		public const int CastConfig = 0x0220;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseTraceCheck = 0x0250;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0251;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInteractBy = 0x0258;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ClientOnInteractBy = 0x0268;

		///<summary><![CDATA[unsigned char[0xE8]]]></summary>
		public const int UnknownData03 = 0x0278;

	}

	public class UDoublePhaseInteractionComponent
	{
		///<summary><![CDATA[FText]]></summary>
		public const int FirstInteractionVerb = 0x0360;

		///<summary><![CDATA[FText]]></summary>
		public const int FirstInteractiveObjectName = 0x0378;

		///<summary><![CDATA[FText]]></summary>
		public const int SecondInteractionVerb = 0x0390;

		///<summary><![CDATA[FText]]></summary>
		public const int SecondInteractiveObjectName = 0x03A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnSecondInteractBy = 0x03C0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ClientOnSecondInteractBy = 0x03D0;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x03E0;

	}

	public class UDroppedItemActorComponent
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0360;

	}

	public class UOnceInteractionComponent
	{
		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int CharacterHistory = 0x0360;

	}

	public class UAmmoItem
	{
		///<summary><![CDATA[UTexture *]]></summary>
		public const int AmmoIcon = 0x01C0;

		///<summary><![CDATA[float]]></summary>
		public const int AmmoIconRatio = 0x01C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x01CC;

	}

	public class UAttachableItem
	{
		///<summary><![CDATA[FWeaponAttachmentData]]></summary>
		public const int AttachmentData = 0x01C0;

		///<summary><![CDATA[TAssetPtr<UStaticMesh>]]></summary>
		public const int AttachmentMeshAsset = 0x03A8;

		///<summary><![CDATA[TArray<FWeaponAttachmentWeaponTagData>]]></summary>
		public const int AttachmentWeaponTagData = 0x03C8;

		///<summary><![CDATA[bool]]></summary>
		public const int EquipOnPickUp = 0x03D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03D9;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int AttachedSoundAk = 0x03E0;

	}

	public class UCastableItem
	{
		///<summary><![CDATA[FCastConfig]]></summary>
		public const int CastConfig = 0x01C0;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanUseInWater = 0x01F0;

		///<summary><![CDATA[ECastableItemType]]></summary>
		public const int CastableItemType = 0x01F1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x01F2;

	}

	public class UInstantHealItem
	{
		///<summary><![CDATA[float]]></summary>
		public const int HealLimit = 0x01F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x01FC;

	}

	public class USkinItem
	{
		///<summary><![CDATA[FSkinData]]></summary>
		public const int SkinData = 0x01F8;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoAction = 0x0218;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0219;

	}

	public class UEquipableItem
	{
		///<summary><![CDATA[EEquipSlotID]]></summary>
		public const int EquipSlotID = 0x01C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x01C1;

		///<summary><![CDATA[float]]></summary>
		public const int SpaceExtension = 0x01C4;

		///<summary><![CDATA[float]]></summary>
		public const int DamageReductionRate = 0x01C8;

		///<summary><![CDATA[float]]></summary>
		public const int DurabilityMax = 0x01CC;

		///<summary><![CDATA[bool]]></summary>
		public const int DestroyByDurability = 0x01D0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x01D1;

		///<summary><![CDATA[float]]></summary>
		public const int Durability = 0x01D4;

		///<summary><![CDATA[EDurabilityConsumeType]]></summary>
		public const int DurabilityConsumeType = 0x01D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x01D9;

		///<summary><![CDATA[FCustomizableObjectIdentifier]]></summary>
		public const int CustomizableObjectIdentifierForMale = 0x01E0;

		///<summary><![CDATA[FCustomizableObjectIdentifier]]></summary>
		public const int CustomizableObjectIdentifierForFemale = 0x0210;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int EquipedSoundAk = 0x0240;

		///<summary><![CDATA[EEquipableItemSoundGroup]]></summary>
		public const int SoundGroup = 0x0248;

		///<summary><![CDATA[EEquipableItemSoundType]]></summary>
		public const int SoundType = 0x0249;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanZombieEquip = 0x024A;

		///<summary><![CDATA[ESlotOffsetType]]></summary>
		public const int SlotOffsetType = 0x024B;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsUnequipable = 0x024C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x024D;

		///<summary><![CDATA[TAssetPtr<UTexture>]]></summary>
		public const int HudDisplayEquipIcon = 0x0250;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0270;

	}

	public class UCustomEquipableItem
	{
		///<summary><![CDATA[int]]></summary>
		public const int ItemLevel = 0x0278;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x027C;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotOffset_Primary = 0x0280;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotOffset_Secondary = 0x02B0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotOffset_SideArm = 0x02E0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotOffset_Melee = 0x0310;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotOffset_Thrown = 0x0340;

	}

	public class UParachuteItem
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ParachuteType = 0x0278;

	}

	public class UThrowableItem
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0278;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WeaponType = 0x0280;

		///<summary><![CDATA[ATslWeapon *]]></summary>
		public const int EquippedWeapon = 0x0288;

	}

	public class ATslWeapon
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int WeaponIcon = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponIconRatio = 0x03C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03CC;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int PrimaryIcon = 0x03D0;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int SecondaryIcon = 0x03E8;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int PrimaryClipIcon = 0x0400;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int SecondaryClipIcon = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int AmmoIconsCount = 0x0430;

		///<summary><![CDATA[int]]></summary>
		public const int PrimaryClipIconOffset = 0x0434;

		///<summary><![CDATA[int]]></summary>
		public const int SecondaryClipIconOffset = 0x0438;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x043C;

		///<summary><![CDATA[FCanvasIcon[0x5]]]></summary>
		public const int Crosshair = 0x0440;

		///<summary><![CDATA[FCanvasIcon[0x5]]]></summary>
		public const int AimingCrosshair = 0x04B8;

		///<summary><![CDATA[bool]]></summary>
		public const int UseLaserDot = 0x0530;

		///<summary><![CDATA[bool]]></summary>
		public const int UseCustomCrosshair = 0x0531;

		///<summary><![CDATA[bool]]></summary>
		public const int UseCustomAimingCrosshair = 0x0532;

		///<summary><![CDATA[bool]]></summary>
		public const int bHideCrosshairWhileNotAiming = 0x0533;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x0534;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnUpdatedAttachment = 0x0538;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int MyPawn = 0x0548;

		///<summary><![CDATA[FWeaponData]]></summary>
		public const int WeaponConfig = 0x0550;

		///<summary><![CDATA[TEnumAsByte<EWeaponHand>]]></summary>
		public const int WeaponHand = 0x05E8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData04 = 0x05E9;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int Mesh3P = 0x05F0;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int RootScene = 0x05F8;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData05 = 0x0600;

		///<summary><![CDATA[TEnumAsByte<EAttachmentCalculateType>]]></summary>
		public const int AttachmentAniRateCalculateType = 0x0601;

		///<summary><![CDATA[TEnumAsByte<EAttachmentCalculateType>]]></summary>
		public const int AttachmentRecoilPatternScaleCalculateType = 0x0602;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData06 = 0x0603;

		///<summary><![CDATA[TArray<FWeaponAttachmentPositionData>]]></summary>
		public const int AttachmentPositionData = 0x0608;

		///<summary><![CDATA[TArray<FWeaponAttachmentAssetData>]]></summary>
		public const int DefaultAttachedItemAssets = 0x0618;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int AttachedItemClasses = 0x0628;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponTag = 0x0638;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData07 = 0x0640;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkComponent = 0x06A8;

		///<summary><![CDATA[FName]]></summary>
		public const int MuzzleAttachPoint = 0x06B0;

		///<summary><![CDATA[FName]]></summary>
		public const int FiringAttachPoint = 0x06B8;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int MuzzleFx = 0x06C0;

		///<summary><![CDATA[FName]]></summary>
		public const int ShellFxAttachPoint = 0x06C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ShellFxClass = 0x06D0;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int MuzzlePSC = 0x06D8;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int MuzzlePSCSecondary = 0x06E0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FireCameraShake = 0x06E8;

		///<summary><![CDATA[UForceFeedbackEffect *]]></summary>
		public const int FireForceFeedback = 0x06F0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int FireSoundAk = 0x06F8;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int FireLoopSoundAk = 0x0700;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int FireFinishSoundAk = 0x0708;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int OutOfAmmoSoundAk = 0x0710;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ReloadSoundAk = 0x0718;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int EquipSoundAk = 0x0720;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int UnequipSoundAk = 0x0728;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int AimingStartSoundAk = 0x0730;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int AimingFinishSoundAk = 0x0738;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ScopingStartSoundAk = 0x0740;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ScopingFinishSoundAk = 0x0748;

		///<summary><![CDATA[TEnumAsByte<EAnimWeaponType>]]></summary>
		public const int AnimWeaponType = 0x0750;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData08 = 0x0751;

		///<summary><![CDATA[FWeaponBasicAnim]]></summary>
		public const int WeaponAnim = 0x0758;

		///<summary><![CDATA[FWeaponRollAnim]]></summary>
		public const int ProneRollAnim = 0x0770;

		///<summary><![CDATA[float]]></summary>
		public const int HipDuration = 0x0780;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoopedMuzzleFX = 0x0784;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bLoopedFireSound = 0x0784;

		///<summary><![CDATA[unsigned char[0x33]]]></summary>
		public const int UnknownData09 = 0x0785;

		///<summary><![CDATA[FSkinData]]></summary>
		public const int SkinData = 0x07B8;

	}

	public class UWeaponItem
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0278;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WeaponType = 0x0280;

		///<summary><![CDATA[int]]></summary>
		public const int AmmoCount = 0x0288;

		///<summary><![CDATA[int]]></summary>
		public const int AmmoPerClip = 0x028C;

		///<summary><![CDATA[TArray<FWeaponAttachmentTagData>]]></summary>
		public const int AttachmentTagData = 0x0290;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponTag = 0x02A0;

		///<summary><![CDATA[TArray<UAttachableItem * >]]></summary>
		public const int AttachedItems = 0x02A8;

		///<summary><![CDATA[EFiringMode]]></summary>
		public const int FiringMode = 0x02B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x02B9;

		///<summary><![CDATA[ATslWeapon *]]></summary>
		public const int EquippedWeapon = 0x02C0;

	}

	public class URandomlyGeneratableItem
	{
		///<summary><![CDATA[FString]]></summary>
		public const int RandomExpression = 0x01C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOpenByKey = 0x01D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bOpenByPoint = 0x01D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x01D1;

		///<summary><![CDATA[TAssetPtr<UClass>]]></summary>
		public const int OpenKeyItem = 0x01D8;

		///<summary><![CDATA[int]]></summary>
		public const int OpenKeyItemCount = 0x01F8;

		///<summary><![CDATA[int]]></summary>
		public const int PointOpenPrice = 0x01FC;

		///<summary><![CDATA[int]]></summary>
		public const int ExchangeBundleId = 0x0200;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0204;

		///<summary><![CDATA[TArray<FLobbyItemBundle>]]></summary>
		public const int BundleList = 0x0208;

		///<summary><![CDATA[TArray<TAssetPtr<UClass>>]]></summary>
		public const int ReferenceItems = 0x0218;

	}

	public class UItemSpawnProcessor
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USpawnTableItemSpawnProcessor
	{
		///<summary><![CDATA[TArray<FItemSpotGroupTypeProperty>]]></summary>
		public const int RawSpotGroupProperties = 0x0038;

		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawItemSpawnDataTable = 0x0048;

		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawItemSpawnTogetherDataTable = 0x0050;

		///<summary><![CDATA[unsigned char[0xEB8]]]></summary>
		public const int UnknownData00 = 0x0058;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseActorSpawn = 0x0F10;

		///<summary><![CDATA[unsigned char[0x57]]]></summary>
		public const int UnknownData01 = 0x0F11;

	}

	public class AItemSpot
	{
		///<summary><![CDATA[UItemSpotGroupComponent *]]></summary>
		public const int SpotGroupComponent = 0x03B0;

	}

	public class UItemSpotComponent
	{
		///<summary><![CDATA[EItemSpotType]]></summary>
		public const int ItemSpotType = 0x03E0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x03E1;

	}

	public class UItemSpotGroupComponent
	{
		///<summary><![CDATA[EItemSpotGroupType]]></summary>
		public const int SpotGroupType = 0x03E0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData00 = 0x03E1;

	}

	public class AItemStudio
	{
		///<summary><![CDATA[FName]]></summary>
		public const int CameraSocketName = 0x03B0;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int TextureTarget = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int MaxViewDistance = 0x03C0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03C4;

		///<summary><![CDATA[UCameraComponent *]]></summary>
		public const int CameraComponent = 0x03C8;

		///<summary><![CDATA[USceneCaptureComponent2D *]]></summary>
		public const int SceneCaptureComponent = 0x03D0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03D8;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultCameraSocketTransform = 0x03E0;

	}

	public class ALevelAttribute
	{
		///<summary><![CDATA[int]]></summary>
		public const int NumMapBlock = 0x03B0;

		///<summary><![CDATA[FBox2D]]></summary>
		public const int MapRect2D = 0x03B4;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MapImageMaterial = 0x03C8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03D0;

	}

	public class ULobbyItemBundleIdPublisher
	{
		///<summary><![CDATA[FString]]></summary>
		public const int LobbyItemPath = 0x0028;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0038;

	}

	public class ULobbyLink
	{
		///<summary><![CDATA[unsigned char[0xA8]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UMatchPreparer
	{
		///<summary><![CDATA[int]]></summary>
		public const int WarmupTime = 0x0028;

		///<summary><![CDATA[int]]></summary>
		public const int WarmupTimeInPIE = 0x002C;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UAirborneMatchPreparer
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int AircraftClass = 0x0058;

		///<summary><![CDATA[TArray<ATransportAircraftVehicle * >]]></summary>
		public const int Aircrafts = 0x0060;

		///<summary><![CDATA[int]]></summary>
		public const int AircraftCount = 0x0070;

		///<summary><![CDATA[int]]></summary>
		public const int AircraftCapacityOverride = 0x0074;

		///<summary><![CDATA[float]]></summary>
		public const int AircraftAltitude = 0x0078;

		///<summary><![CDATA[float]]></summary>
		public const int EndThetaDegree = 0x007C;

		///<summary><![CDATA[float]]></summary>
		public const int AircraftIntervalDistance = 0x0080;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData00 = 0x0084;

	}

	public class UNormalMatchPreparer
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0058;

		///<summary><![CDATA[int]]></summary>
		public const int AvailablePlayerStartCount = 0x0068;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x006C;

	}

	public class UMaterialMergeSettings
	{
		///<summary><![CDATA[unsigned char[0x58]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int MasterMaterial = 0x0080;

		///<summary><![CDATA[UMaterial *]]></summary>
		public const int MergedMaterial = 0x0088;

		///<summary><![CDATA[TArray<FMaterialMergerParameters>]]></summary>
		public const int ParameterList = 0x0090;

		///<summary><![CDATA[bool]]></summary>
		public const int bUpdateParameterList = 0x00A0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x00A1;

	}

	public class ABattleRoyaleModeController
	{
		///<summary><![CDATA[TArray<FBattleRoyalePoisionGasData>]]></summary>
		public const int NormalPoisonGasDataArray = 0x04A8;

		///<summary><![CDATA[TArray<FBattleRoyalePoisionGasData>]]></summary>
		public const int FastPoisonGasDataArray = 0x04B8;

		///<summary><![CDATA[int]]></summary>
		public const int FastZonePlayerCount = 0x04C8;

		///<summary><![CDATA[float]]></summary>
		public const int BattleRoyaleZoneTypeCheckTime = 0x04CC;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int PoisonWarningTime = 0x04D0;

		///<summary><![CDATA[float]]></summary>
		public const int WaterVolumeRayHeight = 0x04E0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x04E4;

		///<summary><![CDATA[TArray<ATslPhysicsVolume * >]]></summary>
		public const int OceanPhysicsVolume = 0x04F0;

		///<summary><![CDATA[TArray<ATslPassBluezoneArea * >]]></summary>
		public const int PassBluezoneAreas = 0x0500;

		///<summary><![CDATA[TArray<ATslPassBlueZoneAreaRectangle * >]]></summary>
		public const int PassBluezoneAreasRectangle = 0x0510;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0520;

	}

	public class ACarePackageController
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int AircraftCarePackageClass = 0x04A8;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StartDelay = 0x04B0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int SpawnInterval = 0x04B8;

		///<summary><![CDATA[float]]></summary>
		public const int FlyingHeight = 0x04C0;

		///<summary><![CDATA[float]]></summary>
		public const int CarePackageLifeTime = 0x04C4;

		///<summary><![CDATA[float]]></summary>
		public const int WhiteZoneSpawnInnerRate = 0x04C8;

		///<summary><![CDATA[float]]></summary>
		public const int DropAreaRate = 0x04CC;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x04D0;

	}

	public class ARedZoneController
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int BombTemplateClass = 0x04A8;

		///<summary><![CDATA[float]]></summary>
		public const int StartDelay = 0x04B0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int NextCreateRedZoneInterval = 0x04B4;

		///<summary><![CDATA[float]]></summary>
		public const int BombingDelay = 0x04BC;

		///<summary><![CDATA[float]]></summary>
		public const int BombingSoundDelay = 0x04C0;

		///<summary><![CDATA[float]]></summary>
		public const int OuterRadius = 0x04C4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int LimitExceptExplosionRadius = 0x04C8;

		///<summary><![CDATA[float]]></summary>
		public const int ExceptExplosionRadius = 0x04D0;

		///<summary><![CDATA[float]]></summary>
		public const int BombProjectileDelayTime = 0x04D4;

		///<summary><![CDATA[float]]></summary>
		public const int RedZoneDuration = 0x04D8;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int BombingInterval = 0x04DC;

		///<summary><![CDATA[float]]></summary>
		public const int RedZoneLifeTime = 0x04E4;

		///<summary><![CDATA[float]]></summary>
		public const int ReyStartHeight = 0x04E8;

		///<summary><![CDATA[float]]></summary>
		public const int RedZoneRadiusOffsetRate = 0x04EC;

		///<summary><![CDATA[FText]]></summary>
		public const int RedZoneStartText = 0x04F0;

		///<summary><![CDATA[int]]></summary>
		public const int RedZoneProjectileCount = 0x0508;

		///<summary><![CDATA[bool]]></summary>
		public const int bFGSquircularMapping = 0x050C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x050D;

		///<summary><![CDATA[float]]></summary>
		public const int RayCheckAroundLength = 0x0510;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0514;

		///<summary><![CDATA[UClass *]]></summary>
		public const int BeginServerPaticleClass = 0x0518;

		///<summary><![CDATA[ATslServerParticle *]]></summary>
		public const int BeginServerPaticle = 0x0520;

		///<summary><![CDATA[float]]></summary>
		public const int BeginSoundDelay = 0x0528;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData02 = 0x052C;

		///<summary><![CDATA[TArray<ATslPhysicsVolume * >]]></summary>
		public const int OceanPhysicsVolume = 0x0540;

	}

	public class AMutableCharacter
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x07E0;

		///<summary><![CDATA[EGender]]></summary>
		public const int Gender = 0x0800;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0801;

		///<summary><![CDATA[UCustomizableObjectInstance *]]></summary>
		public const int CustomizableObjectInstance = 0x0808;

		///<summary><![CDATA[UTslCustomizableSkeletalComponent *]]></summary>
		public const int CustomizableSkeletalComponent = 0x0810;

		///<summary><![CDATA[TArray<unsigned char>]]></summary>
		public const int InstanceDescriptor = 0x0818;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0828;

	}

	public class ALobbyCharacter
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0830;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnHost = 0x0838;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnLobbySceneChanged = 0x0848;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bHasJacket = 0x0858;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsReady = 0x0858;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsHost = 0x0858;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsInCustomizationScene = 0x0858;

		///<summary><![CDATA[unsigned char[0x37]]]></summary>
		public const int UnknownData01 = 0x0859;

	}

	public class ATslVaultingHelper
	{
		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int RootSceneComponent = 0x03B0;

		///<summary><![CDATA[USceneComponent *]]></summary>
		public const int ActorAttachScene = 0x03B8;

	}

	public class ATslWeapon_Gun
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bSpawnBulletFromBarrel = 0x07D8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x07D9;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int VariableZoomStepAk = 0x07E0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ZeroingStepAk = 0x07E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x07F0;

		///<summary><![CDATA[int]]></summary>
		public const int AmmoPerClip = 0x07F4;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentAmmoInClip = 0x07F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsHipped = 0x07FC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x07FD;

		///<summary><![CDATA[float]]></summary>
		public const int TimeBetweenShots = 0x0800;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData03 = 0x0804;

		///<summary><![CDATA[int]]></summary>
		public const int FiringModeIndex = 0x082C;

		///<summary><![CDATA[unsigned char[0x88]]]></summary>
		public const int UnknownData04 = 0x0830;

		///<summary><![CDATA[FWeaponGunData]]></summary>
		public const int WeaponGunConfig = 0x08B8;

		///<summary><![CDATA[FWeaponDeviationData]]></summary>
		public const int WeaponDeviationConfig = 0x0948;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData05 = 0x098C;

		///<summary><![CDATA[FWeaponGunAnim]]></summary>
		public const int WeaponGunAnim = 0x0990;

		///<summary><![CDATA[FWeaponPPSettings]]></summary>
		public const int WeaponGunPostprocessSettings = 0x0A80;

		///<summary><![CDATA[FName]]></summary>
		public const int ScopingAttachPoint = 0x0AD0;

		///<summary><![CDATA[FName]]></summary>
		public const int ScopingFocusPoint = 0x0AD8;

	}

	public class AVehicleSeatActor
	{
		///<summary><![CDATA[float]]></summary>
		public const int ViewPitchMin = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int ViewPitchMax = 0x03B4;

		///<summary><![CDATA[float]]></summary>
		public const int ViewYawMin = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int ViewYawMax = 0x03BC;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CurvePitchMax = 0x03C0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CurvePitchMin = 0x03C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanOnlyFireWhileAiming = 0x03D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03D1;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int SeatBlendspaceAiming = 0x03D8;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int SeatAnimationIdle = 0x03E0;

		///<summary><![CDATA[UAimOffsetBlendSpace *]]></summary>
		public const int SeatIdleAO = 0x03E8;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int TransitionOutBlendspace = 0x03F0;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int TransitionInBlendspace = 0x03F8;

		///<summary><![CDATA[bool]]></summary>
		public const int bRestricWeaponUse = 0x0400;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0401;

		///<summary><![CDATA[TArray<EWeaponClass>]]></summary>
		public const int AllowedWeaponClasses = 0x0408;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseEntryVelocityRestriction = 0x0418;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0419;

		///<summary><![CDATA[float]]></summary>
		public const int MaxVelocityForEntry = 0x041C;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int Rider = 0x0420;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData03 = 0x0428;

		///<summary><![CDATA[EVehicleAnimType]]></summary>
		public const int SeatAnimationType = 0x0434;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0435;

	}

	public class AWeaponProcessor
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnWeaponProcessorArmed = 0x03B8;

		///<summary><![CDATA[unsigned char[0x80]]]></summary>
		public const int UnknownData01 = 0x03C8;

		///<summary><![CDATA[TArray<ATslWeapon * >]]></summary>
		public const int EquippedWeapons = 0x0448;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentWeaponIndex = 0x0458;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData02 = 0x045C;

	}

	public class UVaultingData
	{
		///<summary><![CDATA[float]]></summary>
		public const int LocationStartNormalScale = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int LocationStartZOffset = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int LocationEndNormalScale = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int LocationEndZOffset = 0x003C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsClimb = 0x0040;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsSlide = 0x0041;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0042;

		///<summary><![CDATA[float]]></summary>
		public const int VaultInitialTimer = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int ApexAdditiveStartTime = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int ApexAdditiveEndTime = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int PreApexSpeedScale = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int PostApexSpeedScale = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int VaultEndToFallTimerCutoff = 0x0058;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StartCutoffByDistance_InMap = 0x005C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StartCutoffByDistance_OutMap = 0x0064;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StartCutoffBySpeed_InMap = 0x006C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StartCutoffBySpeed_OutMap = 0x0074;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int PlayrateBySpeed_InMap_PreApex = 0x007C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int PlayrateBySpeed_OutMap_PreApex = 0x0084;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int PlayrateBySpeed_InMap_PostApex = 0x008C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int PlayrateBySpeed_OutMap_PostApex = 0x0094;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x009C;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int AnimationSequence = 0x00A0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int AnimationCurve = 0x00A8;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int CharLocationInterpSpeedInMap = 0x00B0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int CharLocationInterpSpeedOutMap = 0x00B8;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int TimerProgressionByDistanceInMap = 0x00C0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int TimerProgressionByDistanceOutMap = 0x00C8;

		///<summary><![CDATA[float]]></summary>
		public const int TimerProgressionVTimerMax = 0x00D0;

		///<summary><![CDATA[float]]></summary>
		public const int VaultEndTimerNormal = 0x00D4;

		///<summary><![CDATA[float]]></summary>
		public const int VaultEndTimerFall = 0x00D8;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterPostVaultVelocityScalar = 0x00DC;

		///<summary><![CDATA[FVector]]></summary>
		public const int CharacterPostVaultVelocityScalarVector = 0x00E0;

		///<summary><![CDATA[FVector]]></summary>
		public const int CharacterPostVaultVelocityScalarVector_ToFall = 0x00EC;

		///<summary><![CDATA[float]]></summary>
		public const int AnimBlendInTime = 0x00F8;

		///<summary><![CDATA[float]]></summary>
		public const int AnimBlendOutTime = 0x00FC;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanVaultWithWeapon = 0x0100;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsCancellable = 0x0101;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x0102;

		///<summary><![CDATA[float]]></summary>
		public const int MinCancelVTimer = 0x0104;

		///<summary><![CDATA[float]]></summary>
		public const int MaxCancelVTimer = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int TaskEndVTimer = 0x010C;

		///<summary><![CDATA[float]]></summary>
		public const int PostVaultTimerProgressionScale = 0x0110;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseStaticVTimerDampening = 0x0114;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseMappedVTimerDampening = 0x0115;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData03 = 0x0116;

		///<summary><![CDATA[float]]></summary>
		public const int StaticDampeningScalar = 0x0118;

		///<summary><![CDATA[float]]></summary>
		public const int StaticDampeningVTimerMax = 0x011C;

		///<summary><![CDATA[float]]></summary>
		public const int MappedDampeningScalar = 0x0120;

		///<summary><![CDATA[float]]></summary>
		public const int MappedDampeningVTimerMax = 0x0124;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseCustomApexForTimer = 0x0128;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0129;

		///<summary><![CDATA[float]]></summary>
		public const int CustomApex = 0x012C;

	}

	public class ATslCharacter
	{
		///<summary><![CDATA[UTslPawnInputBindingComponent *]]></summary>
		public const int TslPawnInputBindingComponent = 0x0830;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int TimerHandle_Targeting_HoldADS = 0x0838;

		///<summary><![CDATA[bool]]></summary>
		public const int bShouldAiming = 0x0840;

		///<summary><![CDATA[bool]]></summary>
		public const int bPeekLeftToggled = 0x0841;

		///<summary><![CDATA[bool]]></summary>
		public const int bPeekRightToggled = 0x0842;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x0843;

		///<summary><![CDATA[TWeakObjectPtr<ATslPlayerState>]]></summary>
		public const int CurrentAttackerPlayerState = 0x0844;

		///<summary><![CDATA[TWeakObjectPtr<ATslPlayerState>]]></summary>
		public const int LastAttackedPlayerState = 0x084C;

		///<summary><![CDATA[unsigned char[0x4C]]]></summary>
		public const int UnknownData01 = 0x0854;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int NoBagSpaceDelgate = 0x08A0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x08B0;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData03 = 0x0908;

		///<summary><![CDATA[AController *]]></summary>
		public const int LastPossessedController = 0x0950;

		///<summary><![CDATA[TArray<UAkAudioBank * >]]></summary>
		public const int Banks = 0x0958;

		///<summary><![CDATA[UBuffComponet *]]></summary>
		public const int BuffComponent = 0x0968;

		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData04 = 0x0970;

		///<summary><![CDATA[ECastAnim]]></summary>
		public const int Remote_CastAnim = 0x09B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x09B1;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int RevivingCharacter = 0x09B8;

		///<summary><![CDATA[ATslPlayerState *]]></summary>
		public const int GroggyPlayerInstigator = 0x09C0;

		///<summary><![CDATA[TMap<UCameraComponent *,float>]]></summary>
		public const int SavedCameraFOV = 0x09C8;

		///<summary><![CDATA[UCameraComponent *]]></summary>
		public const int SavedCamera = 0x0A18;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData06 = 0x0A20;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentVariableZoomLevel = 0x0A40;

		///<summary><![CDATA[float]]></summary>
		public const int BuffFinalSpreadFactor = 0x0A44;

		///<summary><![CDATA[AInventoryFacade *]]></summary>
		public const int InventoryFacade = 0x0A48;

		///<summary><![CDATA[AWeaponProcessor *]]></summary>
		public const int WeaponProcessor = 0x0A50;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int CharacterState = 0x0A58;

		///<summary><![CDATA[unsigned char[0x1F]]]></summary>
		public const int UnknownData07 = 0x0A59;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DropPackageType = 0x0A78;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int SoundClearAk = 0x0A80;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int RemoteVolumeControlOn = 0x0A88;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int RemoteVolumeControlOff = 0x0A90;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CameraFovRatioCurve = 0x0A98;

		///<summary><![CDATA[float]]></summary>
		public const int HeavyFallVerticalVelocityThreshold = 0x0AA0;

		///<summary><![CDATA[float]]></summary>
		public const int ExtremeFallVerticalVelocityThreshold = 0x0AA4;

		///<summary><![CDATA[float]]></summary>
		public const int ProneFallVerticalVelocityThreshold = 0x0AA8;

		///<summary><![CDATA[float]]></summary>
		public const int HeavyFallMovementStopTime = 0x0AAC;

		///<summary><![CDATA[float]]></summary>
		public const int ExtremeFallMovementStopTime = 0x0AB0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x0AB4;

		///<summary><![CDATA[float]]></summary>
		public const int Punch_Damage = 0x0AB8;

		///<summary><![CDATA[float]]></summary>
		public const int PunchHeavy_Damage = 0x0ABC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int UnarmedDamageType = 0x0AC0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ZombieDamageType = 0x0AC8;

		///<summary><![CDATA[float]]></summary>
		public const int Punch_Distance = 0x0AD0;

		///<summary><![CDATA[float]]></summary>
		public const int PunchHeavy_Distance = 0x0AD4;

		///<summary><![CDATA[float]]></summary>
		public const int Punch_Radius = 0x0AD8;

		///<summary><![CDATA[float]]></summary>
		public const int PunchHeavy_Radius = 0x0ADC;

		///<summary><![CDATA[FVector]]></summary>
		public const int Punch_InitialLocation = 0x0AE0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData09 = 0x0AEC;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeanLeftTraceOffset = 0x0AF0;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeanRightTraceOffset = 0x0AFC;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData10 = 0x0B08;

		///<summary><![CDATA[float]]></summary>
		public const int LeanOffset_Stand = 0x0B10;

		///<summary><![CDATA[float]]></summary>
		public const int LeanOffset_Crouch = 0x0B14;

		///<summary><![CDATA[float]]></summary>
		public const int LeanOffset_Prone = 0x0B18;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData11 = 0x0B1C;

		///<summary><![CDATA[float]]></summary>
		public const int Sprint_MaxSpeed = 0x0B2C;

		///<summary><![CDATA[float]]></summary>
		public const int Sprint_MinSpeed = 0x0B30;

		///<summary><![CDATA[float]]></summary>
		public const int SprintingFOV = 0x0B34;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumBreathToHold = 0x0B38;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData12 = 0x0B3C;

		///<summary><![CDATA[FName]]></summary>
		public const int SwimPoint = 0x0B40;

		///<summary><![CDATA[float]]></summary>
		public const int SwimableWaterDepth = 0x0B48;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchWaterDepth = 0x0B4C;

		///<summary><![CDATA[float]]></summary>
		public const int ProneWaterDepth = 0x0B50;

		///<summary><![CDATA[float]]></summary>
		public const int WaterFloorDetectionLength = 0x0B54;

		///<summary><![CDATA[float]]></summary>
		public const int SwimMaxControllerPitch = 0x0B58;

		///<summary><![CDATA[float]]></summary>
		public const int UnderwaterSwimGapFromSurface = 0x0B5C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SwimTrailEffectClass = 0x0B60;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int SwimTrailEffect = 0x0B68;

		///<summary><![CDATA[FName]]></summary>
		public const int ParticleSocket_SwimIdleRipple = 0x0B70;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SwimIdleRippleEffectClass = 0x0B78;

		///<summary><![CDATA[int]]></summary>
		public const int maxNumSwimIdleRippleEffect = 0x0B80;

		///<summary><![CDATA[float]]></summary>
		public const int SwimIdleRippleOffsetFromSurface = 0x0B84;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData13 = 0x0B88;

		///<summary><![CDATA[UCharacterBreathComponent *]]></summary>
		public const int BreathComponent = 0x0BA0;

		///<summary><![CDATA[FName]]></summary>
		public const int BreathPoint = 0x0BA8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int UnderwaterChokeEffectClass = 0x0BB0;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int UnderwaterChokeEffect = 0x0BB8;

		///<summary><![CDATA[float]]></summary>
		public const int IndoorCheckDistance = 0x0BC0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData14 = 0x0BC4;

		///<summary><![CDATA[float]]></summary>
		public const int IndoorCheckHalfConeAngle = 0x0BC8;

		///<summary><![CDATA[float]]></summary>
		public const int IndoorCheckSuccessRate = 0x0BCC;

		///<summary><![CDATA[int]]></summary>
		public const int IndoorCheckSamplingQueueSize = 0x0BD0;

		///<summary><![CDATA[int]]></summary>
		public const int IndoorCheckAccuracyMultiplier = 0x0BD4;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData15 = 0x0BD8;

		///<summary><![CDATA[float]]></summary>
		public const int FootSoundObstructionCheckInterval = 0x0BE8;

		///<summary><![CDATA[float]]></summary>
		public const int FootSoundObstructionCheckMaxDistance = 0x0BEC;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData16 = 0x0BF0;

		///<summary><![CDATA[FName]]></summary>
		public const int ParachuteAttachPoint = 0x0BF8;

		///<summary><![CDATA[float]]></summary>
		public const int ReleasingParachuteAltitude = 0x0C00;

		///<summary><![CDATA[float]]></summary>
		public const int ForceReleasingParachuteAltitude = 0x0C04;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumParachuteAltitude = 0x0C08;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData17 = 0x0C0C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ParachuteType = 0x0C10;

		///<summary><![CDATA[bool]]></summary>
		public const int bParachuteLandingAssist = 0x0C18;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData18 = 0x0C19;

		///<summary><![CDATA[UCastComponent *]]></summary>
		public const int CastComponent = 0x0C20;

		///<summary><![CDATA[UStanceComponent *]]></summary>
		public const int StanceComponent = 0x0C28;

		///<summary><![CDATA[UHackReporterComponent *]]></summary>
		public const int HackReporterComponent = 0x0C30;

		///<summary><![CDATA[bool]]></summary>
		public const int bAcceptHitsWhileNotAlive = 0x0C38;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData19 = 0x0C39;

		///<summary><![CDATA[float]]></summary>
		public const int SimulatedHit_Initial = 0x0C3C;

		///<summary><![CDATA[float]]></summary>
		public const int SimulatedHit_RecoveryPerSecond = 0x0C40;

		///<summary><![CDATA[float]]></summary>
		public const int SimulatedHit_Value = 0x0C44;

		///<summary><![CDATA[float]]></summary>
		public const int SimulatedHit_ImpulsePower = 0x0C48;

		///<summary><![CDATA[float]]></summary>
		public const int SimlatedHit_PunchLightPower = 0x0C4C;

		///<summary><![CDATA[float]]></summary>
		public const int SimlatedHit_PunchHeavyPower = 0x0C50;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData20 = 0x0C54;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PunchImpactEffect = 0x0C58;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData21 = 0x0C60;

		///<summary><![CDATA[UCharacterWeaponAnimInfoComponent *]]></summary>
		public const int WeaponAnimInfoComponent = 0x0C88;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Primary = 0x0C90;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Secondary = 0x0C98;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Sidearm = 0x0CA0;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Melee = 0x0CA8;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Thrown = 0x0CB0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FootStepEffectClassInDirt = 0x0CB8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FootStepEffectClassInGrass = 0x0CC0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FootStepEffectClassInRock = 0x0CC8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FootStepEffectClassInSand = 0x0CD0;

		///<summary><![CDATA[FName]]></summary>
		public const int ParticleSocketFootLeft = 0x0CD8;

		///<summary><![CDATA[FName]]></summary>
		public const int ParticleSocketFootRight = 0x0CE0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FootStepEffectClassInWater = 0x0CE8;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int FootStepEffect = 0x0CF0;

		///<summary><![CDATA[ATeam *]]></summary>
		public const int Team = 0x0CF8;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData22 = 0x0D00;

		///<summary><![CDATA[UTslViewTargetTempComponent *]]></summary>
		public const int ViewTargetTempComponent = 0x0D20;

		///<summary><![CDATA[UTslCharacterValidateLocationComponent *]]></summary>
		public const int ValidateLocationComponent = 0x0D28;

		///<summary><![CDATA[UTslThrowableTrajectoryViewComponent *]]></summary>
		public const int ThrowableTrajectoryViewComponent = 0x0D30;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData23 = 0x0D38;

		///<summary><![CDATA[FString]]></summary>
		public const int CharacterNetId = 0x0D58;

		///<summary><![CDATA[FString]]></summary>
		public const int CharacterName = 0x0D68;

		///<summary><![CDATA[FName]]></summary>
		public const int HeadAttachPoint = 0x0D78;

		///<summary><![CDATA[float]]></summary>
		public const int CameraHeadHideDistance = 0x0D80;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData24 = 0x0D84;

		///<summary><![CDATA[FVector]]></summary>
		public const int CrouchedCameraMove = 0x0D90;

		///<summary><![CDATA[FVector]]></summary>
		public const int PronedCameraMove = 0x0D9C;

		///<summary><![CDATA[FVector]]></summary>
		public const int GroggyCameraMove = 0x0DA8;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchedCameraMoveSpeed = 0x0DB4;

		///<summary><![CDATA[float]]></summary>
		public const int PronedCameraMoveSpeed = 0x0DB8;

		///<summary><![CDATA[float]]></summary>
		public const int GroggyCameraMoveSpeed = 0x0DBC;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData25 = 0x0DC0;

		///<summary><![CDATA[FTakeHitInfo]]></summary>
		public const int LastTakeHitInfo = 0x0E08;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData26 = 0x0E48;

		///<summary><![CDATA[float]]></summary>
		public const int TargetingSpeedModifier = 0x0E4C;

		///<summary><![CDATA[TEnumAsByte<ETargetingType>]]></summary>
		public const int TargetingType = 0x0E50;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData27 = 0x0E51;

		///<summary><![CDATA[float]]></summary>
		public const int Stand_RunningSpeedModifier = 0x0E54;

		///<summary><![CDATA[float]]></summary>
		public const int Stand_SprintingSpeedModifier = 0x0E58;

		///<summary><![CDATA[float]]></summary>
		public const int Stand_SprintingBigGunModifier = 0x0E5C;

		///<summary><![CDATA[float]]></summary>
		public const int Stand_SprintingRifleModifier = 0x0E60;

		///<summary><![CDATA[float]]></summary>
		public const int Stand_SprintingSmallGunMOdifier = 0x0E64;

		///<summary><![CDATA[float]]></summary>
		public const int Crouch_RunningSpeedModifier = 0x0E68;

		///<summary><![CDATA[float]]></summary>
		public const int Crouch_SprintingSpeedModifier = 0x0E6C;

		///<summary><![CDATA[float]]></summary>
		public const int Prone_RunningSpeedModifier = 0x0E70;

		///<summary><![CDATA[float]]></summary>
		public const int Prone_SprintingSpeedModifier = 0x0E74;

		///<summary><![CDATA[float]]></summary>
		public const int ReviveCastingTime = 0x0E78;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToRun = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToSprint = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToSprintingAuto = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToRollingLeft = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToRollingRight = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPeekLeft = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsPeekRight = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int IgnoreRotation = 0x0E7C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsGroggying = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsThirdPerson = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData28 = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsReviving = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsWeaponObstructed = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsCoatEquipped = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsZombie = 0x0E7D;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsThrowHigh = 0x0E7D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData29 = 0x0E7E;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseRightShoulderAiming = 0x0E80;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData30 = 0x0E81;

		///<summary><![CDATA[FRotator]]></summary>
		public const int GunDirectionSway = 0x0E84;

		///<summary><![CDATA[FVector_NetQuantizeNormal]]></summary>
		public const int AimOffsets = 0x0E90;

		///<summary><![CDATA[FVector_NetQuantizeNormal]]></summary>
		public const int LastAimOffsets = 0x0E9C;

		///<summary><![CDATA[float]]></summary>
		public const int AimoffsetsLastRepTime = 0x0EA8;

		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData31 = 0x0EAC;

		///<summary><![CDATA[FRotator]]></summary>
		public const int CurrentAutoRotator = 0x0EE4;

		///<summary><![CDATA[float]]></summary>
		public const int AutoPitchValueMax = 0x0EF0;

		///<summary><![CDATA[float]]></summary>
		public const int AutoPitchBlendSpeed = 0x0EF4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData32 = 0x0EF8;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_JumpCamera = 0x0F00;

		///<summary><![CDATA[UCurveVector *]]></summary>
		public const int Curve_FPPCameraOffsetByFOV = 0x0F08;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_DBNOFadeOut = 0x0F10;

		///<summary><![CDATA[float]]></summary>
		public const int DBNOFadeOutLerpSpeed = 0x0F18;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData33 = 0x0F1C;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_StandWalk = 0x0F20;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_StandRun = 0x0F28;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_StandSprint = 0x0F30;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_CrouchWalk = 0x0F38;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_CrouchRun = 0x0F40;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_CrouchSprint = 0x0F48;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_ProneWalk = 0x0F50;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_ProneRun = 0x0F58;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_ProneSprint = 0x0F60;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_Swim = 0x0F68;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_UnderwaterSwim = 0x0F70;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_StandScope = 0x0F78;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_CrouchScope = 0x0F80;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_ProneScope = 0x0F88;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_StandAim = 0x0F90;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_CrouchAim = 0x0F98;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_ProneAim = 0x0FA0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_DBNO = 0x0FA8;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_GroundAngle = 0x0FB0;

		///<summary><![CDATA[UCurveVector *]]></summary>
		public const int Curve_WeaponSway = 0x0FB8;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_TurningLerp = 0x0FC0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_TurningLerpLocomotion = 0x0FC8;

		///<summary><![CDATA[float]]></summary>
		public const int DirectionalSpeedModifier = 0x0FD0;

		///<summary><![CDATA[float]]></summary>
		public const int PointDamageForceMultiplier = 0x0FD4;

		///<summary><![CDATA[float]]></summary>
		public const int PointDamageForce_MapMin = 0x0FD8;

		///<summary><![CDATA[float]]></summary>
		public const int PointDamageForce_MapMax = 0x0FDC;

		///<summary><![CDATA[float]]></summary>
		public const int RadialDamageForceMultiplier = 0x0FE0;

		///<summary><![CDATA[TEnumAsByte<ERadialImpulseFalloff>]]></summary>
		public const int RadialDamageFalloffType = 0x0FE4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData34 = 0x0FE5;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int RollLeftAnim = 0x0FE8;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int RollRightAnim = 0x0FF0;

		///<summary><![CDATA[FCharacterAnim]]></summary>
		public const int CharacterAnim = 0x0FF8;

		///<summary><![CDATA[AController *]]></summary>
		public const int NetOwnerController = 0x1008;

		///<summary><![CDATA[float]]></summary>
		public const int LeanAlphaSpeed = 0x1010;

		///<summary><![CDATA[float]]></summary>
		public const int TurnSpeedHip = 0x1014;

		///<summary><![CDATA[float]]></summary>
		public const int TurnSpeedAimed = 0x1018;

		///<summary><![CDATA[float]]></summary>
		public const int TurnSpeedOverLimit = 0x101C;

		///<summary><![CDATA[float]]></summary>
		public const int MinTurnAngleHip = 0x1020;

		///<summary><![CDATA[float]]></summary>
		public const int MinTurnAngleAim = 0x1024;

		///<summary><![CDATA[float]]></summary>
		public const int TurnLinearEndThreshold = 0x1028;

		///<summary><![CDATA[bool]]></summary>
		public const int bNonLinearTurn = 0x102C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData35 = 0x102D;

		///<summary><![CDATA[float]]></summary>
		public const int TurnNonLinearEndThreshold = 0x1030;

		///<summary><![CDATA[float]]></summary>
		public const int TurnNonLinearInterpSpeed = 0x1034;

		///<summary><![CDATA[float]]></summary>
		public const int CapsuleTurnInterpSpeedLocomotion = 0x1038;

		///<summary><![CDATA[float]]></summary>
		public const int CapsuleTurnInterpSpeedLocomotionSprint = 0x103C;

		///<summary><![CDATA[float]]></summary>
		public const int CapsuleTurnInterpSpeedLocomotionProne = 0x1040;

		///<summary><![CDATA[float]]></summary>
		public const int CapsuleTurnInterpSpeedStationary = 0x1044;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData36 = 0x1048;

		///<summary><![CDATA[FName]]></summary>
		public const int FPPCameraBoneName = 0x1060;

		///<summary><![CDATA[FName]]></summary>
		public const int TPPCameraBoneName = 0x1068;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData37 = 0x1070;

		///<summary><![CDATA[float]]></summary>
		public const int AimStateDefaultTime = 0x107C;

		///<summary><![CDATA[float]]></summary>
		public const int AimStateReturnTime = 0x1080;

		///<summary><![CDATA[float]]></summary>
		public const int AimStateDrawTime = 0x1084;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData38 = 0x1088;

		///<summary><![CDATA[bool]]></summary>
		public const int bAimStateActive = 0x1090;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData39 = 0x1091;

		///<summary><![CDATA[float]]></summary>
		public const int CanGroggyDamageTime = 0x1094;

		///<summary><![CDATA[FText]]></summary>
		public const int GroggyStartText = 0x1098;

		///<summary><![CDATA[FText]]></summary>
		public const int GroggyCancelText = 0x10B0;

		///<summary><![CDATA[FText]]></summary>
		public const int GroggyFinishText = 0x10C8;

		///<summary><![CDATA[float]]></summary>
		public const int GamepadRunningValue = 0x10E0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData40 = 0x10E4;

		///<summary><![CDATA[FRotator]]></summary>
		public const int BlendTargetViewRotation = 0x10F0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int DesiredDirection = 0x10FC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData41 = 0x1104;

		///<summary><![CDATA[UClass *]]></summary>
		public const int InvulnerablilityBuff = 0x1108;

		///<summary><![CDATA[bool]]></summary>
		public const int bInvulnerablilityEffectVisible = 0x1110;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData42 = 0x1111;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x1118;

		///<summary><![CDATA[TArray<FZombieCustomizationData>]]></summary>
		public const int ZombieCustomizationData = 0x1128;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHoldingBreath = 0x1138;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData43 = 0x1139;

		///<summary><![CDATA[float]]></summary>
		public const int Health = 0x113C;

		///<summary><![CDATA[float]]></summary>
		public const int HealthMax = 0x1140;

		///<summary><![CDATA[float]]></summary>
		public const int GroggyHealth = 0x1144;

		///<summary><![CDATA[float]]></summary>
		public const int GroggyHealthMax = 0x1148;

		///<summary><![CDATA[float]]></summary>
		public const int DecreaseGroggyHealthPerSecond = 0x114C;

		///<summary><![CDATA[float]]></summary>
		public const int GroggyDamageWeight = 0x1150;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData44 = 0x1154;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GroggyDamageType = 0x1158;

		///<summary><![CDATA[float]]></summary>
		public const int HealthByRevive = 0x1160;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData45 = 0x1164;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int GroggyToDieAkEvent = 0x1168;

		///<summary><![CDATA[float]]></summary>
		public const int BoostGauge = 0x1170;

		///<summary><![CDATA[float]]></summary>
		public const int BoostGaugeMax = 0x1174;

		///<summary><![CDATA[float]]></summary>
		public const int DecreaseTimerSecond = 0x1178;

		///<summary><![CDATA[float]]></summary>
		public const int DecreaseBoostGaugeByTime = 0x117C;

		///<summary><![CDATA[TArray<FBuffWithBoostGauge>]]></summary>
		public const int BuffWithBoostGauge = 0x1180;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MedKitClass = 0x1190;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FirstAidClass = 0x1198;

		///<summary><![CDATA[UClass *]]></summary>
		public const int BandageClass = 0x11A0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int AdrenalineClass = 0x11A8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PainKillerClass = 0x11B0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int EnergyDrinkClass = 0x11B8;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int BoostItemClasses = 0x11C0;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int HealItemClasses = 0x11D0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GrenadeClass = 0x11E0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MolotovClass = 0x11E8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SmokeBombClass = 0x11F0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FlashBangClass = 0x11F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData46 = 0x1200;

		///<summary><![CDATA[TWeakObjectPtr<ATslPlayerState>]]></summary>
		public const int LaunchInstigator = 0x1204;

		///<summary><![CDATA[TWeakObjectPtr<AActor>]]></summary>
		public const int LaunchCauser = 0x120C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData47 = 0x1214;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LaunchDamageTypeClass = 0x1218;

		///<summary><![CDATA[double]]></summary>
		public const int LastLaunchTime = 0x1220;

		///<summary><![CDATA[APlayerState *]]></summary>
		public const int AuthorizedPlayerState = 0x1228;

		///<summary><![CDATA[EEquipableItemSoundType]]></summary>
		public const int ShoesSoundType = 0x1230;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData48 = 0x1231;

		///<summary><![CDATA[UInteractorComponent *]]></summary>
		public const int InteractorComponent = 0x1238;

		///<summary><![CDATA[UInteractionComponent *]]></summary>
		public const int InteractionComponent = 0x1240;

		///<summary><![CDATA[UVehicleRiderComponent *]]></summary>
		public const int VehicleRiderComponent = 0x1248;

		///<summary><![CDATA[UClass *]]></summary>
		public const int OutSidePlayerAreaEffectClass = 0x1250;

		///<summary><![CDATA[ATslPostProcessEffect *]]></summary>
		public const int OutSidePlayerAreaEffect = 0x1258;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DBNOEffectClass = 0x1260;

		///<summary><![CDATA[ATslPostProcessEffect *]]></summary>
		public const int DBNOEffect = 0x1268;

		///<summary><![CDATA[unsigned char[0x1E0]]]></summary>
		public const int UnknownData49 = 0x1270;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int ShadowMesh = 0x1450;

		///<summary><![CDATA[float]]></summary>
		public const int TargetingFOV = 0x1458;

		///<summary><![CDATA[float]]></summary>
		public const int AimingDelay = 0x145C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData50 = 0x1460;

		///<summary><![CDATA[float]]></summary>
		public const int ScopingDelay = 0x1464;

		///<summary><![CDATA[float]]></summary>
		public const int AttackStateOffDelayTime = 0x1468;

		///<summary><![CDATA[float]]></summary>
		public const int HitStateOffDelayTime = 0x146C;

		///<summary><![CDATA[float]]></summary>
		public const int HitMePlayerStateOffDelayTime = 0x1470;

		///<summary><![CDATA[unsigned char[0x34]]]></summary>
		public const int UnknownData51 = 0x1474;

		///<summary><![CDATA[UTslPlayerDamageConfig *]]></summary>
		public const int DamageConfig = 0x14A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData52 = 0x14B0;

		///<summary><![CDATA[float]]></summary>
		public const int FallDamageFactor = 0x14B4;

		///<summary><![CDATA[float]]></summary>
		public const int FallDamageVelocityMin = 0x14B8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsActiveRagdollActive = 0x14BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData53 = 0x14BD;

		///<summary><![CDATA[float]]></summary>
		public const int CorpseLifeSpan = 0x14C0;

		///<summary><![CDATA[unsigned char[0x54]]]></summary>
		public const int UnknownData54 = 0x14C4;

		///<summary><![CDATA[FVector]]></summary>
		public const int JumpStartLocation_CP = 0x1518;

		///<summary><![CDATA[FVector]]></summary>
		public const int LandPredictedLocation_CP = 0x1524;

		///<summary><![CDATA[float]]></summary>
		public const int FallHeight_CP = 0x1530;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVaulting_CP = 0x1534;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData55 = 0x1535;

		///<summary><![CDATA[float]]></summary>
		public const int VaultTimer_CP = 0x1538;

		///<summary><![CDATA[FVector]]></summary>
		public const int VaultEndVelocity_CP = 0x153C;

		///<summary><![CDATA[FVector]]></summary>
		public const int VaultLastLocation_CP = 0x1548;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsClimbing_CP = 0x1554;

		///<summary><![CDATA[bool]]></summary>
		public const int bEndVaultToFall_CP = 0x1555;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData56 = 0x1556;

		///<summary><![CDATA[FVector]]></summary>
		public const int VaultEndVelocityVectorMutliplier = 0x1558;

		///<summary><![CDATA[float]]></summary>
		public const int VaultEndVelocityVectorClamp = 0x1564;

		///<summary><![CDATA[ATslVaultingHelper *]]></summary>
		public const int VaultingHelperRef = 0x1568;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVaultingSystemEnabled = 0x1570;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData57 = 0x1571;

		///<summary><![CDATA[float]]></summary>
		public const int VaultingDirection_CP = 0x1574;

		///<summary><![CDATA[UVaultingData *]]></summary>
		public const int CurrentVaultData_CP = 0x1578;

		///<summary><![CDATA[bool]]></summary>
		public const int bServerFinishedVault = 0x1580;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData58 = 0x1581;

		///<summary><![CDATA[float]]></summary>
		public const int JumpDelay = 0x1584;

		///<summary><![CDATA[float]]></summary>
		public const int JumpLastTimer = 0x1588;

		///<summary><![CDATA[bool]]></summary>
		public const int bWantsToVault = 0x158C;

		///<summary><![CDATA[bool]]></summary>
		public const int bWantsToCancelVault = 0x158D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData59 = 0x158E;

		///<summary><![CDATA[float]]></summary>
		public const int VaultProbeLoopTime = 0x1590;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData60 = 0x1594;

		///<summary><![CDATA[FAnimUpdateRateSettings]]></summary>
		public const int AnimationUpdateRateSettings = 0x1598;

		///<summary><![CDATA[float]]></summary>
		public const int TO_CulledMovementTickrate = 0x1610;

		///<summary><![CDATA[float]]></summary>
		public const int TO_CulledActorTickInterval = 0x1614;

		///<summary><![CDATA[float]]></summary>
		public const int TO_MinimumDistance = 0x1618;

		///<summary><![CDATA[bool]]></summary>
		public const int bRunTickOptimization = 0x161C;

		///<summary><![CDATA[bool]]></summary>
		public const int bRunTickOptimization_Anim = 0x161D;

		///<summary><![CDATA[bool]]></summary>
		public const int bRunTickOptimization_Movement = 0x161E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData61 = 0x161F;

		///<summary><![CDATA[float]]></summary>
		public const int TO_RenderedTolerance = 0x1620;

		///<summary><![CDATA[bool]]></summary>
		public const int bTickOptimization_Move_Active = 0x1624;

		///<summary><![CDATA[bool]]></summary>
		public const int bTickOptimization_Anim_Active = 0x1625;

		///<summary><![CDATA[bool]]></summary>
		public const int bTickOptimization_Actor_Active = 0x1626;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData62 = 0x1627;

		///<summary><![CDATA[float]]></summary>
		public const int GamepadReloadHoldTime = 0x162C;

		///<summary><![CDATA[float]]></summary>
		public const int GamepadUnarmHoldTime = 0x1630;

		///<summary><![CDATA[float]]></summary>
		public const int GamepadNextGunWeaponTabMaxTime = 0x1634;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData63 = 0x1638;

		///<summary><![CDATA[UBluezoneInOutComponent *]]></summary>
		public const int BluezoneInOut = 0x1688;

		///<summary><![CDATA[UBluezoneInOutSoundEffectComponent *]]></summary>
		public const int BluezoneInOutSoundEffect = 0x1690;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData64 = 0x1698;

	}

	public class UObserverTagWidget
	{
		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int Character = 0x0240;

		///<summary><![CDATA[float]]></summary>
		public const int OffsetZ = 0x0248;

		///<summary><![CDATA[float]]></summary>
		public const int Distance = 0x024C;

	}

	public class AParachuteVehicle
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0410;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnRelease = 0x0420;

		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnLand = 0x0430;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ReleaseSound_Local = 0x0440;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ReleaseSound_Remote = 0x0448;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int LandSound_Local = 0x0450;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int LandSound_Remote = 0x0458;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int FallingStartSound_Local = 0x0460;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int FallingStartSound_Remote = 0x0468;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkSoundCom = 0x0470;

		///<summary><![CDATA[UTslPawnInputBindingComponent *]]></summary>
		public const int TslPawnInputBindingComponent = 0x0478;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int MeshComponent = 0x0480;

		///<summary><![CDATA[UParachuteVehicleMovement *]]></summary>
		public const int ParachuteMovementComponent = 0x0488;

		///<summary><![CDATA[UFreeFallMovement *]]></summary>
		public const int FreeFallMovementComponent = 0x0490;

		///<summary><![CDATA[UTslVehicleSeatComponent *]]></summary>
		public const int VehicleSeatComponent = 0x0498;

		///<summary><![CDATA[UDoublePhaseInteractionComponent *]]></summary>
		public const int InteractionComponent = 0x04A0;

		///<summary><![CDATA[TWeakObjectPtr<ATslCharacter>]]></summary>
		public const int LastDriver = 0x04A8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x04B0;

		///<summary><![CDATA[FName]]></summary>
		public const int FreeFallFirstPersonCameraName = 0x04B8;

		///<summary><![CDATA[FName]]></summary>
		public const int FreeFallThirdPersonCameraName = 0x04C0;

		///<summary><![CDATA[float]]></summary>
		public const int FreeFallCameraPitchMin = 0x04C8;

		///<summary><![CDATA[float]]></summary>
		public const int FreeFallCameraPitchMax = 0x04CC;

		///<summary><![CDATA[float]]></summary>
		public const int ReleasingAltitude = 0x04D0;

		///<summary><![CDATA[float]]></summary>
		public const int ForceReleasingAltitude = 0x04D4;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData02 = 0x04D8;

		///<summary><![CDATA[float]]></summary>
		public const int SweepMoveHeight = 0x04F0;

		///<summary><![CDATA[float]]></summary>
		public const int LandingHeight = 0x04F4;

		///<summary><![CDATA[float]]></summary>
		public const int LandingDuration = 0x04F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x04FC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LandingBuff = 0x0500;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData04 = 0x0508;

		///<summary><![CDATA[float]]></summary>
		public const int StuckCheckDistance = 0x0514;

		///<summary><![CDATA[float]]></summary>
		public const int StuckCheckDuration = 0x0518;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData05 = 0x051C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int UnknownData06 = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ForwardInputRepApplied = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int ForwardInputRepIsForward = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RightInputRepApplied = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int RightInputRepIsRight = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsReleased = 0x0528;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsDriven = 0x0528;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData07 = 0x0529;

		///<summary><![CDATA[FSkinData]]></summary>
		public const int SkinData = 0x0530;

		///<summary><![CDATA[FRotator]]></summary>
		public const int InitialRotation = 0x0550;

		///<summary><![CDATA[FVector]]></summary>
		public const int InitialVelocity = 0x055C;

		///<summary><![CDATA[FVector]]></summary>
		public const int RideSocketOffset = 0x0568;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeaveSocketOffset = 0x0574;

	}

	public class AReplicationTrigger
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[TArray<AActor * >]]></summary>
		public const int TargetReplicatedActors = 0x03B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03C8;

		///<summary><![CDATA[int]]></summary>
		public const int ReplicationGroupCount = 0x03CC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int ReplicationGroupIntervalSeconds = 0x03D4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x03D8;

	}

	public class AReplicationTriggerManager
	{
		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int TargetReplicatedActorClasses = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int TriggerRadius = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int TriggerInterval = 0x03C4;

		///<summary><![CDATA[TArray<AReplicationTrigger * >]]></summary>
		public const int Triggers = 0x03C8;

	}

	public class UReporterManager
	{
		///<summary><![CDATA[unsigned char[0x98]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class URewardData
	{
		///<summary><![CDATA[float]]></summary>
		public const int DefaultScoreMultiplierByDamage = 0x0030;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultScoreMultiplierByKill = 0x0034;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int ScoreByReverseRanking = 0x0038;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int ScoreMultiplierByRanking = 0x0048;

	}

	public class USceneInteractionComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x03E0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxInteractableDistance = 0x03F0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03F4;

		///<summary><![CDATA[FText]]></summary>
		public const int InteractionVerb = 0x03F8;

		///<summary><![CDATA[FText]]></summary>
		public const int InteractiveObjectName = 0x0410;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseTraceCheck = 0x0428;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0429;

		///<summary><![CDATA[FCastConfig]]></summary>
		public const int CastConfig = 0x0430;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0460;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInteractBy = 0x0468;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ClientOnInteractBy = 0x0478;

		///<summary><![CDATA[unsigned char[0x68]]]></summary>
		public const int UnknownData04 = 0x0488;

	}

	public class UDoorInteractionComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x04F0;

		///<summary><![CDATA[TEnumAsByte<EDoorState>]]></summary>
		public const int DoorState = 0x04F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReverseRotation = 0x04F9;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIgnoreParentValidityCheck = 0x04F9;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x04FA;

		///<summary><![CDATA[FVector]]></summary>
		public const int SoundOffset = 0x04FC;

		///<summary><![CDATA[UDoorDataAsset *]]></summary>
		public const int DoorDataAsset = 0x0508;

		///<summary><![CDATA[unsigned char[0x1C0]]]></summary>
		public const int UnknownData02 = 0x0510;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkAudioComponent = 0x06D0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x06D8;

	}

	public class UDroppedItemInteractionComponent
	{
		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData00 = 0x04F0;

		///<summary><![CDATA[UItem *]]></summary>
		public const int Item = 0x0528;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0530;

		///<summary><![CDATA[UAsyncStaticMeshComponent *]]></summary>
		public const int StaticMeshComponent = 0x0538;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x0540;

	}

	public class UVehicleSeatInteractionComponent
	{
		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int Rider = 0x04F0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x04F8;

		///<summary><![CDATA[int]]></summary>
		public const int SeatIndex = 0x0504;

		///<summary><![CDATA[TEnumAsByte<ERiderType>]]></summary>
		public const int RiderType = 0x0508;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0509;

		///<summary><![CDATA[FName]]></summary>
		public const int LeaveSocketName = 0x0510;

		///<summary><![CDATA[float]]></summary>
		public const int ViewPitchMin = 0x0518;

		///<summary><![CDATA[float]]></summary>
		public const int ViewPitchMax = 0x051C;

		///<summary><![CDATA[float]]></summary>
		public const int ViewYawMin = 0x0520;

		///<summary><![CDATA[float]]></summary>
		public const int ViewYawMax = 0x0524;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CurvePitchMax = 0x0528;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CurvePitchMin = 0x0530;

		///<summary><![CDATA[FName]]></summary>
		public const int FirstPersonCameraName = 0x0538;

		///<summary><![CDATA[FName]]></summary>
		public const int ThirdPersonCameraName = 0x0540;

		///<summary><![CDATA[EVehicleAnimType]]></summary>
		public const int SeatAnimationType = 0x0548;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0549;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int SeatBlendspaceAiming = 0x0550;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int SeatBlendspaceFPPAiming = 0x0558;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int SeatAnimationIdle_Rifle = 0x0560;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int SeatAnimationIdle_Melee = 0x0568;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int SeatAnimationIdle_Unarmed = 0x0570;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int SeatAnimationIdle_Grenade = 0x0578;

		///<summary><![CDATA[UAimOffsetBlendSpace *]]></summary>
		public const int SeatIdleAO = 0x0580;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int TransitionOutBlendspace = 0x0588;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int TransitionInBlendspace = 0x0590;

		///<summary><![CDATA[bool]]></summary>
		public const int bRestricWeaponUse = 0x0598;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0599;

		///<summary><![CDATA[TArray<EWeaponClass>]]></summary>
		public const int AllowedWeaponClasses = 0x05A0;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanOnlyFireWhileAiming = 0x05B0;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseEntryVelocityRestriction = 0x05B1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData04 = 0x05B2;

		///<summary><![CDATA[float]]></summary>
		public const int MaxVelocityForEntry = 0x05B4;

		///<summary><![CDATA[float]]></summary>
		public const int InteractionBlockDuration = 0x05B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData05 = 0x05BC;

	}

	public class USimpleInterpolationMovement
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0260;

		///<summary><![CDATA[float]]></summary>
		public const int LocationInterpTime = 0x0278;

		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData01 = 0x027C;

		///<summary><![CDATA[float]]></summary>
		public const int RotationInterpTime = 0x02B4;

		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData02 = 0x02B8;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseOnlyYawRotation = 0x02F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSweepMove = 0x02F1;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSafeInterpolation = 0x02F2;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData03 = 0x02F3;

		///<summary><![CDATA[float]]></summary>
		public const int ForceMoveTime = 0x02F4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x02F8;

	}

	public class UFreeFallMovement
	{
		///<summary><![CDATA[float]]></summary>
		public const int MinPitch = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int MaxPitch = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int MaxLateralSpeed = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int LateralAcceleration = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int LateralDeceleration = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int LateralBrakeDeceleration = 0x0314;

		///<summary><![CDATA[float]]></summary>
		public const int VerticalAcceleration = 0x0318;

		///<summary><![CDATA[float]]></summary>
		public const int VerticalDeceleration = 0x031C;

		///<summary><![CDATA[float]]></summary>
		public const int TerminalSpeed = 0x0320;

		///<summary><![CDATA[float]]></summary>
		public const int MinAdditiveTerminalSpeed = 0x0324;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAdditiveTerminalSpeed = 0x0328;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYawRate = 0x032C;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0330;

		///<summary><![CDATA[float]]></summary>
		public const int InputUpdateTime = 0x0340;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0344;

	}

	public class UParachuteVehicleMovement
	{
		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSpeed = 0x0304;

		///<summary><![CDATA[float]]></summary>
		public const int Acceleration = 0x0308;

		///<summary><![CDATA[float]]></summary>
		public const int Deceleration = 0x030C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxRotationYawRate = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYawAcceleration = 0x0314;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYawDeceleration = 0x0318;

		///<summary><![CDATA[float]]></summary>
		public const int TerminalVelocity = 0x031C;

		///<summary><![CDATA[float]]></summary>
		public const int DecreaseTerminalVelocity = 0x0320;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0324;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYawReplicated = 0x032C;

		///<summary><![CDATA[float]]></summary>
		public const int RotationPitchReplicated = 0x0330;

		///<summary><![CDATA[float]]></summary>
		public const int InputUpdateTime = 0x0334;

		///<summary><![CDATA[unsigned char[0x2C]]]></summary>
		public const int UnknownData02 = 0x0338;

		///<summary><![CDATA[float]]></summary>
		public const int ParachuteDeployCoefficient = 0x0364;

		///<summary><![CDATA[float]]></summary>
		public const int YawSpeed = 0x0368;

		///<summary><![CDATA[float]]></summary>
		public const int MaxForwardPitch = 0x036C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxBackwardPitch = 0x0370;

		///<summary><![CDATA[float]]></summary>
		public const int ForceForwardScale = 0x0374;

		///<summary><![CDATA[float]]></summary>
		public const int ForceForwardStaticSpeed = 0x0378;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityLERPSpeedMin = 0x037C;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityLERPSpeedMax = 0x0380;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityLERPValueMin = 0x0384;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityLERPValueMax = 0x0388;

		///<summary><![CDATA[float]]></summary>
		public const int DampingPitchMin = 0x038C;

		///<summary><![CDATA[float]]></summary>
		public const int DampingPitchMax = 0x0390;

		///<summary><![CDATA[float]]></summary>
		public const int DampingValueMin = 0x0394;

		///<summary><![CDATA[float]]></summary>
		public const int DampingValueMax = 0x0398;

		///<summary><![CDATA[float]]></summary>
		public const int ForceDownAngleMin = 0x039C;

		///<summary><![CDATA[float]]></summary>
		public const int ForceDownAngleMax = 0x03A0;

		///<summary><![CDATA[float]]></summary>
		public const int ForceGravityMax = 0x03A4;

		///<summary><![CDATA[float]]></summary>
		public const int ForceGravitySpeedMin = 0x03A8;

		///<summary><![CDATA[float]]></summary>
		public const int ForceGravitySpeedMax = 0x03AC;

		///<summary><![CDATA[float]]></summary>
		public const int ForceGravityValueMin = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int ForceGravityValueMax = 0x03B4;

		///<summary><![CDATA[float]]></summary>
		public const int RollSpeedMin = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int RollSpeedMax = 0x03BC;

		///<summary><![CDATA[float]]></summary>
		public const int RollAngleMin = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int RollAngleMax = 0x03C4;

		///<summary><![CDATA[float]]></summary>
		public const int RollInterpSpeed = 0x03C8;

		///<summary><![CDATA[float]]></summary>
		public const int FinalVelocitySpeedMin = 0x03CC;

		///<summary><![CDATA[float]]></summary>
		public const int FinalVelocitySpeedMax = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int FinalVelocityDampingMin = 0x03D4;

		///<summary><![CDATA[float]]></summary>
		public const int FinalVelocityDampingMax = 0x03D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x03DC;

		///<summary><![CDATA[float]]></summary>
		public const int TraceSphereRadius = 0x03E0;

		///<summary><![CDATA[FVector]]></summary>
		public const int TraceSphereOffset = 0x03E4;

		///<summary><![CDATA[float]]></summary>
		public const int GroundTraceStart = 0x03F0;

		///<summary><![CDATA[float]]></summary>
		public const int GroundTraceEnd = 0x03F4;

		///<summary><![CDATA[float]]></summary>
		public const int GroundTraceDampingMin = 0x03F8;

		///<summary><![CDATA[float]]></summary>
		public const int GroundTraceDampingMax = 0x03FC;

	}

	public class UTslAircraftVehicleMovement
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0300;

	}

	public class UStanceComponent
	{
		///<summary><![CDATA[FStanceTransitionData]]></summary>
		public const int StanceTransitionData = 0x01E0;

		///<summary><![CDATA[TEnumAsByte<EStanceMode>]]></summary>
		public const int CurrentStance = 0x0240;

		///<summary><![CDATA[unsigned char[0x1F]]]></summary>
		public const int UnknownData00 = 0x0241;

	}

	public class ATslPlayerStart
	{
		///<summary><![CDATA[EMatchStartType]]></summary>
		public const int MatchStartType = 0x03E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03E1;

		///<summary><![CDATA[float]]></summary>
		public const int StartRadius = 0x03E4;

		///<summary><![CDATA[bool]]></summary>
		public const int bRandomRotation = 0x03E8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03E9;

		///<summary><![CDATA[TArray<AStartActivationVolume * >]]></summary>
		public const int ActivationVolumes = 0x03F0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0400;

	}

	public class AStartActivationVolume
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03E8;

	}

	public class AInventoryFacade
	{
		///<summary><![CDATA[TArray<EEquipSlotID>]]></summary>
		public const int AutoSwapEquipSlotID = 0x03B8;

		///<summary><![CDATA[AInventory *]]></summary>
		public const int Inventory = 0x03C8;

		///<summary><![CDATA[AEquipment *]]></summary>
		public const int Equipment = 0x03D0;

	}

	public class AEquipment
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEquipmentUpdated = 0x03E8;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x03F8;

		///<summary><![CDATA[TArray<UEquipableItem * >]]></summary>
		public const int Items = 0x0428;

	}

	public class AInventory
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnInventoryUpdated = 0x03E8;

		///<summary><![CDATA[TArray<UItem * >]]></summary>
		public const int Items = 0x03F8;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSpace = 0x0408;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x040C;

	}

	public class AItemExplorerProxy
	{
		///<summary><![CDATA[FScriptDelegate]]></summary>
		public const int OnChangeItemExplorerProxy = 0x0418;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0428;

	}

	public class ACarePackageItem
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ParachuteClass = 0x0510;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SmokeFxClass = 0x0518;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SmokeAirFxClass = 0x0520;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LightFxClass = 0x0528;

		///<summary><![CDATA[float]]></summary>
		public const int SmokeTime = 0x0530;

		///<summary><![CDATA[float]]></summary>
		public const int LimitFallSpeed = 0x0534;

		///<summary><![CDATA[FName]]></summary>
		public const int SmokeSocket = 0x0538;

		///<summary><![CDATA[FName]]></summary>
		public const int SmokeAirSocket = 0x0540;

		///<summary><![CDATA[FName]]></summary>
		public const int LightSocket = 0x0548;

		///<summary><![CDATA[FName]]></summary>
		public const int ParachuteSocket = 0x0550;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int LandSoundAk = 0x0558;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFalling = 0x0560;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsPickupedItem = 0x0561;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHideIconOnMap = 0x0562;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsTranslucentIconOnMap = 0x0563;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0564;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int SmokeFx = 0x0568;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int SmokeAirFx = 0x0570;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int LightFx = 0x0578;

		///<summary><![CDATA[AActor *]]></summary>
		public const int Parachute = 0x0580;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0588;

		///<summary><![CDATA[USimpleInterpolationMovement *]]></summary>
		public const int MovementComponent = 0x0590;

		///<summary><![CDATA[UBuoyancyForceComponent *]]></summary>
		public const int BuoyancyForceComponent = 0x0598;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkComponent = 0x05A0;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData02 = 0x05A8;

	}

	public class AFloorSnapItemPackage
	{
		///<summary><![CDATA[float]]></summary>
		public const int RayLength = 0x0510;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseWaterSurface = 0x0514;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0515;

		///<summary><![CDATA[float]]></summary>
		public const int WaterSurfaceThreshold = 0x0518;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x051C;

		///<summary><![CDATA[UBuoyancyForceComponent *]]></summary>
		public const int BuoyancyForceComponent = 0x0520;

	}

	public class ANearbyInteractiveItemExplorer
	{
		///<summary><![CDATA[TArray<TWeakObjectPtr<UObject>>]]></summary>
		public const int ExplorableItems = 0x0418;

	}

	public class UThingSpawnProcessor
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UCombinedThingSpawnProcessor
	{
		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int SubProcessorClasses = 0x0038;

		///<summary><![CDATA[TArray<USubThingSpawnProcessor * >]]></summary>
		public const int SubProcessors = 0x0048;

	}

	public class UPackageSubThingSpawnProcessor
	{
		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawItemSpawnDataTable = 0x0028;

		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawItemSpawnTogetherDataTable = 0x0030;

		///<summary><![CDATA[TArray<FPackageSpotGroupProperty>]]></summary>
		public const int RawSpotGroupProperties = 0x0038;

		///<summary><![CDATA[unsigned char[0x3B0]]]></summary>
		public const int UnknownData00 = 0x0048;

	}

	public class UVehicleSubThingSpawnProcessor
	{
		///<summary><![CDATA[TArray<FVehicleSpotGroupProperty>]]></summary>
		public const int RawSpotGroupProperties = 0x0028;

		///<summary><![CDATA[UDataTable *]]></summary>
		public const int RawVehicleSpawnDataTable = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int SpawnZOffsetFromFloor = 0x0040;

		///<summary><![CDATA[unsigned char[0x3D4]]]></summary>
		public const int UnknownData00 = 0x0044;

	}

	public class ATeam
	{
		///<summary><![CDATA[FVector_NetQuantize100]]></summary>
		public const int PlayerLocation = 0x03B0;

		///<summary><![CDATA[FRotator]]></summary>
		public const int PlayerRotation = 0x03BC;

		///<summary><![CDATA[FString]]></summary>
		public const int PlayerName = 0x03C8;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int Health = 0x03D8;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int HealthMax = 0x03D9;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int GroggyHealth = 0x03DA;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int GroggyHealthMax = 0x03DB;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int MapMarkerPosition = 0x03DC;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsDying = 0x03E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsGroggying = 0x03E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bQuitter = 0x03E4;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bShowMapMarker = 0x03E4;

		///<summary><![CDATA[ETeamVehicleType]]></summary>
		public const int TeamVehicleType = 0x03E5;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03E6;

		///<summary><![CDATA[float]]></summary>
		public const int BoostGauge = 0x03E8;

		///<summary><![CDATA[int8_t]]></summary>
		public const int MemberNumber = 0x03EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x03ED;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int TslCharacter = 0x03F0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x03F8;

		///<summary><![CDATA[FString]]></summary>
		public const int UniqueId = 0x0408;

	}

	public class AThingHolder
	{
		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class AThingSpot
	{
		///<summary><![CDATA[UThingSpotComponent *]]></summary>
		public const int SpotComponent = 0x03B0;

	}

	public class UThingSpotComponent
	{
		///<summary><![CDATA[EThingSpotGroupType]]></summary>
		public const int SpotGroupType = 0x03E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x03E1;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int RandomRotatorRange = 0x03E4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x03EC;

	}

	public class UTslAccessoryComponent
	{
		///<summary><![CDATA[FTransform]]></summary>
		public const int InitialTransformAttachmentScene = 0x03E0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0410;

	}

	public class ATslAchievement
	{
		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class ATslAIController
	{
		///<summary><![CDATA[UBlackboardComponent *]]></summary>
		public const int BlackboardComp = 0x04A8;

		///<summary><![CDATA[UBehaviorTreeComponent *]]></summary>
		public const int BehaviorComp = 0x04B0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x04B8;

	}

	public class ATslAircraftVehicle
	{
		///<summary><![CDATA[TArray<FAircraftParticle>]]></summary>
		public const int AircraftParticles = 0x0410;

		///<summary><![CDATA[TArray<ATslParticle * >]]></summary>
		public const int AttachedParticles = 0x0420;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int MeshComponent = 0x0430;

		///<summary><![CDATA[UTslAircraftVehicleMovement *]]></summary>
		public const int MovementComponent = 0x0438;

		///<summary><![CDATA[USplineComponent *]]></summary>
		public const int SplineComponent = 0x0440;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData00 = 0x0448;

		///<summary><![CDATA[float]]></summary>
		public const int TotalFlyingTime = 0x0490;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0494;

	}

	public class AAircraftCarePackage
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int CarePackageItemSpawnerClass = 0x04A0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CarePackageItemClass = 0x04A8;

		///<summary><![CDATA[TArray<FDropCarePackageTableData>]]></summary>
		public const int DropCarePackageTableData = 0x04B0;

		///<summary><![CDATA[UGeneralItemSpawner *]]></summary>
		public const int CarePackageItemSpawner = 0x04C0;

		///<summary><![CDATA[TArray<ATslPassCarePackageArea * >]]></summary>
		public const int PassCarePackageAreas = 0x04C8;

		///<summary><![CDATA[TArray<ATslPassCarePackageAreaRectangle * >]]></summary>
		public const int PassCarePackageAreasRectangle = 0x04D8;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x04E8;

	}

	public class ATransportAircraftVehicle
	{
		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x04A0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int RideSound = 0x04C8;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int LeaveSound = 0x04D0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkSoundCom = 0x04D8;

		///<summary><![CDATA[UTslVehicleSeatComponent *]]></summary>
		public const int VehicleSeatComponent = 0x04E0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ParachuteItem = 0x04E8;

		///<summary><![CDATA[UInteractionComponent *]]></summary>
		public const int InteractionComponent = 0x04F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsEnteredAtEjectionArea = 0x04F8;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x04F9;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVisible = 0x04FA;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x04FB;

		///<summary><![CDATA[float]]></summary>
		public const int EjectPredictionTime = 0x04FC;

		///<summary><![CDATA[float]]></summary>
		public const int MaxEjectSpeed = 0x0500;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData03 = 0x0504;

	}

	public class ATslWheeledVehicle
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0420;

		///<summary><![CDATA[USphereComponent *]]></summary>
		public const int ActivationTrigger = 0x0440;

		///<summary><![CDATA[float]]></summary>
		public const int Health = 0x0448;

		///<summary><![CDATA[float]]></summary>
		public const int HealthMax = 0x044C;

		///<summary><![CDATA[float]]></summary>
		public const int Fuel = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int FuelMax = 0x0454;

		///<summary><![CDATA[bool]]></summary>
		public const int bStabilizeActive = 0x0458;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0459;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlPitchInput = 0x045C;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedKPH = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int ThrottleInput = 0x0464;

		///<summary><![CDATA[float]]></summary>
		public const int RPM = 0x0468;

		///<summary><![CDATA[float]]></summary>
		public const int Brake = 0x046C;

		///<summary><![CDATA[float]]></summary>
		public const int LatMax = 0x0470;

		///<summary><![CDATA[float]]></summary>
		public const int LongSum = 0x0474;

		///<summary><![CDATA[float]]></summary>
		public const int WaterDepthMax = 0x0478;

		///<summary><![CDATA[float]]></summary>
		public const int SurfaceMax = 0x047C;

		///<summary><![CDATA[float]]></summary>
		public const int SuspensionMax = 0x0480;

		///<summary><![CDATA[int]]></summary>
		public const int FlatTireCount = 0x0484;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDirtySpeedKPH = 0x0488;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDirtyThrottleInput = 0x0488;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDirtyRPM = 0x0488;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDirtyWaterDepthMax = 0x0488;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDirtyBrake = 0x0488;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDetectedStartup = 0x0488;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDetectedBraking = 0x0488;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0489;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int WheelsLatSlip = 0x0490;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int WheelsLongSlip = 0x04A0;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int WheelsSuspensionOffset = 0x04B0;

		///<summary><![CDATA[TArray<UPhysicalMaterial * >]]></summary>
		public const int WheelsContactSurface = 0x04C0;

		///<summary><![CDATA[TArray<UPhysicalMaterial * >]]></summary>
		public const int TestWheelsContactSurface_prev = 0x04D0;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int WheelsSuspensionMaxDrop = 0x04E0;

		///<summary><![CDATA[TArray<float>]]></summary>
		public const int WheelsSuspensionMaxRaise = 0x04F0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int NullSound = 0x0500;

		///<summary><![CDATA[FTslImpactSoundInfo]]></summary>
		public const int ImpactSound = 0x0508;

		///<summary><![CDATA[FTslImpactSoundInfo]]></summary>
		public const int LandingSound = 0x0568;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int StartupSound = 0x05C8;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int BreakSound = 0x05D0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int StopSound = 0x05D8;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int CharacterHitSound = 0x05E0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxClampThrottleInClutch = 0x05E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bApplyCustomAnimUpdaterateSettings = 0x05EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x05ED;

		///<summary><![CDATA[FAnimUpdateRateSettings]]></summary>
		public const int AnimUpdateRateSettings = 0x05F0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bWantsToBoosting = 0x0668;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0669;

		///<summary><![CDATA[float]]></summary>
		public const int TorqueMultiplierForBoosting = 0x066C;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x0670;

		///<summary><![CDATA[UTslVehicleHitComponent *]]></summary>
		public const int VehicleHitComponent = 0x0678;

		///<summary><![CDATA[UTslVehicleCommonComponent *]]></summary>
		public const int VehicleCommonComponent = 0x0680;

		///<summary><![CDATA[UTslVehicleSeatComponent *]]></summary>
		public const int VehicleSeatComponent = 0x0688;

		///<summary><![CDATA[UTslVehicleEffectComponent *]]></summary>
		public const int VehicleEffectComponent = 0x0690;

		///<summary><![CDATA[UTslVehicleSyncComponent *]]></summary>
		public const int VehicleSyncComponent = 0x0698;

		///<summary><![CDATA[UTslVehicleTempComponent *]]></summary>
		public const int VehicleTempComponent = 0x06A0;

		///<summary><![CDATA[UTslPawnInputBindingComponent *]]></summary>
		public const int TslPawnInputBindingComponent = 0x06A8;

		///<summary><![CDATA[UTslHornComponent *]]></summary>
		public const int TslHornComponent = 0x06B0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AudioComEngine = 0x06B8;

		///<summary><![CDATA[UBuoyancyForceComponent *]]></summary>
		public const int BuoyancyForceComponent = 0x06C0;

		///<summary><![CDATA[FName]]></summary>
		public const int SinkPoint = 0x06C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SinkBuffType = 0x06D0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData06 = 0x06D8;

		///<summary><![CDATA[UBuffComponet *]]></summary>
		public const int BuffComponent = 0x06E0;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x06E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bProcessAutoEject = 0x06F8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x06F9;

		///<summary><![CDATA[float]]></summary>
		public const int AutoEjectGroundDistance = 0x06FC;

		///<summary><![CDATA[float]]></summary>
		public const int AutoEjectRoll = 0x0700;

		///<summary><![CDATA[float]]></summary>
		public const int AutoEjectPitch = 0x0704;

		///<summary><![CDATA[float]]></summary>
		public const int AutoEject_RiseRate = 0x0708;

		///<summary><![CDATA[float]]></summary>
		public const int AutoEject_FallRate = 0x070C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x0710;

		///<summary><![CDATA[bool]]></summary>
		public const int bRunStabilizeOnEntry = 0x0714;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x0715;

		///<summary><![CDATA[float]]></summary>
		public const int StabilizeInitialTimer = 0x0718;

		///<summary><![CDATA[float]]></summary>
		public const int StablizeCurrentTimer = 0x071C;

		///<summary><![CDATA[float]]></summary>
		public const int SteeringYawBias = 0x0720;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData10 = 0x0724;

	}

	public class ATslFloatingVehicle
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0410;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int MeshComponent = 0x0420;

		///<summary><![CDATA[UBuoyancyForceComponent *]]></summary>
		public const int BuoyancyForceComponent = 0x0428;

		///<summary><![CDATA[UTslFloatingVehicleMovement *]]></summary>
		public const int MovementComponent = 0x0430;

		///<summary><![CDATA[UTslVehicleHitComponent *]]></summary>
		public const int VehicleHitComponent = 0x0438;

		///<summary><![CDATA[UTslVehicleCommonComponent *]]></summary>
		public const int VehicleCommonComponent = 0x0440;

		///<summary><![CDATA[UTslVehicleSeatComponent *]]></summary>
		public const int VehicleSeatComponent = 0x0448;

		///<summary><![CDATA[UTslVehicleEffectComponent *]]></summary>
		public const int VehicleEffectComponent = 0x0450;

		///<summary><![CDATA[UTslVehicleSyncComponent *]]></summary>
		public const int VehicleSyncComponent = 0x0458;

		///<summary><![CDATA[UTslVehicleTempComponent *]]></summary>
		public const int VehicleTempComponent = 0x0460;

		///<summary><![CDATA[UTslHornComponent *]]></summary>
		public const int TslHornComponent = 0x0468;

		///<summary><![CDATA[UTslPawnInputBindingComponent *]]></summary>
		public const int TslPawnInputBindingComponent = 0x0470;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AudioComEngine = 0x0478;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int ComponentsToDestroyOnDedicatedServer = 0x0480;

		///<summary><![CDATA[FName]]></summary>
		public const int VehicleEnginePoint = 0x0490;

		///<summary><![CDATA[float]]></summary>
		public const int VehicleEngineRadius = 0x0498;

		///<summary><![CDATA[float]]></summary>
		public const int Health = 0x049C;

		///<summary><![CDATA[float]]></summary>
		public const int HealthMax = 0x04A0;

		///<summary><![CDATA[float]]></summary>
		public const int Fuel = 0x04A4;

		///<summary><![CDATA[float]]></summary>
		public const int FuelMax = 0x04A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x04AC;

	}

	public class UTslWheeledVehicleMovement
	{
		///<summary><![CDATA[TArray<float>]]></summary>
		public const int WheelHealthPercentages = 0x0530;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0540;

		///<summary><![CDATA[FCustomTransmissionData]]></summary>
		public const int CustomTransmission = 0x0548;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0568;

		///<summary><![CDATA[bool]]></summary>
		public const int bAlwaysUseDirectInput = 0x056C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x056D;

		///<summary><![CDATA[float]]></summary>
		public const int Anim_SteeringInputInterpSpeed = 0x0570;

		///<summary><![CDATA[float]]></summary>
		public const int Anim_InterpOfInterpSpeedScale = 0x0574;

		///<summary><![CDATA[float]]></summary>
		public const int Anim_InterpOfInterpSpeedAbs = 0x0578;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x057C;

		///<summary><![CDATA[float]]></summary>
		public const int Anim_SpeedForInputTypeSwitch = 0x0584;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0588;

	}

	public class UTslFloatingVehicleMovement
	{
		///<summary><![CDATA[float]]></summary>
		public const int MaxAcceleration = 0x0260;

		///<summary><![CDATA[float]]></summary>
		public const int Acceleration = 0x0264;

		///<summary><![CDATA[float]]></summary>
		public const int StartAccelerationRate = 0x0268;

		///<summary><![CDATA[float]]></summary>
		public const int StopAccelerationRate = 0x026C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxRotationYawAngle = 0x0270;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYawAngle = 0x0274;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYawRate = 0x0278;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x027C;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int DirectionalAccelerationCurve = 0x0280;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int SlideCompensationCurve = 0x0288;

		///<summary><![CDATA[float]]></summary>
		public const int BoostModifier = 0x0290;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsBoosting = 0x0294;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0295;

		///<summary><![CDATA[float]]></summary>
		public const int ForwardInput = 0x0298;

		///<summary><![CDATA[float]]></summary>
		public const int RotationInput = 0x029C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x02A0;

		///<summary><![CDATA[float]]></summary>
		public const int HitCharacterDuration = 0x02A4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x02A8;

	}

	public class UTslCharacterMovement
	{
		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData00 = 0x0840;

		///<summary><![CDATA[float]]></summary>
		public const int MaxProneSpeed = 0x08A0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxGroggySpeed = 0x08A4;

		///<summary><![CDATA[float]]></summary>
		public const int JumpedHalfHeight = 0x08A8;

		///<summary><![CDATA[float]]></summary>
		public const int JumpVelocityLossScale = 0x08AC;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedToJumpModifier = 0x08B0;

		///<summary><![CDATA[float]]></summary>
		public const int MinJumpZVelocity = 0x08B4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxJumpZVelocity = 0x08B8;

		///<summary><![CDATA[float]]></summary>
		public const int LandingJumpDecreaseModifier = 0x08BC;

		///<summary><![CDATA[float]]></summary>
		public const int RecoveryWalkSpeedRatePerSec = 0x08C0;

		///<summary><![CDATA[float]]></summary>
		public const int MinWalkSpeedModifier = 0x08C4;

		///<summary><![CDATA[float]]></summary>
		public const int WalkSpeedModifierUnit = 0x08C8;

		///<summary><![CDATA[float]]></summary>
		public const int MinStandingJumpXYSpeed = 0x08CC;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedInWaterModifier = 0x08D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseCPVault = 0x08D4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x08D5;

		///<summary><![CDATA[int]]></summary>
		public const int HeightFor200 = 0x0928;

		///<summary><![CDATA[int]]></summary>
		public const int HeightFor160 = 0x092C;

		///<summary><![CDATA[int]]></summary>
		public const int HeightFor120 = 0x0930;

		///<summary><![CDATA[int]]></summary>
		public const int HeightFor90 = 0x0934;

		///<summary><![CDATA[int]]></summary>
		public const int HeightFor60 = 0x0938;

		///<summary><![CDATA[float]]></summary>
		public const int SizeForNarrow = 0x093C;

		///<summary><![CDATA[int]]></summary>
		public const int SizeForSlide = 0x0940;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityForMobile = 0x0944;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalVaultScale = 0x0948;

		///<summary><![CDATA[float]]></summary>
		public const int VaultCancelDTScalar = 0x094C;

		///<summary><![CDATA[float]]></summary>
		public const int MinVelocityForStaticVaultCheck = 0x0950;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int MaxVaultDistanceByVelocityInMap = 0x0954;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int MaxVaultDistanceByVelocityOutMap = 0x095C;

		///<summary><![CDATA[FVaultingTask]]></summary>
		public const int CurrentVaultingTask = 0x0964;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x09A4;

		///<summary><![CDATA[UVaultingData *]]></summary>
		public const int CurrentVaultingData = 0x09A8;

		///<summary><![CDATA[float]]></summary>
		public const int V_Timer_CP = 0x09B0;

		///<summary><![CDATA[float]]></summary>
		public const int AnimMultiplierPreApex = 0x09B4;

		///<summary><![CDATA[float]]></summary>
		public const int AnimMultiplierPostApex = 0x09B8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVaulting_CP = 0x09BC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x09BD;

		///<summary><![CDATA[FVector]]></summary>
		public const int CharacterRelLocation = 0x09C0;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastVaultLocation = 0x09CC;

		///<summary><![CDATA[FVector]]></summary>
		public const int AveragedVelocity = 0x09D8;

		///<summary><![CDATA[float]]></summary>
		public const int LastVaultTime = 0x09E4;

		///<summary><![CDATA[float]]></summary>
		public const int VaultCancelAnimSpeed = 0x09E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bWantsToCancelVault = 0x09EC;

		///<summary><![CDATA[unsigned char[0x63]]]></summary>
		public const int UnknownData04 = 0x09ED;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSwimAcceleration = 0x0A50;

		///<summary><![CDATA[float]]></summary>
		public const int MaxZSpeedOutOfWaterModifier = 0x0A54;

		///<summary><![CDATA[FRotator]]></summary>
		public const int MaxSwimmingRotationRate = 0x0A58;

		///<summary><![CDATA[FRotator]]></summary>
		public const int SwimmingRotationAcceleration = 0x0A64;

		///<summary><![CDATA[float]]></summary>
		public const int MaxZSpeedOutOfWaterModifierForStandingSwimming = 0x0A70;

		///<summary><![CDATA[float]]></summary>
		public const int WaveRidingModifier = 0x0A74;

		///<summary><![CDATA[float]]></summary>
		public const int WaveRidingSmoothingFactor = 0x0A78;

		///<summary><![CDATA[float]]></summary>
		public const int WaveRidingModifierUnderWater = 0x0A7C;

		///<summary><![CDATA[float]]></summary>
		public const int StayingUnderWaterDepthBand = 0x0A80;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData05 = 0x0A84;

		///<summary><![CDATA[float]]></summary>
		public const int MaxUnderwaterSwimSpeed = 0x0A88;

		///<summary><![CDATA[float]]></summary>
		public const int MaxUnderwaterSwimAcceleration = 0x0A8C;

		///<summary><![CDATA[float]]></summary>
		public const int BrakingDecelerationUnderwaterSwimming = 0x0A90;

		///<summary><![CDATA[FRotator]]></summary>
		public const int MaxUnderwaterSwimmingRotationRate = 0x0A94;

		///<summary><![CDATA[FRotator]]></summary>
		public const int UnderwaterSwimmingRotationAcceleration = 0x0AA0;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumHighAltitude = 0x0AAC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData06 = 0x0AB0;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFallLateralSpeedAtHighAltitude = 0x0AB4;

		///<summary><![CDATA[float]]></summary>
		public const int TerminalVelocityAtHighAltitude = 0x0AB8;

		///<summary><![CDATA[float]]></summary>
		public const int DecreaseTerminalVelocityAtHighAltitude = 0x0ABC;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFallAccelerationAtHighAltitude = 0x0AC0;

		///<summary><![CDATA[FRotator]]></summary>
		public const int FallRotationRateAtHighAltitude = 0x0AC4;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlAtHighAltitude = 0x0AD0;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlBoostMultiplierAtHighAltitude = 0x0AD4;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlBoostVelocityThresholdAtHighAltitude = 0x0AD8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData07 = 0x0ADC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FallingDamageType = 0x0AE0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int EjectDamageCurve = 0x0AE8;

		///<summary><![CDATA[float]]></summary>
		public const int FallingDamageMinZCut = 0x0AF0;

		///<summary><![CDATA[float]]></summary>
		public const int FallingDamageVDampingZ = 0x0AF4;

		///<summary><![CDATA[float]]></summary>
		public const int FallingDamageFactor = 0x0AF8;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData08 = 0x0AFC;

		///<summary><![CDATA[bool]]></summary>
		public const int UseBlockedHitDamage = 0x0B08;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData09 = 0x0B09;

	}

	public class UTslVehicleWheel
	{
		///<summary><![CDATA[float]]></summary>
		public const int Health = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int HealthMax = 0x010C;

		///<summary><![CDATA[FName]]></summary>
		public const int TireBoneName = 0x0110;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseTireLink = 0x0118;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0119;

		///<summary><![CDATA[int]]></summary>
		public const int TireLinkIndex = 0x011C;

		///<summary><![CDATA[float]]></summary>
		public const int LongSlipSkidThreshold = 0x0120;

		///<summary><![CDATA[float]]></summary>
		public const int LateralSlipSkidThreshold = 0x0124;

		///<summary><![CDATA[float]]></summary>
		public const int SpringCompressionLandingThreshold = 0x0128;

		///<summary><![CDATA[bool]]></summary>
		public const int bManualSuspensionSoundControl = 0x012C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x012D;

		///<summary><![CDATA[FVector]]></summary>
		public const int WheelEffectOffset = 0x0130;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x013C;

		///<summary><![CDATA[UTslWheelEffectType *]]></summary>
		public const int RollEffect = 0x0140;

		///<summary><![CDATA[UTslWheelEffectType *]]></summary>
		public const int SkidAccelEffect = 0x0148;

		///<summary><![CDATA[UTslWheelEffectType *]]></summary>
		public const int SkidEffect = 0x0150;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PuncturedParticleClass = 0x0158;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PuncturedSparkParticleClass = 0x0160;

		///<summary><![CDATA[float]]></summary>
		public const int slipThresholdForPunkSpark = 0x0168;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x016C;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int LandingSound = 0x0170;

		///<summary><![CDATA[bool]]></summary>
		public const int bApplyForceOnPuncture = 0x0178;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0179;

		///<summary><![CDATA[float]]></summary>
		public const int PunctureForce = 0x017C;

		///<summary><![CDATA[float]]></summary>
		public const int PunctureVelocityScalar = 0x0180;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData05 = 0x0184;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int TslParticleRoll = 0x0190;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int TslParticleSkid = 0x0198;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int TslParticleAccelSkid = 0x01A0;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int TslParticlePunctureSpark = 0x01A8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData06 = 0x01B0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AudioCom = 0x01B8;

		///<summary><![CDATA[float]]></summary>
		public const int MinZVelocityForSuspensionSound = 0x01C0;

		///<summary><![CDATA[unsigned char[0x3C]]]></summary>
		public const int UnknownData07 = 0x01C4;

		///<summary><![CDATA[float]]></summary>
		public const int TotalSpeedKmPerHour = 0x0200;

		///<summary><![CDATA[float]]></summary>
		public const int Slip = 0x0204;

		///<summary><![CDATA[bool]]></summary>
		public const int UseRoll = 0x0208;

		///<summary><![CDATA[bool]]></summary>
		public const int UseSkid = 0x0209;

		///<summary><![CDATA[bool]]></summary>
		public const int UseAccelSkid = 0x020A;

		///<summary><![CDATA[bool]]></summary>
		public const int bHasLastStatus = 0x020B;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x020C;

	}

	public class UTslAnimInstance
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int WeaponFire = 0x0378;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int WeaponFireCycle = 0x0388;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipPrimary = 0x0398;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipSecondary = 0x03A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EqupiSidearm = 0x03B8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipMelee = 0x03C8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipThrown = 0x03D8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UnEquipPrimary = 0x03E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UnEquipSecondary = 0x03F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UnEqupiSidearm = 0x0408;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UnEquipMelee = 0x0418;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UnEquipThrown = 0x0428;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ToggleFireMode = 0x0438;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadTactical = 0x0448;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadCharge = 0x0458;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadByOneStart = 0x0468;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadByOneStop = 0x0478;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadByOneSingle = 0x0488;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipThrownGrenade = 0x0498;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipThrownMolotov = 0x04A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int EquipThrownOther = 0x04B8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ThrowPrepare = 0x04C8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ThrowCooking = 0x04D8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ThrowStart = 0x04E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ThrowDrop = 0x04F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int LandHeavy = 0x0508;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int LandExtreme = 0x0518;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadCancel = 0x0528;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int CharacterPickup = 0x0538;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int UnarmedAttack = 0x0548;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int PowerupUsed = 0x0558;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ChangeCharacterAppearance = 0x0568;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCastStart = 0x0578;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCastCancel = 0x0588;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCastFinish = 0x0598;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x05A8;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int CharacterReference = 0x05B0;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int CharacterMesh_CP = 0x05B8;

		///<summary><![CDATA[TEnumAsByte<EAnimPawnState>]]></summary>
		public const int PreEvalPawnState = 0x05C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x05C1;

		///<summary><![CDATA[float]]></summary>
		public const int LocomotionSpeed_CP = 0x05C4;

		///<summary><![CDATA[float]]></summary>
		public const int LocomotionSpeed2D_CP = 0x05C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsMoving_CP = 0x05CC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x05CD;

		///<summary><![CDATA[float]]></summary>
		public const int LocomotionDirection_CP = 0x05D0;

		///<summary><![CDATA[float]]></summary>
		public const int LocomotionJumpDirection_CP = 0x05D4;

		///<summary><![CDATA[float]]></summary>
		public const int LeanYaw_CP = 0x05D8;

		///<summary><![CDATA[FRotator]]></summary>
		public const int LastAbsoluteDirection_CP = 0x05DC;

		///<summary><![CDATA[FRotator]]></summary>
		public const int ControlRotation_CP = 0x05E8;

		///<summary><![CDATA[FRotator]]></summary>
		public const int ControlRotationLastMovement_CP = 0x05F4;

		///<summary><![CDATA[FRotator]]></summary>
		public const int CharacterRotation_CP = 0x0600;

		///<summary><![CDATA[TEnumAsByte<EAnimStance>]]></summary>
		public const int Stance_CP = 0x060C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsSprintingFast_CP = 0x060D;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsSprinting_CP = 0x060E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData03 = 0x060F;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponGripType_CP = 0x0610;

		///<summary><![CDATA[float]]></summary>
		public const int SprintAlpha_CP = 0x0614;

		///<summary><![CDATA[float]]></summary>
		public const int SprintLocoAlpha_CP = 0x0618;

		///<summary><![CDATA[float]]></summary>
		public const int SprintValue_CP = 0x061C;

		///<summary><![CDATA[bool]]></summary>
		public const int bLocalQuickThrowHigh_CP = 0x0620;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0621;

		///<summary><![CDATA[float]]></summary>
		public const int LocalThrowModeSwitchAlpha_CP = 0x0624;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsJumping_CP = 0x0628;

		///<summary><![CDATA[bool]]></summary>
		public const int bJumpForward_CP = 0x0629;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsSwimming_CP = 0x062A;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsUnderWater_CP = 0x062B;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsDBNO_CP = 0x062C;

		///<summary><![CDATA[TEnumAsByte<EAnimStance>]]></summary>
		public const int DBNOEntryStance = 0x062D;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsReviving_CP = 0x062E;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsUpperbody_CP = 0x062F;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsTransitioning_CP = 0x0630;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x0631;

		///<summary><![CDATA[int]]></summary>
		public const int PlayerID_CP = 0x0634;

		///<summary><![CDATA[int]]></summary>
		public const int AirCraftIDAnim_CP = 0x0638;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsEquippingPistol_CP = 0x063C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x063D;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int PistolEquipMontageRefCP = 0x0640;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFlying_CP = 0x0648;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsLocalPlayer = 0x0649;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData07 = 0x064A;

		///<summary><![CDATA[float]]></summary>
		public const int LocalPlayerAlpha = 0x064C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsPunching_CP = 0x0650;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData08 = 0x0651;

		///<summary><![CDATA[float]]></summary>
		public const int PunchingAlpha_CP = 0x0654;

		///<summary><![CDATA[TEnumAsByte<EAnimWeaponType>]]></summary>
		public const int Weapon_CP = 0x0658;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsArmedWithGun_CP = 0x0659;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsArmedWithThrown_CP = 0x065A;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsPreparingThrow_CP = 0x065B;

		///<summary><![CDATA[float]]></summary>
		public const int ThrowableAdditionalAimYaw_CP = 0x065C;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int CurrentRecoilMontage_CP = 0x0660;

		///<summary><![CDATA[UBlendSpace1D *]]></summary>
		public const int GripBlendSpace_CP = 0x0668;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int GripBlendSpaceLH_CP = 0x0670;

		///<summary><![CDATA[float]]></summary>
		public const int LHGripIndex_CP = 0x0678;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsReloading_CP = 0x067C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData09 = 0x067D;

		///<summary><![CDATA[FVector]]></summary>
		public const int HandWeaponOffset_CP = 0x0680;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData10 = 0x068C;

		///<summary><![CDATA[FTransform]]></summary>
		public const int WeaponInertia_CP = 0x0690;

		///<summary><![CDATA[float]]></summary>
		public const int ReloadAlpha_CP = 0x06C0;

		///<summary><![CDATA[float]]></summary>
		public const int HandWeaponOffsetAlpha_CP = 0x06C4;

		///<summary><![CDATA[float]]></summary>
		public const int FinalRecoilAlpha_CP = 0x06C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData11 = 0x06CC;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_CP = 0x06D0;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_Pistol = 0x06D8;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_SMG = 0x06E0;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_Rifle = 0x06E8;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_Sniper = 0x06F0;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_Pistol_FPP = 0x06F8;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_SMG_FPP = 0x0700;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_Rifle_FPP = 0x0708;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int WeaponLocomotionBlendspace_Sniper_FPP = 0x0710;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaX_Scalar_CP = 0x0718;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaY_Scalar_CP = 0x071C;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaX_Clamp_CP = 0x0720;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaY_Clamp_CP = 0x0724;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_InerpSpeed_CP = 0x0728;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaX_Scalar_ADS_CP = 0x072C;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaY_Scalar_ADS_CP = 0x0730;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaX_Clamp_ADS_CP = 0x0734;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaY_Clamp_ADS_CP = 0x0738;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_InerpSpeed_ADS_CP = 0x073C;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_InerpSpeed_YawScalar_CP = 0x0740;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_YawToRollScalar_CP = 0x0744;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_YawToRollScalar_ADS_CP = 0x0748;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaRoll_Clamp_ADS_CP = 0x074C;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertiaRoll_Clamp_CP = 0x0750;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_Yaw_CP = 0x0754;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_Pitch_CP = 0x0758;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponInertia_Roll_CP = 0x075C;

		///<summary><![CDATA[float]]></summary>
		public const int SprintWeaponLoweringAlpha_CP = 0x0760;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilRollValue_CP = 0x0764;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilTimer_CP = 0x0768;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilRollRand_CP = 0x076C;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilTimerScale_CP = 0x0770;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData12 = 0x0774;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int RecoilRollCurve_CP = 0x0778;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponStabilityAlpha_CP = 0x0780;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponStabilityRefSpeed_CP = 0x0784;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int WeaponStabilityRefMapIn_CP = 0x0788;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int WeaponStabilityRefMapOut_CP = 0x0790;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponStabilityInterpSpeed_CP = 0x0798;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsAiming_CP = 0x079C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsScoping_CP = 0x079D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData13 = 0x079E;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponAimState_CP = 0x07A0;

		///<summary><![CDATA[float]]></summary>
		public const int SprintAlphaModifier_CP = 0x07A4;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsAimingBackward_CP = 0x07A8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData14 = 0x07A9;

		///<summary><![CDATA[float]]></summary>
		public const int Yaw_CP = 0x07AC;

		///<summary><![CDATA[float]]></summary>
		public const int RotationYaw_CP = 0x07B0;

		///<summary><![CDATA[float]]></summary>
		public const int Pitch_CP = 0x07B4;

		///<summary><![CDATA[float]]></summary>
		public const int YawNormalized_CP = 0x07B8;

		///<summary><![CDATA[float]]></summary>
		public const int DesiredPitch_CP = 0x07BC;

		///<summary><![CDATA[unsigned char]]></summary>
		public const int AimDirectionCardinal_CP = 0x07C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData15 = 0x07C1;

		///<summary><![CDATA[FRotator]]></summary>
		public const int AORot_CP = 0x07C4;

		///<summary><![CDATA[FRotator]]></summary>
		public const int AORotBackwards_CP = 0x07D0;

		///<summary><![CDATA[float]]></summary>
		public const int SwimmingPitch_CP = 0x07DC;

		///<summary><![CDATA[float]]></summary>
		public const int ForceAddAimOffset_CP = 0x07E0;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponCollisionAlpha_CP = 0x07E4;

		///<summary><![CDATA[bool]]></summary>
		public const int bWeaponObstructedHigh_CP = 0x07E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFalling_CP = 0x07E9;

		///<summary><![CDATA[bool]]></summary>
		public const int bWasFalling_CP = 0x07EA;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData16 = 0x07EB;

		///<summary><![CDATA[float]]></summary>
		public const int FallingAlpha_CP = 0x07EC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int FallingMap2D = 0x07F0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int FallingMapZ = 0x07F8;

		///<summary><![CDATA[bool]]></summary>
		public const int bForceFall_CP = 0x0800;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData17 = 0x0801;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontageFallingRifle_CP = 0x0808;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontageFallingUnarmed_CP = 0x0810;

		///<summary><![CDATA[float]]></summary>
		public const int LandingAlpha_CP = 0x0818;

		///<summary><![CDATA[bool]]></summary>
		public const int bLocalForceProne_CP = 0x081C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData18 = 0x081D;

		///<summary><![CDATA[float]]></summary>
		public const int JumpHeight_CP = 0x0820;

		///<summary><![CDATA[float]]></summary>
		public const int FallHeight_CP = 0x0824;

		///<summary><![CDATA[FVector]]></summary>
		public const int JumpStartLocation_CP = 0x0828;

		///<summary><![CDATA[FVector]]></summary>
		public const int LandPredictionVector_CP = 0x0834;

		///<summary><![CDATA[float]]></summary>
		public const int LeanLeftAlpha_CP = 0x0840;

		///<summary><![CDATA[float]]></summary>
		public const int LeanRightAlpha_CP = 0x0844;

		///<summary><![CDATA[float]]></summary>
		public const int LeanTwoSideAlpha_CP = 0x0848;

		///<summary><![CDATA[float]]></summary>
		public const int LeanLeftApplyTranslation_CP = 0x084C;

		///<summary><![CDATA[float]]></summary>
		public const int LeanInterpSpeed_CP = 0x0850;

		///<summary><![CDATA[float]]></summary>
		public const int LeanInterpSpeedCollisionClamp_CP = 0x0854;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseLinearLeanInterp = 0x0858;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFreefalling_CP = 0x0859;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsParachuting_CP = 0x085A;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData19 = 0x085B;

		///<summary><![CDATA[float]]></summary>
		public const int FreefallX_CP = 0x085C;

		///<summary><![CDATA[float]]></summary>
		public const int FreefallY_CP = 0x0860;

		///<summary><![CDATA[float]]></summary>
		public const int FreeFallAlpha_CP = 0x0864;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsParachuteLanding_CP = 0x0868;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsParachuteMoving_CP = 0x0869;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData20 = 0x086A;

		///<summary><![CDATA[float]]></summary>
		public const int Freefall_Yaw_CP = 0x086C;

		///<summary><![CDATA[float]]></summary>
		public const int Freefall_Pitch_CP = 0x0870;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFreelooking_CP = 0x0874;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsMeleeAttacking_CP = 0x0875;

		///<summary><![CDATA[bool]]></summary>
		public const int bLocalForceRotationHipLeft_CP = 0x0876;

		///<summary><![CDATA[bool]]></summary>
		public const int bLocalForceRotationHipRight_CP = 0x0877;

		///<summary><![CDATA[bool]]></summary>
		public const int bLocalForceRotationAimed_CP = 0x0878;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData21 = 0x0879;

		///<summary><![CDATA[float]]></summary>
		public const int RotationPlayrateAimed_CP = 0x087C;

		///<summary><![CDATA[float]]></summary>
		public const int RotationPlayrateAimedAdditiveSpine_CP = 0x0880;

		///<summary><![CDATA[FRotator]]></summary>
		public const int LastRotation_CP = 0x0884;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Freelook_Body_CP = 0x0890;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Freelook_Delta_CP = 0x089C;

		///<summary><![CDATA[int]]></summary>
		public const int IdleIndex_CP = 0x08A8;

		///<summary><![CDATA[int]]></summary>
		public const int LastIdleIndex_CP = 0x08AC;

		///<summary><![CDATA[float]]></summary>
		public const int IdleTimer_CP = 0x08B0;

		///<summary><![CDATA[float]]></summary>
		public const int IdleTriggerRandom = 0x08B4;

		///<summary><![CDATA[float]]></summary>
		public const int IdleTriggerTimeMin_CP = 0x08B8;

		///<summary><![CDATA[float]]></summary>
		public const int IdleTriggerTimeVariation_CP = 0x08BC;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotPrimary_CP = 0x08C0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotSecondary_CP = 0x08F0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotMelee_CP = 0x0920;

		///<summary><![CDATA[FTransform]]></summary>
		public const int SlotThrown_CP = 0x0950;

		///<summary><![CDATA[FVector]]></summary>
		public const int SlotPrimary_Offset_CP = 0x0980;

		///<summary><![CDATA[FVector]]></summary>
		public const int SlotSecondary_Offset_CP = 0x098C;

		///<summary><![CDATA[FVector]]></summary>
		public const int SlotPrimary_Location_CP = 0x0998;

		///<summary><![CDATA[FVector]]></summary>
		public const int SlotSecondary_Location_CP = 0x09A4;

		///<summary><![CDATA[FVector]]></summary>
		public const int SlotMelee_Location_CP = 0x09B0;

		///<summary><![CDATA[FVector]]></summary>
		public const int SlotThrown_Location_CP = 0x09BC;

		///<summary><![CDATA[FRotator]]></summary>
		public const int SlotPrimary_Rotation_CP = 0x09C8;

		///<summary><![CDATA[FRotator]]></summary>
		public const int SlotSecondary_Rotation_CP = 0x09D4;

		///<summary><![CDATA[FRotator]]></summary>
		public const int SlotMelee_Rotation_CP = 0x09E0;

		///<summary><![CDATA[FRotator]]></summary>
		public const int SlotThrown_Rotation_CP = 0x09EC;

		///<summary><![CDATA[float]]></summary>
		public const int AnimDynamicsStandAlpha_CP = 0x09F8;

		///<summary><![CDATA[float]]></summary>
		public const int AnimDynamicsStandSprintAlpha_CP = 0x09FC;

		///<summary><![CDATA[float]]></summary>
		public const int AnimDynamicsCrouchAlpha_CP = 0x0A00;

		///<summary><![CDATA[float]]></summary>
		public const int AnimDynamicsProneAlpha_CP = 0x0A04;

		///<summary><![CDATA[FVector]]></summary>
		public const int EFCoat_CP = 0x0A08;

		///<summary><![CDATA[bool]]></summary>
		public const int bLocalFPP_CP = 0x0A14;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData22 = 0x0A15;

		///<summary><![CDATA[float]]></summary>
		public const int LocalFPPAlpha_CP = 0x0A18;

		///<summary><![CDATA[float]]></summary>
		public const int LocalFPPAlphaVehicleAimAO_CP = 0x0A1C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsInAircraft_CP = 0x0A20;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsDriver_CP = 0x0A21;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsSitting_CP = 0x0A22;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsInVehicle_CP = 0x0A23;

		///<summary><![CDATA[float]]></summary>
		public const int LocalSteerInput_CP = 0x0A24;

		///<summary><![CDATA[float]]></summary>
		public const int LocalSteerInputMoto_CP = 0x0A28;

		///<summary><![CDATA[float]]></summary>
		public const int LocalStopMoto_CP = 0x0A2C;

		///<summary><![CDATA[float]]></summary>
		public const int LocalThrottleInput_CP = 0x0A30;

		///<summary><![CDATA[FRotator]]></summary>
		public const int GasThighRot_CP = 0x0A34;

		///<summary><![CDATA[FRotator]]></summary>
		public const int GasAnkleRot_CP = 0x0A40;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData23 = 0x0A4C;

		///<summary><![CDATA[FTransform]]></summary>
		public const int GasKneeTransformX_CP = 0x0A50;

		///<summary><![CDATA[float]]></summary>
		public const int LocalBrakeInput_CP = 0x0A80;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData24 = 0x0A84;

		///<summary><![CDATA[FTransform]]></summary>
		public const int BrakeKneeTransform_CP = 0x0A90;

		///<summary><![CDATA[FRotator]]></summary>
		public const int BrakeAnkleRot_CP = 0x0AC0;

		///<summary><![CDATA[float]]></summary>
		public const int BackwardAOAlpha_CP = 0x0ACC;

		///<summary><![CDATA[float]]></summary>
		public const int AimBlendAlpha_CP = 0x0AD0;

		///<summary><![CDATA[bool]]></summary>
		public const int bHasContact_CP = 0x0AD4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData25 = 0x0AD5;

		///<summary><![CDATA[float]]></summary>
		public const int GroundContactMoto_CP = 0x0AD8;

		///<summary><![CDATA[float]]></summary>
		public const int AirControlPitchInput_CP = 0x0ADC;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DriverIK_CP = 0x0AE0;

		///<summary><![CDATA[float]]></summary>
		public const int PassengerIKAlpha_CP = 0x0B10;

		///<summary><![CDATA[FVector]]></summary>
		public const int DriverSpineLocWS_CP = 0x0B14;

		///<summary><![CDATA[EVehicleAnimType]]></summary>
		public const int VehicleSeatType_CP = 0x0B20;

		///<summary><![CDATA[bool]]></summary>
		public const int bMotoHasDriver_CP = 0x0B21;

		///<summary><![CDATA[bool]]></summary>
		public const int bVaultCanceled = 0x0B22;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVaulting_CP = 0x0B23;

		///<summary><![CDATA[float]]></summary>
		public const int AnimHairAlpha = 0x0B24;

		///<summary><![CDATA[float]]></summary>
		public const int VaultTimer_CP = 0x0B28;

		///<summary><![CDATA[float]]></summary>
		public const int VaultTimerLast_CP = 0x0B2C;

		///<summary><![CDATA[EVaultAnimType]]></summary>
		public const int LocalVaultType_CP = 0x0B30;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData26 = 0x0B31;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int VaultAnimSequence_CP = 0x0B38;

		///<summary><![CDATA[float]]></summary>
		public const int VaultAnimLength_CP = 0x0B40;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData27 = 0x0B44;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int VaultCurve_CP = 0x0B48;

		///<summary><![CDATA[float]]></summary>
		public const int VaultBlendInTime_CP = 0x0B50;

		///<summary><![CDATA[float]]></summary>
		public const int VaultBlendOutTime_CP = 0x0B54;

		///<summary><![CDATA[bool]]></summary>
		public const int bEndVaultToFall_CP = 0x0B58;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData28 = 0x0B59;

		///<summary><![CDATA[float]]></summary>
		public const int VaultBlendOutProgressTime_CP = 0x0B5C;

		///<summary><![CDATA[float]]></summary>
		public const int VaultBlendOutExactTime_CP = 0x0B60;

		///<summary><![CDATA[float]]></summary>
		public const int VaultLastActionTimer_CP = 0x0B64;

		///<summary><![CDATA[float]]></summary>
		public const int VaultAnimTime_CP = 0x0B68;

		///<summary><![CDATA[float]]></summary>
		public const int VaultBlendOutTimeBuffer = 0x0B6C;

		///<summary><![CDATA[ECastAnim]]></summary>
		public const int CurrentCastAnim_CP = 0x0B70;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsActiveRagdoll_CP = 0x0B71;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData29 = 0x0B72;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponIKLH_CP = 0x0B74;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponIKRH_CP = 0x0B78;

		///<summary><![CDATA[float]]></summary>
		public const int MontageIKLH_CP = 0x0B7C;

		///<summary><![CDATA[float]]></summary>
		public const int MontageIKRH_CP = 0x0B80;

		///<summary><![CDATA[float]]></summary>
		public const int IgnoreWeaponTransform_CP = 0x0B84;

		///<summary><![CDATA[float]]></summary>
		public const int PickupIKAlpha_CP = 0x0B88;

		///<summary><![CDATA[float]]></summary>
		public const int TargetIKRH_CP = 0x0B8C;

		///<summary><![CDATA[float]]></summary>
		public const int TargetIKLH_CP = 0x0B90;

		///<summary><![CDATA[float]]></summary>
		public const int ForceLegsFromAnim_CP = 0x0B94;

		///<summary><![CDATA[ATslWeapon_Gun *]]></summary>
		public const int LastGunCache_CP = 0x0B98;

		///<summary><![CDATA[ATslWheeledVehicle *]]></summary>
		public const int CachedWheeledVehicle_CP = 0x0BA0;

		///<summary><![CDATA[ATslFloatingVehicle *]]></summary>
		public const int CachedFloatingVehicle_CP = 0x0BA8;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int PassengerAimBS_CP = 0x0BB0;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int PassengerTransitionOut_CP = 0x0BB8;

		///<summary><![CDATA[UBlendSpaceBase *]]></summary>
		public const int PassengerTransitionIn_CP = 0x0BC0;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int PassengerIdle_Rifle_CP = 0x0BC8;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int PassengerIdle_Unarmed_CP = 0x0BD0;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int PassengerIdle_Grenade_CP = 0x0BD8;

		///<summary><![CDATA[UAnimSequenceBase *]]></summary>
		public const int PassengerIdle_Melee_CP = 0x0BE0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CurveAimState_CP = 0x0BE8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData30 = 0x0BF0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsLOD1 = 0x0BF8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsLOD2 = 0x0BF9;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsWearingCoat = 0x0BFA;

		///<summary><![CDATA[unsigned char[0x9]]]></summary>
		public const int UnknownData31 = 0x0BFB;

		///<summary><![CDATA[float]]></summary>
		public const int AnimatedHairsAlpha = 0x0C04;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsParentalControl = 0x0C08;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData32 = 0x0C09;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontageMeleeAttack1 = 0x0C10;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontageMeleeAttack2 = 0x0C18;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontageMeleeAttack3 = 0x0C20;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontagePunchingAttack1 = 0x0C28;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontagePunchingAttack2 = 0x0C30;

		///<summary><![CDATA[UAnimMontage *]]></summary>
		public const int MontagePunchingAttack3 = 0x0C38;

		///<summary><![CDATA[float]]></summary>
		public const int FPPSprintAnimScalar = 0x0C40;

		///<summary><![CDATA[FVector]]></summary>
		public const int FPP_PrimaryAndSecondaryItemOffset = 0x0C44;

		///<summary><![CDATA[float]]></summary>
		public const int PunchingAlphaOneTarget_CP = 0x0C50;

		///<summary><![CDATA[float]]></summary>
		public const int PunchingAlphaInterpSpeed = 0x0C54;

		///<summary><![CDATA[float]]></summary>
		public const int SprintWeaponLoweringScalar_CP = 0x0C58;

		///<summary><![CDATA[float]]></summary>
		public const int ThrowStateSwitchInterpSpeed = 0x0C5C;

		///<summary><![CDATA[float]]></summary>
		public const int VaultingEvalTimeout = 0x0C60;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData33 = 0x0C64;

		///<summary><![CDATA[UAnimDB *]]></summary>
		public const int UnarmedAnimDB_CP = 0x0C68;

		///<summary><![CDATA[UAnimDB *]]></summary>
		public const int RifleAnimDB_CP = 0x0C70;

		///<summary><![CDATA[UAnimDB *]]></summary>
		public const int MeleeAnimDB_CP = 0x0C78;

		///<summary><![CDATA[UAnimDB *]]></summary>
		public const int GrenadeAnimDB_CP = 0x0C80;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData34 = 0x0C88;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotPrimary_Male_CP = 0x0C90;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotSecondary_Male_CP = 0x0CC0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotMelee_Male_CP = 0x0CF0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotThrown_Male_CP = 0x0D20;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotPrimary_Female_CP = 0x0D50;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotSecondary_Female_CP = 0x0D80;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotThrown_Female_CP = 0x0DB0;

		///<summary><![CDATA[FTransform]]></summary>
		public const int DefaultSlotMelee_Female_CP = 0x0DE0;

		///<summary><![CDATA[float]]></summary>
		public const int SprintLocoTimeMultiplier = 0x0E10;

		///<summary><![CDATA[float]]></summary>
		public const int SprintLocoTimeMultiplier_FPP = 0x0E14;

		///<summary><![CDATA[float]]></summary>
		public const int SprintLocoTimeAlphaScalar = 0x0E18;

		///<summary><![CDATA[float]]></summary>
		public const int SprintLocoTimeAlphaScalar_FPP = 0x0E1C;

	}

	public class UTslDamageType
	{
		///<summary><![CDATA[TEnumAsByte<EDamageTypeCategory>]]></summary>
		public const int DamageTypeCategory = 0x0040;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0041;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int KillIcon = 0x0048;

		///<summary><![CDATA[UForceFeedbackEffect *]]></summary>
		public const int HitForceFeedback = 0x0060;

		///<summary><![CDATA[UForceFeedbackEffect *]]></summary>
		public const int KilledForceFeedback = 0x0068;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFallDamage = 0x0070;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0071;

		///<summary><![CDATA[TArray<FDamageRatioInfo>]]></summary>
		public const int DamageRatioInfos = 0x0078;

		///<summary><![CDATA[bool]]></summary>
		public const int HitReaction = 0x0088;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0089;

	}

	public class ATslHUD
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPossessPawnChange = 0x0548;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDisplaySystemMessage = 0x0558;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDisplayKilledMessage = 0x0568;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKillCountChanged = 0x0578;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyHit = 0x0588;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTeamPlayerJoin = 0x0598;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnTeamPlayerRemove = 0x05A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyStartBuff = 0x05B8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyHealAmount = 0x05C8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyRestrictingPlayArea = 0x05D8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyNextGasIn = 0x05E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyDisplayMessage = 0x05F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyWeaponChange = 0x0608;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyWeaponUnarm = 0x0618;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyHeal = 0x0628;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyDropSlotOnOtherContainer = 0x0638;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyBlockingWidgetOpened = 0x0648;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnNotifyHealItemSelector_Gamepad = 0x0658;

		///<summary><![CDATA[int]]></summary>
		public const int BluezoneState = 0x0668;

		///<summary><![CDATA[bool]]></summary>
		public const int bGpsReset = 0x066C;

		///<summary><![CDATA[bool]]></summary>
		public const int bBluezoneReset = 0x066D;

		///<summary><![CDATA[bool]]></summary>
		public const int bPlayzoneReset = 0x066E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x066F;

		///<summary><![CDATA[float]]></summary>
		public const int GpsResetTimeCheck = 0x0670;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseHighlight = 0x0674;

		///<summary><![CDATA[unsigned char[0x33]]]></summary>
		public const int UnknownData01 = 0x0675;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int TimePlaceBg = 0x06A8;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int PrimaryWeapBg = 0x06C0;

		///<summary><![CDATA[FCanvasIcon]]></summary>
		public const int SecondaryWeapBg = 0x06D8;

		///<summary><![CDATA[FCanvasIcon[0x5]]]></summary>
		public const int Crosshair = 0x06F0;

		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData02 = 0x0768;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int HitNotifyTexture = 0x07E0;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int HUDMainTexture = 0x07E8;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int HUDAssets02Texture = 0x07F0;

		///<summary><![CDATA[UTexture2D *]]></summary>
		public const int LowHealthOverlayTexture = 0x07F8;

		///<summary><![CDATA[UFont *]]></summary>
		public const int BigFont = 0x0800;

		///<summary><![CDATA[UFont *]]></summary>
		public const int NormalFont = 0x0808;

		///<summary><![CDATA[unsigned char[0x60]]]></summary>
		public const int UnknownData03 = 0x0810;

		///<summary><![CDATA[UTslSceneCaptureWorld *]]></summary>
		public const int SceneCaptureWorld = 0x0870;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData04 = 0x0878;

		///<summary><![CDATA[FVector]]></summary>
		public const int NextPlayzonePosition = 0x0888;

		///<summary><![CDATA[float]]></summary>
		public const int NextPlayzoneRadius = 0x0894;

		///<summary><![CDATA[FVector]]></summary>
		public const int CurrentPlayzonePosition = 0x0898;

		///<summary><![CDATA[float]]></summary>
		public const int CurrentPlayzoneRadius = 0x08A4;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData05 = 0x08A8;

		///<summary><![CDATA[FString]]></summary>
		public const int SceneCapturePackageName = 0x08F8;

		///<summary><![CDATA[UHighlightSession *]]></summary>
		public const int HighlightSession = 0x0908;

		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData06 = 0x0910;

	}

	public class UTslSettings
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int DialogUMGWidgetClass = 0x0028;

		///<summary><![CDATA[bool]]></summary>
		public const int bSupportKillcamEnable = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[int]]></summary>
		public const int MaxReplaysForNullStreamer = 0x0034;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Item = 0x0038;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Character = 0x003C;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Weapon = 0x0040;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Vehicle = 0x0044;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Parachute = 0x0048;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Door = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int RepDistance_Window = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int RepFrequency_Character = 0x0054;

		///<summary><![CDATA[float]]></summary>
		public const int RepFrequency_WheeledVehicle = 0x0058;

		///<summary><![CDATA[float]]></summary>
		public const int RepFrequency_FloatingVehicle = 0x005C;

		///<summary><![CDATA[float]]></summary>
		public const int RepFrequency_Parachute = 0x0060;

		///<summary><![CDATA[float]]></summary>
		public const int RepFrequency_Aircraft = 0x0064;

		///<summary><![CDATA[float]]></summary>
		public const int RepFrequency_CarePackage = 0x0068;

		///<summary><![CDATA[float]]></summary>
		public const int RepVehicle_SpawnDistance = 0x006C;

		///<summary><![CDATA[float]]></summary>
		public const int RepVehicle_UnspawnDistance = 0x0070;

		///<summary><![CDATA[FRigidBodyErrorCorrection]]></summary>
		public const int RepVehicle_PhysicErrorCorrection = 0x0074;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterCorrection_MaxSpeed = 0x0090;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterCorrection_MaxSpeedPositionError = 0x0094;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterCorrection_ZeroSpeedPositionError = 0x0098;

		///<summary><![CDATA[bool]]></summary>
		public const int bBattlEyeEnabled = 0x009C;

		///<summary><![CDATA[bool]]></summary>
		public const int bBattlEyeEnabledInPIE = 0x009D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x009E;

		///<summary><![CDATA[float]]></summary>
		public const int BattlEyeReliablePacketIntervalOnClient = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int BattlEyeReliablePacketIntervalOnServer = 0x00A4;

		///<summary><![CDATA[bool]]></summary>
		public const int bChineseLicensing = 0x00A8;

		///<summary><![CDATA[bool]]></summary>
		public const int bKoreanRating = 0x00A9;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x00AA;

		///<summary><![CDATA[float]]></summary>
		public const int GameStateLogInterval = 0x00AC;

		///<summary><![CDATA[float]]></summary>
		public const int ServerStatLogInterval = 0x00B0;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterPositionLogInterval = 0x00B4;

		///<summary><![CDATA[float]]></summary>
		public const int DestructibleComponentMaxDrawDistance = 0x00B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x00BC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CharacterClassToPlay = 0x00C0;

		///<summary><![CDATA[TArray<FBoneBinding>]]></summary>
		public const int BoneMapping = 0x00C8;

		///<summary><![CDATA[TArray<FStringAssetReference>]]></summary>
		public const int TestVehicleClasses = 0x00D8;

		///<summary><![CDATA[TArray<FStringAssetReference>]]></summary>
		public const int TestFloatingVehicleClasses = 0x00E8;

		///<summary><![CDATA[TArray<FChineseLicensingDefaultCustomizeData>]]></summary>
		public const int ChineseLicensingDefaultCustomizeData = 0x00F8;

		///<summary><![CDATA[float]]></summary>
		public const int StoppedWheeledVehicleSpeedThreshold = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int StoppedFloatingVehicleSpeedThreshold = 0x010C;

		///<summary><![CDATA[float]]></summary>
		public const int LastDriverDuration = 0x0110;

		///<summary><![CDATA[float]]></summary>
		public const int InteractableDistanceToleranceOnDedicatedServer = 0x0114;

		///<summary><![CDATA[float]]></summary>
		public const int InteractableDistance_ItemDefault = 0x0118;

		///<summary><![CDATA[float]]></summary>
		public const int InteractableSpeed_ItemDefault = 0x011C;

		///<summary><![CDATA[FInteractionCollisionData]]></summary>
		public const int InteractionCollisionForFPS = 0x0120;

		///<summary><![CDATA[FInteractionCollisionData]]></summary>
		public const int InteractionCollisionForTPS = 0x0134;

		///<summary><![CDATA[bool]]></summary>
		public const int bPreventFinishMatchInPIE = 0x0148;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableInitialItemDonator = 0x0149;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData04 = 0x014A;

		///<summary><![CDATA[float]]></summary>
		public const int InventoryMaxSpaceDefault = 0x014C;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int ErrorIconTexture = 0x0150;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int LoadingIconTexture = 0x0158;

		///<summary><![CDATA[TArray<UObject * >]]></summary>
		public const int AssetsForPackageIntegrity = 0x0160;

		///<summary><![CDATA[float]]></summary>
		public const int UICrosshairDistance = 0x0170;

		///<summary><![CDATA[float]]></summary>
		public const int UICrosshairInterpSpeed = 0x0174;

		///<summary><![CDATA[float]]></summary>
		public const int UICrosshairDisableDistance = 0x0178;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData05 = 0x017C;

		///<summary><![CDATA[float]]></summary>
		public const int GameTimeMultiplier = 0x0188;

		///<summary><![CDATA[bool]]></summary>
		public const int AimOffsetRayCast = 0x018C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x018D;

		///<summary><![CDATA[float]]></summary>
		public const int MeleeWeaponPitchMin = 0x0190;

		///<summary><![CDATA[float]]></summary>
		public const int MeleeWeaponPitchMax = 0x0194;

		///<summary><![CDATA[bool]]></summary>
		public const int EnableThrowLagCompensation = 0x0198;

		///<summary><![CDATA[bool]]></summary>
		public const int FullRecoilRecovery = 0x0199;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData07 = 0x019A;

		///<summary><![CDATA[FLevelLoadingBoostParameters]]></summary>
		public const int LevelLoadingBoostParameters = 0x019C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x01AC;

		///<summary><![CDATA[TArray<FNearClippingValue>]]></summary>
		public const int NearClippingValues = 0x01B0;

		///<summary><![CDATA[TArray<FTslGame_FCustomizableCategoryData>]]></summary>
		public const int CustomizableCategoryData = 0x01C0;

		///<summary><![CDATA[TArray<FCustomizableActionName>]]></summary>
		public const int CustomizableActionNames = 0x01D0;

		///<summary><![CDATA[TArray<FTslGame_FCustomizableAxisName>]]></summary>
		public const int CustomizableAxisNames = 0x01E0;

		///<summary><![CDATA[TArray<FCustomizableMouseSensitiveName>]]></summary>
		public const int CustomizableMouseSensitiveNames = 0x01F0;

		///<summary><![CDATA[TArray<FCustomizableGamePadSensitiveName>]]></summary>
		public const int CustomizableGamePadSensitiveNames = 0x0200;

		///<summary><![CDATA[TArray<FSurportQualityLevel>]]></summary>
		public const int SupportedQualityLevels = 0x0210;

		///<summary><![CDATA[TArray<FScreenResolution>]]></summary>
		public const int SupportedScreenResolutions = 0x0220;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int MouseSensitivityCurve = 0x0230;

		///<summary><![CDATA[FStringAssetReference]]></summary>
		public const int GammaCurve = 0x0240;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int CultureNames = 0x0250;

		///<summary><![CDATA[TArray<FColorBlindType>]]></summary>
		public const int ColorBlindTypes = 0x0260;

		///<summary><![CDATA[TArray<FPresetColor>]]></summary>
		public const int CrosshairColors = 0x0270;

		///<summary><![CDATA[TArray<FKeyInputModeName>]]></summary>
		public const int KeyInputModeNames = 0x0280;

		///<summary><![CDATA[TArray<FUiType>]]></summary>
		public const int MiniMapTypeList = 0x0290;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumScreenResolutionRatio = 0x02A0;

		///<summary><![CDATA[FScreenResolution]]></summary>
		public const int MinimumScreenResolution = 0x02A4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData09 = 0x02AC;

		///<summary><![CDATA[TArray<FTeamColorAndIcon>]]></summary>
		public const int OverrideMarkerColorAndIcons = 0x02B0;

		///<summary><![CDATA[float]]></summary>
		public const int PunchClientHitLeeway_Attacker = 0x02C0;

		///<summary><![CDATA[float]]></summary>
		public const int PunchClientHitLeeway_Victim = 0x02C4;

		///<summary><![CDATA[float]]></summary>
		public const int ClientSideHitLeeway = 0x02C8;

		///<summary><![CDATA[float]]></summary>
		public const int LogClientSideHitLeeway = 0x02CC;

		///<summary><![CDATA[float]]></summary>
		public const int ClientSideOriginDistanceLeeway = 0x02D0;

		///<summary><![CDATA[float]]></summary>
		public const int TravelDistanceLeeway = 0x02D4;

		///<summary><![CDATA[float]]></summary>
		public const int AllowedHitLag = 0x02D8;

		///<summary><![CDATA[float]]></summary>
		public const int LogMinHitLag = 0x02DC;

		///<summary><![CDATA[float]]></summary>
		public const int HackDetectionSpeed = 0x02E0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData10 = 0x02E4;

		///<summary><![CDATA[TArray<FOverrideScalability>]]></summary>
		public const int OverrideScalabilities = 0x02E8;

		///<summary><![CDATA[float]]></summary>
		public const int FakeDoorBlockMaxY = 0x02F8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData11 = 0x02FC;

		///<summary><![CDATA[TArray<FReportCauseData>]]></summary>
		public const int ReportCauses = 0x0300;

		///<summary><![CDATA[TArray<FSubjectToReport>]]></summary>
		public const int SubjectToReport = 0x0310;

		///<summary><![CDATA[float]]></summary>
		public const int FreelookRecoveryInterpSpeed = 0x0320;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData12 = 0x0324;

		///<summary><![CDATA[TMap<FName,float>]]></summary>
		public const int GamepadSensitiveMultiplier = 0x0328;

		///<summary><![CDATA[float]]></summary>
		public const int GamePadInnerDeadZone = 0x0378;

		///<summary><![CDATA[float]]></summary>
		public const int GamePadOutDeadZoneAcceleration = 0x037C;

		///<summary><![CDATA[float]]></summary>
		public const int GamePadOutMaxAxisValue = 0x0380;

		///<summary><![CDATA[float]]></summary>
		public const int GamePadAccelerationStandardFps = 0x0384;

		///<summary><![CDATA[float]]></summary>
		public const int AimAssistDecisionRadius = 0x0388;

		///<summary><![CDATA[bool]]></summary>
		public const int bApplyInputValue = 0x038C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIgnorePadSensitive = 0x038D;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData13 = 0x038E;

		///<summary><![CDATA[float]]></summary>
		public const int InsensitiveZone = 0x0390;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData14 = 0x0394;

		///<summary><![CDATA[TArray<FAimAssistData>]]></summary>
		public const int AimCameraAssists = 0x0398;

		///<summary><![CDATA[TArray<FAimAssistData>]]></summary>
		public const int ADSCameraAssists = 0x03A8;

		///<summary><![CDATA[TArray<FAimAssistData>]]></summary>
		public const int Scope2XCameraAssists = 0x03B8;

		///<summary><![CDATA[TArray<FAimAssistData>]]></summary>
		public const int Scope4XCameraAssists = 0x03C8;

		///<summary><![CDATA[TArray<FAimAssistData>]]></summary>
		public const int Scope8XCameraAssists = 0x03D8;

		///<summary><![CDATA[TArray<FAimAssistData>]]></summary>
		public const int Scope15XCameraAssists = 0x03E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsESports = 0x03F8;

		///<summary><![CDATA[unsigned char[0x57]]]></summary>
		public const int UnknownData15 = 0x03F9;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int LoadedMouseSensitivityCurve = 0x0450;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int LoadedGammaCurve = 0x0458;

		///<summary><![CDATA[UTextureRenderTarget2D *]]></summary>
		public const int CharacterStudioRenderTarget = 0x0460;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int AnimatableHairNames = 0x0468;

		///<summary><![CDATA[TMap<FName,float>]]></summary>
		public const int NotifyDistanceLimitMap = 0x0478;

	}

	public class UTslGameInstance
	{
		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int PersistentUClassPaths = 0x00F0;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int PersistentUClasses = 0x0100;

		///<summary><![CDATA[FString]]></summary>
		public const int WelcomeScreenMap = 0x0110;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseLobbyWidget = 0x0120;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0121;

		///<summary><![CDATA[int]]></summary>
		public const int LobbyWidgetZOrder = 0x0124;

		///<summary><![CDATA[ULobbyLink *]]></summary>
		public const int LobbyLink = 0x0128;

		///<summary><![CDATA[UVivoxManager *]]></summary>
		public const int VivoxManager = 0x0130;

		///<summary><![CDATA[UReporterManager *]]></summary>
		public const int ReporterManager = 0x0138;

		///<summary><![CDATA[FTslStartParameter]]></summary>
		public const int StartParamter = 0x0140;

		///<summary><![CDATA[unsigned char[0xC8]]]></summary>
		public const int UnknownData01 = 0x01C0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LobbyWidgetClass = 0x0288;

		///<summary><![CDATA[unsigned char[0x140]]]></summary>
		public const int UnknownData02 = 0x0290;

		///<summary><![CDATA[ULobbyWidget *]]></summary>
		public const int LobbyWidget = 0x03D0;

		///<summary><![CDATA[unsigned char[0xA8]]]></summary>
		public const int UnknownData03 = 0x03D8;

		///<summary><![CDATA[TArray<FReplayKillEventItem>]]></summary>
		public const int ReplayKillEventItems = 0x0480;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEnumerateReplayKillEventsDone = 0x0490;

		///<summary><![CDATA[unsigned char[0xA0]]]></summary>
		public const int UnknownData04 = 0x04A0;

		///<summary><![CDATA[TArray<FReplayGroggyEventItem>]]></summary>
		public const int ReplayGroggyEventItems = 0x0540;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnEnumerateReplayGroggyEventsDone = 0x0550;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData05 = 0x0560;

		///<summary><![CDATA[TArray<FReplayItem>]]></summary>
		public const int ReplayItemList = 0x0570;

		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData06 = 0x0580;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnGetReplayListDone = 0x05B8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnGotoTimelineDone = 0x05C8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnRecordStarted = 0x05D8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDownloadZippedReplayProgressDelegate = 0x05E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDownloadZippedReplayCompleteDelegate = 0x05F8;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData07 = 0x0608;

		///<summary><![CDATA[int]]></summary>
		public const int MaxReplaysForNullStreamer = 0x0630;

		///<summary><![CDATA[int]]></summary>
		public const int NumReplaysForNullStreamer = 0x0634;

		///<summary><![CDATA[int]]></summary>
		public const int NumReplaysToKeepForNullStreamer = 0x0638;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x063C;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKeepAndDeleteOldestReplaysDoneDelegate = 0x0640;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData09 = 0x0650;

		///<summary><![CDATA[UGameEventObserver *]]></summary>
		public const int GameEventObserver = 0x0658;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData10 = 0x0660;

		///<summary><![CDATA[FTslReplaySummary]]></summary>
		public const int ReplaySummaryForPlayback = 0x0678;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnGetReplaySummaryDone = 0x06F8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsStartedFromReplayListMap = 0x0708;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData11 = 0x0709;

		///<summary><![CDATA[ATslPlayerState *]]></summary>
		public const int CachedDemoPlayerState = 0x0710;

		///<summary><![CDATA[unsigned char[0xB8]]]></summary>
		public const int UnknownData12 = 0x0718;

	}

	public class ALobbyHUD
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x09B0;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CameraTransitionCurve = 0x09B8;

		///<summary><![CDATA[float]]></summary>
		public const int CameraTransitionElapsedTime = 0x09C0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsCameraTransitionPlaying = 0x09C4;

		///<summary><![CDATA[ELobbyCameraStates]]></summary>
		public const int LastCameraState = 0x09C5;

		///<summary><![CDATA[ELobbyCameraStates]]></summary>
		public const int FromCameraState = 0x09C6;

		///<summary><![CDATA[ELobbyCameraStates]]></summary>
		public const int ToCameraState = 0x09C7;

		///<summary><![CDATA[FName]]></summary>
		public const int MainMenuStreamingLevelName = 0x0A18;

		///<summary><![CDATA[FName]]></summary>
		public const int CustomizationStreamingLevelName = 0x0A20;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int FadeInOutCurve = 0x0A28;

		///<summary><![CDATA[ATslPostProcessEffect *]]></summary>
		public const int LobbyPPE = 0x0A30;

		///<summary><![CDATA[float]]></summary>
		public const int FadeInOutEffectElapsedTime = 0x0A38;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsFadeInOutEffectPlaying = 0x0A3C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0A3D;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int TimerHandle_FadeInOut = 0x0A40;

		///<summary><![CDATA[ATslPostProcessEffect *]]></summary>
		public const int MainMenuPPE = 0x0A48;

		///<summary><![CDATA[ELobbyBlurChangingStates]]></summary>
		public const int BlurChangingState = 0x0A50;

		///<summary><![CDATA[bool]]></summary>
		public const int bInitCameraTransition = 0x0A51;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData02 = 0x0A52;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnCreateCharacter = 0x0A58;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDestroyCharacter = 0x0A68;

		///<summary><![CDATA[FString]]></summary>
		public const int StartURL = 0x0A78;

		///<summary><![CDATA[TArray<UCoherentCommonBinder * >]]></summary>
		public const int CommonBinders = 0x0A88;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkSound = 0x0A98;

		///<summary><![CDATA[ACameraActor *]]></summary>
		public const int MainCamera = 0x0AA0;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData03 = 0x0AA8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LobbyCharacterMaleClass = 0x0AC8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LobbyCharacterFemaleClass = 0x0AD0;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData04 = 0x0AD8;

		///<summary><![CDATA[FViewTargetTransitionParams]]></summary>
		public const int ViewTargetTransitionParams = 0x0B28;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x0B38;

	}

	public class ATslWelcomeBaseHUD
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0548;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnStateChanged = 0x0558;

		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData01 = 0x0568;

	}

	public class ATslEntryPlayerController
	{
		///<summary><![CDATA[UVivoxLobbyComponent *]]></summary>
		public const int VivoxComponent = 0x06F0;

	}

	public class APerfBotPlayerController
	{
		///<summary><![CDATA[int]]></summary>
		public const int AmmoClips = 0x0A18;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0A1C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WeaponType = 0x0A20;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData01 = 0x0A28;

	}

	public class ATslDemoSpectator
	{
		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x0A18;

	}

	public class ATslBotAIController
	{
		///<summary><![CDATA[unsigned char[0x38]]]></summary>
		public const int UnknownData00 = 0x04A8;

	}

	public class ACharacterBreathBuff
	{
		///<summary><![CDATA[float]]></summary>
		public const int BreathPerTick = 0x0410;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0414;

	}

	public class UTslCameraComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0990;

	}

	public class ATslCharacterProxy
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x07E0;

		///<summary><![CDATA[TArray<UWeaponClone * >]]></summary>
		public const int ArmedWeapons = 0x07E8;

		///<summary><![CDATA[UWeaponAnimInfoComponent *]]></summary>
		public const int WeaponAnimInfoComponent = 0x07F8;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponUpdateIntervalSeconds = 0x0800;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x0804;

	}

	public class UTslCharacterSpringArmComponent
	{
		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0470;

		///<summary><![CDATA[FVector]]></summary>
		public const int DefaultSocketOffset = 0x0474;

		///<summary><![CDATA[FVector]]></summary>
		public const int IndoorSocketOffset = 0x0480;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeanLeftDefaultSocketOffsetAddition = 0x048C;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeanRightDefaultSocketOffsetAddition = 0x0498;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeftShoulderAimingSocketOffset = 0x04A4;

		///<summary><![CDATA[FVector]]></summary>
		public const int RightShoulderAimingSocketOffset = 0x04B0;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeanLeftAimedSocketOffsetAddition = 0x04BC;

		///<summary><![CDATA[FVector]]></summary>
		public const int LeanRightAimedSocketOffsetAddition = 0x04C8;

		///<summary><![CDATA[FVector]]></summary>
		public const int SprintSocketOffsetAddition = 0x04D4;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchSocketOffsetZAddition = 0x04E0;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchSocketOffsetMovementZAddition = 0x04E4;

		///<summary><![CDATA[float]]></summary>
		public const int ProneScoketOffsetZAddition = 0x04E8;

		///<summary><![CDATA[float]]></summary>
		public const int SocketOffsetInterpSpeed = 0x04EC;

		///<summary><![CDATA[FVector]]></summary>
		public const int DefaultTargetOffset = 0x04F0;

		///<summary><![CDATA[FVector]]></summary>
		public const int IndoorTargetOffset = 0x04FC;

		///<summary><![CDATA[FVector]]></summary>
		public const int AimingTargetOffset = 0x0508;

		///<summary><![CDATA[float]]></summary>
		public const int TargetOffsetInterpSpeed = 0x0514;

		///<summary><![CDATA[float]]></summary>
		public const int TargetOffsetInterpSpeed_Vaulting = 0x0518;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultSpringArmLength = 0x051C;

		///<summary><![CDATA[float]]></summary>
		public const int IndoorSpringArmLength = 0x0520;

		///<summary><![CDATA[float]]></summary>
		public const int AimingSpringArmLength = 0x0524;

		///<summary><![CDATA[float]]></summary>
		public const int BlockingCompressOffset = 0x0528;

		///<summary><![CDATA[float]]></summary>
		public const int BlockingCompressCrouchOffset = 0x052C;

		///<summary><![CDATA[float]]></summary>
		public const int SpringArmLengthInterpSpeed = 0x0530;

		///<summary><![CDATA[float]]></summary>
		public const int AimingSpringArmLengthInterpSpeed = 0x0534;

		///<summary><![CDATA[float]]></summary>
		public const int VaultingSpringArmLengthInterpSpeed = 0x0538;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x053C;

		///<summary><![CDATA[float]]></summary>
		public const int SpringArmRestoreInterpSpeed = 0x0540;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData02 = 0x0544;

	}

	public class UTslCharacterValidateLocationComponent
	{
		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[float]]></summary>
		public const int InvalidUndergroundCheckInterval = 0x01EC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01F0;

		///<summary><![CDATA[float]]></summary>
		public const int InvalidUndergroundCheckLength = 0x01F4;

		///<summary><![CDATA[float]]></summary>
		public const int MaxAdjustRange = 0x01F8;

		///<summary><![CDATA[int]]></summary>
		public const int MaxAdjustCount = 0x01FC;

	}

	public class UTslChatWidgetStyle
	{
		///<summary><![CDATA[FTslChatStyle]]></summary>
		public const int ChatStyle = 0x0030;

	}

	public class UTslCheatManager
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0078;

	}

	public class UTslCoherentWidget
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int WidgetBinderClass = 0x0490;

		///<summary><![CDATA[UCoherentWidgetBinder *]]></summary>
		public const int WidgetBinder = 0x0498;

	}

	public class UTslConsole
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0130;

	}

	public class UTslConsoleSetting
	{
		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteItemPaths = 0x0070;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteItemKinds = 0x0080;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteVehiclePaths = 0x0090;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteMaleBody = 0x00A0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteMaleHair = 0x00B0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteMaleFace = 0x00C0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteFemaleBody = 0x00D0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteFemaleHair = 0x00E0;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int AutoCompleteFemaleFace = 0x00F0;

	}

	public class ATslDamageField
	{
		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int DamageRadius = 0x03B4;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int DamageFieldFX = 0x03B8;

		///<summary><![CDATA[int]]></summary>
		public const int Damage = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int DamageInterval = 0x03C4;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageType = 0x03C8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x03D0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DebuffTemplate = 0x03E0;

	}

	public class ATslDamageFieldContainer
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[TArray<FDamageFieldLayout>]]></summary>
		public const int DamageFieldLayouts = 0x03B8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x03C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageFieldTemplate = 0x03D0;

		///<summary><![CDATA[bool]]></summary>
		public const int FlameInWall = 0x03D8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x03D9;

		///<summary><![CDATA[int]]></summary>
		public const int FlameMaxCountInWall = 0x03DC;

		///<summary><![CDATA[float]]></summary>
		public const int FlameDelayInWall = 0x03E0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData03 = 0x03E4;

	}

	public class ATslDestructibleContainer
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bFlag = 0x03B0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03B1;

	}

	public class ATslDoor
	{
		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int DoorMeshComponent = 0x03C0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkSound = 0x03C8;

		///<summary><![CDATA[UInteractionComponent *]]></summary>
		public const int Interaction = 0x03D0;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x03D8;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int DoorDestructibleMesh = 0x03F8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDoorOpened = 0x0400;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReverseRotation = 0x0400;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0401;

		///<summary><![CDATA[float]]></summary>
		public const int OpenAngle = 0x0404;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int OpenSound = 0x0408;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int CloseSound = 0x0410;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int OpenCurve = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int OpenCurveDuration = 0x0420;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0424;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CloseCurve = 0x0428;

		///<summary><![CDATA[float]]></summary>
		public const int CloseCurveDuration = 0x0430;

		///<summary><![CDATA[float]]></summary>
		public const int PointDamageImpulse = 0x0434;

		///<summary><![CDATA[float]]></summary>
		public const int PointDamageRadius = 0x0438;

		///<summary><![CDATA[float]]></summary>
		public const int BreakingRadius = 0x043C;

		///<summary><![CDATA[float]]></summary>
		public const int BreakingImpulse = 0x0440;

		///<summary><![CDATA[float]]></summary>
		public const int BreakingMinDamage = 0x0444;

		///<summary><![CDATA[float]]></summary>
		public const int DamageAccumulateTimeout = 0x0448;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x044C;

		///<summary><![CDATA[FName]]></summary>
		public const int TopImpactSoketName = 0x0450;

		///<summary><![CDATA[FName]]></summary>
		public const int CenterImpactSoketName = 0x0458;

		///<summary><![CDATA[FName]]></summary>
		public const int BottomImpactSoketName = 0x0460;

		///<summary><![CDATA[unsigned char[0x1C8]]]></summary>
		public const int UnknownData04 = 0x0468;

		///<summary><![CDATA[FDoorBreakingStateLegacy]]></summary>
		public const int DoorBreakingState = 0x0630;

		///<summary><![CDATA[unsigned char[0x1F]]]></summary>
		public const int UnknownData05 = 0x0631;

	}

	public class ATslExplosionEffect
	{
		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int ExplosionFX = 0x03B0;

		///<summary><![CDATA[UPointLightComponent *]]></summary>
		public const int ExplosionLight = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int ExplosionLightFadeOut = 0x03C0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03C4;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ExplosionSound = 0x03C8;

		///<summary><![CDATA[FDecalEffectDataSet]]></summary>
		public const int DecalEffectDataSet = 0x03D0;

		///<summary><![CDATA[float]]></summary>
		public const int DecalSpawnDelayTime = 0x0538;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x053C;

		///<summary><![CDATA[FHitResult]]></summary>
		public const int SurfaceHit = 0x0540;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x05C8;

	}

	public class ATslFence
	{
		///<summary><![CDATA[USplineComponent *]]></summary>
		public const int SplineComponent = 0x03B0;

		///<summary><![CDATA[ETslFenceSelector]]></summary>
		public const int BeginSelector = 0x03B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x03B9;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int BeginMesh1 = 0x03C0;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int BeginMesh2 = 0x03C8;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int BeginMesh3 = 0x03D0;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int BeginMesh4 = 0x03D8;

		///<summary><![CDATA[ETslFenceSelector]]></summary>
		public const int EndSelector = 0x03E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03E1;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int EndMesh1 = 0x03E8;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int EndMesh2 = 0x03F0;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int EndMesh3 = 0x03F8;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int EndMesh4 = 0x0400;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseRandomForMiddle = 0x0408;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseMiddleSegmentsInOrder = 0x0409;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x040A;

		///<summary><![CDATA[float]]></summary>
		public const int UnitLengthForMiddle = 0x040C;

		///<summary><![CDATA[float]]></summary>
		public const int UnitSpacingForMiddle = 0x0410;

		///<summary><![CDATA[float]]></summary>
		public const int PivotOffsetForMiddle = 0x0414;

		///<summary><![CDATA[FRandomStream]]></summary>
		public const int RandomStreamForMiddle = 0x0418;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int MiddleMesh1 = 0x0420;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int MiddleMesh2 = 0x0428;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int MiddleMesh3 = 0x0430;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int MiddleMesh4 = 0x0438;

		///<summary><![CDATA[FCollisionProfileName]]></summary>
		public const int FenceCollisionProfile = 0x0440;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0448;

	}

	public class UTslReactionData
	{
		///<summary><![CDATA[float]]></summary>
		public const int DestroyDelay = 0x0030;

		///<summary><![CDATA[FVehicleReactionData]]></summary>
		public const int VehicleReactionData = 0x0034;

		///<summary><![CDATA[FRadialDamageReactionData]]></summary>
		public const int RadialDamageReactionData = 0x0040;

		///<summary><![CDATA[FPointDamageReactionData]]></summary>
		public const int PointDamageReactionData = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int DependancyCountBySibling = 0x005C;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int PhysicsReactionSoundAk = 0x0060;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int DestructibleReactionSoundAk = 0x0068;

	}

	public class UTslReactionComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x09C0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bPendingDestroy = 0x09C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x09C9;

		///<summary><![CDATA[UTslReactionData *]]></summary>
		public const int ReactionData = 0x09D0;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int ReactionDM = 0x09D8;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData02 = 0x09E0;

	}

	public class ATslBreakableFence
	{
		///<summary><![CDATA[UTslReactionData *]]></summary>
		public const int ReactionData = 0x0450;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int BeginDestuctible1 = 0x0458;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int BeginDestuctible2 = 0x0460;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int BeginDestuctible3 = 0x0468;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int BeginDestuctible4 = 0x0470;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int EndDestuctible1 = 0x0478;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int EndDestuctible2 = 0x0480;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int EndDestuctible3 = 0x0488;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int EndDestuctible4 = 0x0490;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int MiddleDestuctible1 = 0x0498;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int MiddleDestuctible2 = 0x04A0;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int MiddleDestuctible3 = 0x04A8;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int MiddleDestuctible4 = 0x04B0;

	}

	public class UTslPerformanceTestComponent
	{
		///<summary><![CDATA[unsigned char[0x140]]]></summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class ATslGameMode
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int MalePawnClass = 0x0480;

		///<summary><![CDATA[UClass *]]></summary>
		public const int PerfBotPlayerControllerClass = 0x0488;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ModeControllerClass = 0x0490;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int AdditionalModeControllerClasses = 0x0498;

		///<summary><![CDATA[UClass *]]></summary>
		public const int InitialItemDonatorClass = 0x04A8;

		///<summary><![CDATA[TArray<FMatchPreparerClass>]]></summary>
		public const int MatchPreparerClasses = 0x04B0;

		///<summary><![CDATA[EMatchStartType]]></summary>
		public const int MatchStartType = 0x04C0;

		///<summary><![CDATA[ECameraViewBehaviour]]></summary>
		public const int CameraViewBehaviour = 0x04C1;

		///<summary><![CDATA[bool]]></summary>
		public const int PlayerRespawn = 0x04C2;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData00 = 0x04C3;

		///<summary><![CDATA[int]]></summary>
		public const int PostMatchWaitingTime = 0x04C4;

		///<summary><![CDATA[int]]></summary>
		public const int CustomGamePostMatchWaitingTime = 0x04C8;

		///<summary><![CDATA[int]]></summary>
		public const int ESportsPostMatchWaitingTime = 0x04CC;

		///<summary><![CDATA[int]]></summary>
		public const int ServerQuitAfterLeavingMapTime = 0x04D0;

		///<summary><![CDATA[int]]></summary>
		public const int MinPlayers = 0x04D4;

		///<summary><![CDATA[int]]></summary>
		public const int PlayerSpawnTryMaxCount = 0x04D8;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnablePerfBotInPIE = 0x04DC;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnablePerfBotLogin = 0x04DD;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsPerfBotSpawnToRandomPosition = 0x04DE;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanRestartPerfBot = 0x04DF;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableObserverInPIE = 0x04E0;

		///<summary><![CDATA[bool]]></summary>
		public const int IsBattleRoyale = 0x04E1;

		///<summary><![CDATA[bool]]></summary>
		public const int bStartPlayerAtMatchStart = 0x04E2;

		///<summary><![CDATA[bool]]></summary>
		public const int bShouldSpawnAtStartSpot = 0x04E3;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x04E4;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsEditorTestZombieMode = 0x04E5;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsCustomGame = 0x04E6;

		///<summary><![CDATA[bool]]></summary>
		public const int bCanAllSpectate = 0x04E7;

		///<summary><![CDATA[FCustomGameUpdateCharacterInfo]]></summary>
		public const int CustomGameUpdateCharacterInfo = 0x04E8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x04FC;

		///<summary><![CDATA[TArray<FLimitCustomStringParameter>]]></summary>
		public const int LimitCustomStringParameters = 0x0500;

		///<summary><![CDATA[float]]></summary>
		public const int MultiplierBlueZone = 0x0510;

		///<summary><![CDATA[float]]></summary>
		public const int BlueZoneCentralizationFactor = 0x0514;

		///<summary><![CDATA[float]]></summary>
		public const int MultiplierCarePackage = 0x0518;

		///<summary><![CDATA[FRedZoneCustomOption]]></summary>
		public const int RedZoneCustomOption = 0x051C;

		///<summary><![CDATA[TArray<FBlueZoneCustomOption>]]></summary>
		public const int BlueZoneCustomOptions = 0x0538;

		///<summary><![CDATA[int]]></summary>
		public const int WarmupTime = 0x0548;

		///<summary><![CDATA[int]]></summary>
		public const int EditorTestTeamMemberCount = 0x054C;

		///<summary><![CDATA[TMap<FString,URewardData * >]]></summary>
		public const int RewardDataMap = 0x0550;

		///<summary><![CDATA[URewardData *]]></summary>
		public const int RewardData = 0x05A0;

		///<summary><![CDATA[ATslPlayerState *]]></summary>
		public const int WinnerPlayerState = 0x05A8;

		///<summary><![CDATA[int]]></summary>
		public const int WinnerTeam = 0x05B0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x05B4;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ItemSpawnProcessorClass = 0x05B8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ThingSpawnProcessorClass = 0x05C0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int BasicBeltItemClassForNoBelt = 0x05C8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x05D0;

		///<summary><![CDATA[UItemSpawnProcessor *]]></summary>
		public const int ItemSpawnProcessor = 0x05D8;

		///<summary><![CDATA[UThingSpawnProcessor *]]></summary>
		public const int ThingSpawnProcessor = 0x05E0;

		///<summary><![CDATA[UGeneralItemSpawner *]]></summary>
		public const int InitialItemDonator = 0x05E8;

		///<summary><![CDATA[UMatchPreparer *]]></summary>
		public const int MatchPreparer = 0x05F0;

		///<summary><![CDATA[AModeController *]]></summary>
		public const int ModeController = 0x05F8;

		///<summary><![CDATA[ADroppedItemGridManager *]]></summary>
		public const int DroppedItemGridManager = 0x0600;

		///<summary><![CDATA[TArray<AModeController * >]]></summary>
		public const int AdditinalModeControllers = 0x0608;

		///<summary><![CDATA[unsigned char[0x98]]]></summary>
		public const int UnknownData05 = 0x0618;

		///<summary><![CDATA[TMap<FString,APlayerState * >]]></summary>
		public const int JoinedUserPlayerStateMap = 0x06B0;

		///<summary><![CDATA[TArray<FTeams>]]></summary>
		public const int Teams = 0x0700;

		///<summary><![CDATA[unsigned char[0xB0]]]></summary>
		public const int UnknownData06 = 0x0710;

	}

	public class UTslGameUserSettings
	{
		///<summary><![CDATA[float]]></summary>
		public const int ScreenScale = 0x0108;

		///<summary><![CDATA[float]]></summary>
		public const int Gamma = 0x010C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsLanMatch = 0x0110;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsMasterSoundMute = 0x0111;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0112;

		///<summary><![CDATA[float]]></summary>
		public const int MasterSoundVolume = 0x0114;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsEffectSoundMute = 0x0118;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0119;

		///<summary><![CDATA[float]]></summary>
		public const int EffectSoundVolume = 0x011C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsUISoundMute = 0x0120;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0121;

		///<summary><![CDATA[float]]></summary>
		public const int UISoundVolume = 0x0124;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsBGMSoundMute = 0x0128;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0129;

		///<summary><![CDATA[float]]></summary>
		public const int BGMSoundVolume = 0x012C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVoiceInputMute = 0x0130;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVoiceOutputMute = 0x0131;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData04 = 0x0132;

		///<summary><![CDATA[int]]></summary>
		public const int VoiceInputVolume = 0x0134;

		///<summary><![CDATA[int]]></summary>
		public const int VoiceOutputVolume = 0x0138;

		///<summary><![CDATA[bool]]></summary>
		public const int bUsePushToTalk = 0x013C;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseGlobalVoice = 0x013D;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseTeamVoice = 0x013E;

		///<summary><![CDATA[bool]]></summary>
		public const int bSavedGraphicOption = 0x013F;

		///<summary><![CDATA[bool]]></summary>
		public const int bMotionBlur = 0x0140;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x0141;

		///<summary><![CDATA[FString]]></summary>
		public const int CultureName = 0x0148;

		///<summary><![CDATA[FCustomInputSettings]]></summary>
		public const int CustomInputSettins = 0x0158;

		///<summary><![CDATA[int]]></summary>
		public const int SelectMiniMapIndex = 0x01B0;

		///<summary><![CDATA[float]]></summary>
		public const int FpsCameraFov = 0x01B4;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseForceFeedback = 0x01B8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x01B9;

		///<summary><![CDATA[int]]></summary>
		public const int ColorBlindType = 0x01BC;

		///<summary><![CDATA[FString]]></summary>
		public const int CrosshairColorString = 0x01C0;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int GearProfile1 = 0x01D0;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int GearProfile2 = 0x01E0;

		///<summary><![CDATA[EUiShowType]]></summary>
		public const int FppWeaponIconShowType = 0x01F0;

		///<summary><![CDATA[EUiShowType]]></summary>
		public const int TpsWeaponIconShowType = 0x01F1;

		///<summary><![CDATA[EUiShowType]]></summary>
		public const int FppEquipableItemIconShowType = 0x01F2;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseCharacterCapture = 0x01F3;

		///<summary><![CDATA[int]]></summary>
		public const int WorldMapZoomSpeedLevel = 0x01F4;

		///<summary><![CDATA[bool]]></summary>
		public const int bIconKillfeedEnabled = 0x01F8;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeCrouch = 0x01F9;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeProne = 0x01FA;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeWalk = 0x01FB;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int bToggleSprint = 0x01FC;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeHoldRotation = 0x01FD;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeHoldBreath = 0x01FE;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModePeek = 0x01FF;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeMap = 0x0200;

		///<summary><![CDATA[ETslInputModes]]></summary>
		public const int InputModeADS = 0x0201;

		///<summary><![CDATA[bool]]></summary>
		public const int bEditorApplyOverrideScalability = 0x0202;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseFreeLookInterp = 0x0203;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseKillcam = 0x0204;

		///<summary><![CDATA[bool]]></summary>
		public const int bPreloadingMap = 0x0205;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData07 = 0x0206;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int PreloadingMaps = 0x0208;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnGameUserSettingApplied = 0x0218;

	}

	public class ATslGameSession
	{
		///<summary><![CDATA[unsigned char[0x318]]]></summary>
		public const int UnknownData00 = 0x03C8;

	}

	public class ATslGameState
	{
		///<summary><![CDATA[FString]]></summary>
		public const int MatchId = 0x0410;

		///<summary><![CDATA[FString]]></summary>
		public const int MatchShortGuid = 0x0420;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsCustomGame = 0x0430;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsWinnerZombieTeam = 0x0431;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0432;

		///<summary><![CDATA[int]]></summary>
		public const int NumTeams = 0x0434;

		///<summary><![CDATA[int]]></summary>
		public const int RemainingTime = 0x0438;

		///<summary><![CDATA[int]]></summary>
		public const int MatchElapsedMinutes = 0x043C;

		///<summary><![CDATA[bool]]></summary>
		public const int bTimerPaused = 0x0440;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0441;

		///<summary><![CDATA[int]]></summary>
		public const int NumJoinPlayers = 0x0444;

		///<summary><![CDATA[int]]></summary>
		public const int NumAlivePlayers = 0x0448;

		///<summary><![CDATA[int]]></summary>
		public const int NumAliveZombiePlayers = 0x044C;

		///<summary><![CDATA[int]]></summary>
		public const int NumAliveTeams = 0x0450;

		///<summary><![CDATA[int]]></summary>
		public const int NumStartPlayers = 0x0454;

		///<summary><![CDATA[int]]></summary>
		public const int NumStartTeams = 0x0458;

		///<summary><![CDATA[FVector]]></summary>
		public const int SafetyZonePosition = 0x045C;

		///<summary><![CDATA[float]]></summary>
		public const int SafetyZoneRadius = 0x0468;

		///<summary><![CDATA[FVector]]></summary>
		public const int PoisonGasWarningPosition = 0x046C;

		///<summary><![CDATA[float]]></summary>
		public const int PoisonGasWarningRadius = 0x0478;

		///<summary><![CDATA[FVector]]></summary>
		public const int RedZonePosition = 0x047C;

		///<summary><![CDATA[float]]></summary>
		public const int RedZoneRadius = 0x0488;

		///<summary><![CDATA[float]]></summary>
		public const int TotalReleaseDuration = 0x048C;

		///<summary><![CDATA[float]]></summary>
		public const int ElapsedReleaseDuration = 0x0490;

		///<summary><![CDATA[float]]></summary>
		public const int TotalWarningDuration = 0x0494;

		///<summary><![CDATA[float]]></summary>
		public const int ElapsedWarningDuration = 0x0498;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsGasRelease = 0x049C;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsTeamMatch = 0x049D;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsZombieMode = 0x049E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x049F;

		///<summary><![CDATA[float]]></summary>
		public const int ElapsedGasReleaseDuration = 0x04A0;

		///<summary><![CDATA[FVector]]></summary>
		public const int LerpSafetyZonePosition = 0x04A4;

		///<summary><![CDATA[float]]></summary>
		public const int LerpSafetyZoneRadius = 0x04B0;

		///<summary><![CDATA[FVector]]></summary>
		public const int SafetyZoneBeginPosition = 0x04B4;

		///<summary><![CDATA[float]]></summary>
		public const int SafetyZoneBeginRadius = 0x04C0;

		///<summary><![CDATA[EMatchStartType]]></summary>
		public const int MatchStartType = 0x04C4;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x04C5;

		///<summary><![CDATA[ALevelAttribute *]]></summary>
		public const int LevelAttribute = 0x04C8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x04D0;

	}

	public class UTslGameViewportClient
	{
		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x0610;

		///<summary><![CDATA[UTslConfirmationDialogWidget *]]></summary>
		public const int DialogUMGWidget = 0x0640;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0648;

	}

	public class UTslGlassWindowComponent
	{
		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int DestructibleMesh = 0x09C0;

		///<summary><![CDATA[float]]></summary>
		public const int DestroyDelayAfterDestructed = 0x09C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x09CC;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int DestructSound = 0x09D0;

		///<summary><![CDATA[float]]></summary>
		public const int DestructSoundOcclusionRefreshInterval = 0x09D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x09DC;

		///<summary><![CDATA[UDestructibleComponent *]]></summary>
		public const int DestructibleComponent = 0x09E0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicatedOnClient = 0x09E8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDestroyed = 0x09E8;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData02 = 0x09E9;

	}

	public class UTslGunAnimInstance
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int WeaponFire = 0x0378;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int WeaponFireCycle = 0x0388;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int TriggerOn = 0x0398;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int TriggerOff = 0x03A8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int Reload1 = 0x03B8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int Reload2 = 0x03C8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadByOneStart = 0x03D8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadByOneSingle = 0x03E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int ReloadByOneEnd = 0x03F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int WeaponCharge = 0x0408;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int FireSelect = 0x0418;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int CancelReload = 0x0428;

		///<summary><![CDATA[FName]]></summary>
		public const int Name_FireMode_Semi = 0x0438;

		///<summary><![CDATA[FName]]></summary>
		public const int Name_FireMode_Burst = 0x0440;

		///<summary><![CDATA[FName]]></summary>
		public const int Name_FireMode_Fullauto = 0x0448;

	}

	public class UTslHealthGaugeData
	{
		///<summary><![CDATA[TArray<FHealthColorData>]]></summary>
		public const int HealthGaugeColors = 0x0030;

		///<summary><![CDATA[FFloatInterval]]></summary>
		public const int WarningRage = 0x0040;

		///<summary><![CDATA[UCurveLinearColor *]]></summary>
		public const int GroggyColorCurve = 0x0048;

	}

	public class UTslHornComponent
	{
		///<summary><![CDATA[float]]></summary>
		public const int LongHornStartingTime = 0x01E0;

		///<summary><![CDATA[float]]></summary>
		public const int CurrHornKeyPressedTime = 0x01E4;

		///<summary><![CDATA[bool]]></summary>
		public const int bHornKeyDown = 0x01E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bPlayingLongHorn = 0x01E9;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x01EA;

		///<summary><![CDATA[FHornPlayInfo]]></summary>
		public const int HornPlayInfo = 0x01EC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01F4;

		///<summary><![CDATA[FHornSoundInfo]]></summary>
		public const int HornSounds_Local = 0x01F8;

		///<summary><![CDATA[FHornSoundInfo]]></summary>
		public const int HornSounds_Remote = 0x0208;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0218;

	}

	public class ATslImpactEffect
	{
		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int DefaultFX = 0x03B0;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int ConcreteFX = 0x03B8;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int DirtFX = 0x03C0;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int WaterFX = 0x03C8;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int MetalFX = 0x03D0;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int WoodFX = 0x03D8;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int GlassFX = 0x03E0;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int GrassFX = 0x03E8;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int FleshFX = 0x03F0;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int AkSound = 0x03F8;

		///<summary><![CDATA[FDecalEffectDataSet]]></summary>
		public const int DecalEffectDataSet = 0x0400;

		///<summary><![CDATA[FHitResult]]></summary>
		public const int SurfaceHit = 0x0568;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int ParticleCom = 0x05F0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AKCom = 0x05F8;

	}

	public class UTslInstancedGlassWindowComponent
	{
		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int DestructibleMesh = 0x0BC0;

		///<summary><![CDATA[float]]></summary>
		public const int DestroyDelayAfterDestructed = 0x0BC8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0BCC;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int DestructSound = 0x0BD0;

		///<summary><![CDATA[float]]></summary>
		public const int DestructSoundOcclusionRefreshInterval = 0x0BD8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bReplicatedOnClient = 0x0BDC;

		///<summary><![CDATA[unsigned char[0x13]]]></summary>
		public const int UnknownData01 = 0x0BDD;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int DestroyedInstances = 0x0BF0;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int PendingDestroyInstances = 0x0C00;

		///<summary><![CDATA[unsigned char[0xD0]]]></summary>
		public const int UnknownData02 = 0x0C10;

	}

	public class UTslInstancedReactionComponent
	{
		///<summary><![CDATA[TArray<int>]]></summary>
		public const int PendingDestroyInstances = 0x0BC0;

		///<summary><![CDATA[UTslReactionData *]]></summary>
		public const int ReactionData = 0x0BD0;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int ReactionDM = 0x0BD8;

		///<summary><![CDATA[unsigned char[0x1C0]]]></summary>
		public const int UnknownData00 = 0x0BE0;

	}

	public class ATslLevelScriptActor
	{
		///<summary><![CDATA[TArray<FWeatherLevelInfo>]]></summary>
		public const int WeatherLevelInfos = 0x03B8;

		///<summary><![CDATA[UMaterialParameterCollection *]]></summary>
		public const int GlobalMPC = 0x03C8;

		///<summary><![CDATA[int]]></summary>
		public const int SelectedWeatherLevelIndex = 0x03D0;

		///<summary><![CDATA[unsigned char[0x8C]]]></summary>
		public const int UnknownData00 = 0x03D4;

	}

	public class ATslLobbyLevelScriptActor
	{
		///<summary><![CDATA[FName]]></summary>
		public const int MainMenuStreamingLevelName = 0x03B8;

		///<summary><![CDATA[FName]]></summary>
		public const int CustomizationStreamingLevelName = 0x03C0;

	}

	public class UTslPersistentUser
	{
		///<summary><![CDATA[float]]></summary>
		public const int Gamma = 0x0028;

		///<summary><![CDATA[float]]></summary>
		public const int AimSensitivity = 0x002C;

		///<summary><![CDATA[bool]]></summary>
		public const int bInvertedYAxis = 0x0030;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0031;

		///<summary><![CDATA[float]]></summary>
		public const int ScreenScalePercentage = 0x0034;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x0038;

	}

	public class UTslLocalPlayer
	{
		///<summary><![CDATA[UTslPersistentUser *]]></summary>
		public const int PersistentUser = 0x01C8;

	}

	public class UTslMenuItemWidgetStyle
	{
		///<summary><![CDATA[FTslMenuItemStyle]]></summary>
		public const int MenuItemStyle = 0x0030;

	}

	public class UTslMenuSoundsWidgetStyle
	{
		///<summary><![CDATA[FTslMenuSoundsStyle]]></summary>
		public const int SoundsStyle = 0x0030;

	}

	public class UTslMenuWidgetStyle
	{
		///<summary><![CDATA[FTslMenuStyle]]></summary>
		public const int MenuStyle = 0x0030;

	}

	public class ATslModularBuilding
	{
		///<summary><![CDATA[unsigned char[0x100]]]></summary>
		public const int UnknownData00 = 0x03B0;

	}

	public class ATslParticle
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bAutoDestroyOnParticleFinish = 0x03B0;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoPlaySound = 0x03B1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x03B2;

		///<summary><![CDATA[TArray<FParticleParameter>]]></summary>
		public const int DefaultParameters = 0x03B8;

		///<summary><![CDATA[TEnumAsByte<EAttachParent>]]></summary>
		public const int AttachParentType = 0x03C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03C9;

		///<summary><![CDATA[FName]]></summary>
		public const int AttachSocketName = 0x03D0;

		///<summary><![CDATA[EAttachmentRule]]></summary>
		public const int AttachLocationRule = 0x03D8;

		///<summary><![CDATA[EAttachmentRule]]></summary>
		public const int AttachRotationRule = 0x03D9;

		///<summary><![CDATA[EAttachmentRule]]></summary>
		public const int AttachScaleRule = 0x03DA;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData02 = 0x03DB;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int ParticleSystem = 0x03E0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkSound = 0x03E8;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData03 = 0x03F0;

	}

	public class ATslParticleBulletTrail
	{
		///<summary><![CDATA[FVector]]></summary>
		public const int TargetDestanation = 0x0408;

		///<summary><![CDATA[float]]></summary>
		public const int BulletSpeed = 0x0414;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0418;

	}

	public class ATslParticleEnvironment
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0408;

		///<summary><![CDATA[float]]></summary>
		public const int AutoParticleActivateDistance = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int AutoPlayDistance = 0x041C;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0420;

	}

	public class ATslPassArea
	{
		///<summary><![CDATA[USphereComponent *]]></summary>
		public const int SphereComponent = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int Radius = 0x03B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x03BC;

	}

	public class ATslPassAreaRectangle
	{
		///<summary><![CDATA[UBoxComponent *]]></summary>
		public const int BoxComponent = 0x03B0;

		///<summary><![CDATA[float]]></summary>
		public const int Width = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int Height = 0x03BC;

	}

	public class UTslPawnInputBindingComponent
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnOwnerPossessed = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnOwnerUnPossessed = 0x01F0;

	}

	public class ATslPhysicsVolume
	{
		///<summary><![CDATA[AOceanManager *]]></summary>
		public const int OceanManager = 0x03F8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultWaterSplash = 0x0400;

		///<summary><![CDATA[UClass *]]></summary>
		public const int VehicleWaterSplash = 0x0408;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int WaterSplashMuteTypes = 0x0410;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0420;

	}

	public class ATslPlayerCameraManager
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x1BB0;

	}

	public class ATslPlayerState
	{
		///<summary><![CDATA[int]]></summary>
		public const int Ranking = 0x0440;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0444;

		///<summary><![CDATA[FString]]></summary>
		public const int AccountId = 0x0448;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bKilled = 0x0458;

		///<summary><![CDATA[bool]]></summary>
		public const int bShowMapMarker = 0x0459;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x045A;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int MapMarkerPosition = 0x045C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0464;

		///<summary><![CDATA[TArray<FReplicatedCastableItem>]]></summary>
		public const int ReplicatedCastableItems = 0x0468;

		///<summary><![CDATA[bool]]></summary>
		public const int bEmptyReplicatedCastableItems = 0x0478;

		///<summary><![CDATA[EObserverAuthorityType]]></summary>
		public const int ObserverAuthorityType = 0x0479;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData03 = 0x047A;

		///<summary><![CDATA[int]]></summary>
		public const int TeamNumber = 0x047C;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsZombie = 0x0480;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0481;

		///<summary><![CDATA[FTslPlayerScores]]></summary>
		public const int PlayerScores = 0x0484;

		///<summary><![CDATA[FTslPlayerStatistics]]></summary>
		public const int PlayerStatistics = 0x0490;

		///<summary><![CDATA[FTslPlayerStatisticsForOwner]]></summary>
		public const int PlayerStatisticsForOwner = 0x0494;

		///<summary><![CDATA[unsigned char[0xAC]]]></summary>
		public const int UnknownData05 = 0x04A4;

		///<summary><![CDATA[TArray<FReplicatedEquipableItem>]]></summary>
		public const int ReplicatedEquipableItems = 0x0550;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData06 = 0x0560;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bQuitter = 0x057C;

		///<summary><![CDATA[unsigned char[0xFF]]]></summary>
		public const int UnknownData07 = 0x057D;

		///<summary><![CDATA[float]]></summary>
		public const int LastHitTime = 0x067C;

		///<summary><![CDATA[FString]]></summary>
		public const int CurrentAttackerPlayerNetId = 0x0680;

	}

	public class ATslPostProcessEffect
	{
		///<summary><![CDATA[FName]]></summary>
		public const int TargetPostProcessVolumeName = 0x03B0;

		///<summary><![CDATA[TArray<FPostProcessMaterial>]]></summary>
		public const int PostProcessMaterials = 0x03B8;

		///<summary><![CDATA[TArray<FPostProcessEffectParameter>]]></summary>
		public const int DefaultPostProcessEffectParameter = 0x03C8;

		///<summary><![CDATA[TArray<FPostProcessEffectDynamicMaterialState>]]></summary>
		public const int PostProcessEffectDynamicMaterialStates = 0x03D8;

		///<summary><![CDATA[APostProcessVolume *]]></summary>
		public const int PostProcessVolume = 0x03E8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x03F0;

	}

	public class ATslWeapon_Projectile
	{
		///<summary><![CDATA[FProjectileWeaponData]]></summary>
		public const int ProjectileConfig = 0x0AE0;

	}

	public class ATslProjectile
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[UProjectileMovementComponent *]]></summary>
		public const int MovementComp = 0x03B8;

		///<summary><![CDATA[USphereComponent *]]></summary>
		public const int CollisionComp = 0x03C0;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int ParticleComp = 0x03C8;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int MeshComp = 0x03D0;

		///<summary><![CDATA[UPhysicsConstraintComponent *]]></summary>
		public const int MeshConstraint = 0x03D8;

		///<summary><![CDATA[FVector]]></summary>
		public const int MeshInitialRotationRate = 0x03E0;

		///<summary><![CDATA[bool]]></summary>
		public const int bSyncServerAndClientRotation = 0x03EC;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData01 = 0x03ED;

		///<summary><![CDATA[bool]]></summary>
		public const int HideMeshAtExplosion = 0x03FC;

		///<summary><![CDATA[bool]]></summary>
		public const int ExplosionInWater = 0x03FD;

		///<summary><![CDATA[TEnumAsByte<EProjectileExplosionRotationType>]]></summary>
		public const int ExplosionRotationType = 0x03FE;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData02 = 0x03FF;

		///<summary><![CDATA[FName]]></summary>
		public const int ParticleToMeshAttachPointName = 0x0400;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0408;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ExplosionTemplate = 0x0410;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ExplosionTemplateInAir = 0x0418;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ExplosionTemplateInWater = 0x0420;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int ImpactSound = 0x0428;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkComp = 0x0430;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData04 = 0x0438;

		///<summary><![CDATA[TEnumAsByte<EProjectileExplodeState>]]></summary>
		public const int ExplodeState = 0x0440;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bActiveParticle = 0x0441;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bDoTick = 0x0441;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData05 = 0x0442;

		///<summary><![CDATA[FRotator]]></summary>
		public const int ClientMeshRotation = 0x0444;

		///<summary><![CDATA[FRotator]]></summary>
		public const int ServerMeshRotation = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityStopStepDistance = 0x045C;

		///<summary><![CDATA[FVector]]></summary>
		public const int LastStepLocation = 0x0460;

		///<summary><![CDATA[int]]></summary>
		public const int StepBuffer = 0x046C;

		///<summary><![CDATA[float]]></summary>
		public const int FinalInterpSpeed = 0x0470;

		///<summary><![CDATA[bool]]></summary>
		public const int bConstantInterpStep = 0x0474;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData06 = 0x0475;

		///<summary><![CDATA[float]]></summary>
		public const int VelocityCheckTimerTick = 0x0478;

		///<summary><![CDATA[bool]]></summary>
		public const int bPropagateEffectActor = 0x047C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData07 = 0x047D;

		///<summary><![CDATA[FProjectileData]]></summary>
		public const int ProjectileConfig = 0x0480;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ReplicatedEffectActor = 0x04B0;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData08 = 0x04B8;

	}

	public class ATslProjectileMolotov
	{
		///<summary><![CDATA[TEnumAsByte<EMolotovSimulationType>]]></summary>
		public const int MolotovSimulation = 0x04E8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x04E9;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageFieldContainerTemplate = 0x04F0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageFieldContainerInWallTemplate = 0x04F8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageFieldTemplate = 0x0500;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageFieldTemplateInWall = 0x0508;

		///<summary><![CDATA[UClass *]]></summary>
		public const int FragmentProjectileClass = 0x0510;

		///<summary><![CDATA[int]]></summary>
		public const int ImpactMaxCount = 0x0518;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData01 = 0x051C;

	}

	public class ATslProjectileRedZone
	{
		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int CreateSound = 0x04E8;

	}

	public class UTslReactionDoorComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x09C0;

		///<summary><![CDATA[UTslReactionDoorData *]]></summary>
		public const int ReactionDoorData = 0x09C8;

		///<summary><![CDATA[UDestructibleMesh *]]></summary>
		public const int DoorDestructibleMesh = 0x09D0;

		///<summary><![CDATA[FDoorBreakingState]]></summary>
		public const int DoorBreakingState = 0x09D8;

		///<summary><![CDATA[unsigned char[0x37]]]></summary>
		public const int UnknownData01 = 0x09D9;

	}

	public class UTslSceneCaptureComponent2D
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0A20;

		///<summary><![CDATA[UWorld *]]></summary>
		public const int World = 0x0A28;

	}

	public class UTslSceneCaptureWorld
	{
		///<summary><![CDATA[unsigned char[0x28]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UWorld *]]></summary>
		public const int World = 0x0050;

		///<summary><![CDATA[unsigned char[0x48]]]></summary>
		public const int UnknownData01 = 0x0058;

	}

	public class ATslServerParticle
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bAutoDestroyOnParticleFinish = 0x03B0;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoPlaySound = 0x03B1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x03B2;

		///<summary><![CDATA[UParticleSystemComponent *]]></summary>
		public const int ParticleSystem = 0x03B8;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int AkSound = 0x03C0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x03C8;

	}

	public class UTslSingleton
	{
		///<summary><![CDATA[unsigned char[0x110]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[UWeaponsPenetrationConfig *]]></summary>
		public const int WeaponsPenetrationConfig = 0x0138;

	}

	public class UTslSmokePropagationComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03E0;

		///<summary><![CDATA[UTslSmokeParticleSystemComponent *]]></summary>
		public const int SmokeParticle = 0x03E8;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData01 = 0x03F0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int BlockingActorTemplate = 0x0410;

		///<summary><![CDATA[float]]></summary>
		public const int HalfHeightGlobal = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int HalfHeightLocalScalar = 0x041C;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalRadius = 0x0420;

		///<summary><![CDATA[float]]></summary>
		public const int GlobalAngle = 0x0424;

		///<summary><![CDATA[int]]></summary>
		public const int RadialTryCount = 0x0428;

		///<summary><![CDATA[int]]></summary>
		public const int LoopCount = 0x042C;

		///<summary><![CDATA[int]]></summary>
		public const int LastWorkerIndex = 0x0430;

		///<summary><![CDATA[float]]></summary>
		public const int MaxDistanceFromHost = 0x0434;

		///<summary><![CDATA[float]]></summary>
		public const int CeilingTraceDistance = 0x0438;

		///<summary><![CDATA[FVector]]></summary>
		public const int MainParticleVelocityScale_First = 0x043C;

		///<summary><![CDATA[FVector]]></summary>
		public const int MainParticleVelocityScale_Second = 0x0448;

		///<summary><![CDATA[FVector]]></summary>
		public const int MainParticleVelocityScale_Third = 0x0454;

		///<summary><![CDATA[float]]></summary>
		public const int HorizontalRayTraceOffset = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int HorizontalRayRadiusScalar = 0x0464;

		///<summary><![CDATA[float]]></summary>
		public const int HorizontalRayPropagateOffset = 0x0468;

		///<summary><![CDATA[float]]></summary>
		public const int BlockerGroundTraceOffset = 0x046C;

		///<summary><![CDATA[FVector]]></summary>
		public const int LowChildVelocityStaticVector = 0x0470;

		///<summary><![CDATA[FVector]]></summary>
		public const int HighChildVelocityStaticVector = 0x047C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int LowChildVelocityInMap = 0x0488;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int LowChildVelocityOutMap = 0x0490;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int HighChildVelocityInMap = 0x0498;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int HighChildVelocityOutMap = 0x04A0;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentRadialRay = 0x04A8;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentSpawnedChildCount = 0x04AC;

		///<summary><![CDATA[int]]></summary>
		public const int MaxTicksAllowed = 0x04B0;

		///<summary><![CDATA[int]]></summary>
		public const int MaxChildrenAllowed = 0x04B4;

		///<summary><![CDATA[float]]></summary>
		public const int CustomTickInterval = 0x04B8;

		///<summary><![CDATA[float]]></summary>
		public const int StartDelay = 0x04BC;

		///<summary><![CDATA[bool]]></summary>
		public const int bDebugPropagation = 0x04C0;

		///<summary><![CDATA[bool]]></summary>
		public const int bDebugTick = 0x04C1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x04C2;

		///<summary><![CDATA[float]]></summary>
		public const int ParticleLifetime = 0x04C4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ParticleLifetimeRandomOffset = 0x04C8;

		///<summary><![CDATA[float]]></summary>
		public const int ParticleToObjectLifeScale = 0x04D0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData03 = 0x04D4;

	}

	public class ATslSpectatorPawn
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int ReplayHUD = 0x0438;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LevelAttribute_BattleRoyalRule = 0x0440;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LevelAttribute_Erangel = 0x0448;

		///<summary><![CDATA[UClass *]]></summary>
		public const int LevelAttribute_Desert = 0x0450;

		///<summary><![CDATA[float]]></summary>
		public const int PlayerInfoMinDistance = 0x0458;

		///<summary><![CDATA[float]]></summary>
		public const int PlayerInfoMaxDistance = 0x045C;

		///<summary><![CDATA[USpringArmComponent *]]></summary>
		public const int FreeCameraSpringArmComponent = 0x0460;

		///<summary><![CDATA[UCameraComponent *]]></summary>
		public const int FreeCameraComponent = 0x0468;

		///<summary><![CDATA[USpringArmComponent *]]></summary>
		public const int FollowCameraSpringArmComponent = 0x0470;

		///<summary><![CDATA[UCameraComponent *]]></summary>
		public const int FollowCameraComponent = 0x0478;

		///<summary><![CDATA[UArrowComponent *]]></summary>
		public const int AudioListener = 0x0480;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0488;

		///<summary><![CDATA[float]]></summary>
		public const int DeathFollowBlendTime = 0x048C;

		///<summary><![CDATA[TEnumAsByte<EViewTargetBlendFunction>]]></summary>
		public const int DeathFollowBlendFunc = 0x0490;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0491;

		///<summary><![CDATA[float]]></summary>
		public const int DeathFollowBlendExp = 0x0494;

		///<summary><![CDATA[float]]></summary>
		public const int DeathFollowTime = 0x0498;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x049C;

		///<summary><![CDATA[float]]></summary>
		public const int DeathFollowDistance = 0x04A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x04A4;

		///<summary><![CDATA[FName]]></summary>
		public const int DeathFollowBone = 0x04A8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x04B0;

		///<summary><![CDATA[float]]></summary>
		public const int LocationUpdateIntervalSeconds = 0x04B4;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData05 = 0x04B8;

		///<summary><![CDATA[float]]></summary>
		public const int LimitMinFreeCamFov = 0x04BC;

		///<summary><![CDATA[float]]></summary>
		public const int LimitMaxFreeCamFov = 0x04C0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData06 = 0x04C4;

		///<summary><![CDATA[float]]></summary>
		public const int FollowCameraZoomSpeed = 0x04D0;

		///<summary><![CDATA[float]]></summary>
		public const int LimitTargetArmLength = 0x04D4;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int DeathCharacter = 0x04D8;

		///<summary><![CDATA[float]]></summary>
		public const int SpectatableCheckLength = 0x04E0;

		///<summary><![CDATA[float]]></summary>
		public const int SpectatableCheckScreenRatio = 0x04E4;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData07 = 0x04E8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int OutlineEffectClass = 0x0500;

		///<summary><![CDATA[ATslPostProcessEffect *]]></summary>
		public const int OutlineEffect = 0x0508;

		///<summary><![CDATA[TArray<FSavedObPos>]]></summary>
		public const int ArrObPos = 0x0510;

		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData08 = 0x0520;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ReplayZoneEffectClass = 0x0590;

		///<summary><![CDATA[ATslPostProcessEffect *]]></summary>
		public const int ReplayZoneEffect = 0x0598;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPlayerInfoDistanceDelegate = 0x05A0;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData09 = 0x05B0;

	}

	public class UTslSpectatorPawnMovement
	{
		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0280;

		///<summary><![CDATA[float]]></summary>
		public const int FastMoveModifier = 0x0284;

		///<summary><![CDATA[float]]></summary>
		public const int SlowMoveModifier = 0x0288;

		///<summary><![CDATA[float]]></summary>
		public const int MinFreeMoveSpeed = 0x028C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFreeMoveSpeed = 0x0290;

		///<summary><![CDATA[float]]></summary>
		public const int MinFreeMoveSpeedHeight = 0x0294;

		///<summary><![CDATA[float]]></summary>
		public const int MaxFreeMoveSpeedHeight = 0x0298;

		///<summary><![CDATA[float]]></summary>
		public const int AbsoluteMinZ = 0x029C;

		///<summary><![CDATA[float]]></summary>
		public const int AbsoluteMaxZ = 0x02A0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData01 = 0x02A4;

	}

	public class UTslStreamer
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UFoliageCollisionStreamer
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bEnabled = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[float]]></summary>
		public const int MinDistance = 0x004C;

		///<summary><![CDATA[float]]></summary>
		public const int MaxQueryDistance = 0x0050;

		///<summary><![CDATA[float]]></summary>
		public const int MaxSimulationDistance = 0x0054;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseOnlyQueryAndPhysics = 0x0058;

		///<summary><![CDATA[unsigned char[0x57]]]></summary>
		public const int UnknownData01 = 0x0059;

	}

	public class ULODActorStreamer
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bEnabled = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[float]]></summary>
		public const int PreLoadDistance = 0x004C;

		///<summary><![CDATA[int]]></summary>
		public const int PerFrameShowCount = 0x0050;

		///<summary><![CDATA[int]]></summary>
		public const int PerFrameShowCountLimit = 0x0054;

		///<summary><![CDATA[TArray<FFloatRange>]]></summary>
		public const int MinDrawDistanceOverride = 0x0058;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0068;

	}

	public class UParticleEnvrionmentStreamer
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bEnabled = 0x0048;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0049;

		///<summary><![CDATA[float]]></summary>
		public const int ToleranceDeactiveDistance = 0x004C;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData01 = 0x0050;

	}

	public class ATslStreamerManager
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x03B0;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int StreamerClasses = 0x03B8;

		///<summary><![CDATA[TArray<UTslStreamer * >]]></summary>
		public const int TslStreamers = 0x03C8;

	}

	public class UTslThrowableTrajectoryViewComponent
	{
		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int SplineSegmentMesh = 0x0910;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int SplineSegmentMeshMaterial = 0x0918;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int SegmentMeshScale = 0x0920;

		///<summary><![CDATA[UStaticMesh *]]></summary>
		public const int ImpactMesh = 0x0928;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int ImpactMeshMaterial = 0x0930;

		///<summary><![CDATA[FVector]]></summary>
		public const int ImpactMeshScale = 0x0938;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0944;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData01 = 0x0944;

		///<summary><![CDATA[float]]></summary>
		public const int PredictionTime = 0x0998;

		///<summary><![CDATA[float]]></summary>
		public const int DistanceScaleFactor = 0x099C;

		///<summary><![CDATA[FName]]></summary>
		public const int MaterialParam_NearDepthFadeOrigin = 0x09A0;

		///<summary><![CDATA[FName]]></summary>
		public const int MaterialParam_FarDepthFadeOrigin = 0x09A8;

		///<summary><![CDATA[float]]></summary>
		public const int SplineGenerationAngThresholdDeg = 0x09B0;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData02 = 0x09B4;

		///<summary><![CDATA[UStaticMeshComponent *]]></summary>
		public const int ImpactMeshComponent = 0x09C0;

		///<summary><![CDATA[TArray<USplineMeshComponent * >]]></summary>
		public const int SplineMeshArray = 0x09C8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int SplineSegmentMeshMaterialDynamic = 0x09D8;

	}

	public class UTslUserWidget
	{
		///<summary><![CDATA[UInputComponent *]]></summary>
		public const int InputComponentAxis = 0x0240;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int CachedTslCharacter = 0x0248;

		///<summary><![CDATA[ATslGameState *]]></summary>
		public const int CachedTslGameState = 0x0250;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int CachedViewTargetTslCharacter = 0x0258;

	}

	public class UBlockInputUserWidget
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bWhiteList = 0x0260;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0261;

		///<summary><![CDATA[TArray<FBlockAction>]]></summary>
		public const int BlockActions = 0x0268;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int BlockAxises = 0x0278;

		///<summary><![CDATA[bool]]></summary>
		public const int bGenerateEventOnOpen = 0x0288;

		///<summary><![CDATA[bool]]></summary>
		public const int bLockMouseCursorInViewport = 0x0289;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x028A;

	}

	public class UUmgBaseWidget
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseEmergingAnimation = 0x0260;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseVanishingAnimation = 0x0260;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0261;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int EmergingAnimationBinder = 0x0268;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int VanishingAnimationBinder = 0x0288;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x02A8;

		///<summary><![CDATA[ESlateVisibility]]></summary>
		public const int PendingVisibility = 0x02C0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x02C1;

		///<summary><![CDATA[float]]></summary>
		public const int VanishingStartTime = 0x02C4;

	}

	public class UTslXboxTeamManageWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int TeamMemberVerticalBox_Binder = 0x0290;

	}

	public class UBluezoneGpsBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int BluezoneGaugeImageBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int BluezoneTimeTextBinder = 0x02F0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int PlayerIconImageBinder = 0x0310;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int MovingAnimationBinder = 0x0338;

		///<summary><![CDATA[TArray<FUmgWidgetBinder_Animation>]]></summary>
		public const int WarningAnimationList = 0x0358;

		///<summary><![CDATA[TArray<FUmgWidgetBinder_Animation>]]></summary>
		public const int ReleasingTextAnimationList = 0x0368;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int EnterNextPlayzoneAnimBinder = 0x0378;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int LeaveNextPlayzoneAnimBinder = 0x0398;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int WidgetEmergingAnimBinder = 0x03B8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int WidgetVanishingAminBinder = 0x03D8;

		///<summary><![CDATA[FName]]></summary>
		public const int PlayZoneStartParmName = 0x03F8;

		///<summary><![CDATA[FName]]></summary>
		public const int BluezoneEndParamName = 0x0400;

		///<summary><![CDATA[FName]]></summary>
		public const int ColorMultiplyParmName = 0x0408;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int InNextPlayzoneColorMultiply = 0x0410;

		///<summary><![CDATA[FText]]></summary>
		public const int WarningTimeTextFormat = 0x0420;

		///<summary><![CDATA[FText]]></summary>
		public const int ReleaseTimeText = 0x0438;

		///<summary><![CDATA[FSequence_Float]]></summary>
		public const int BluezoneResetSequence = 0x0450;

		///<summary><![CDATA[FSequence_Float]]></summary>
		public const int PlayzoneResetSequence = 0x04F0;

		///<summary><![CDATA[FSequence_Float]]></summary>
		public const int PlayerIconResetSequence = 0x0590;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0630;

	}

	public class UCharacterStanceBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int StanceIconImageBinder = 0x02C8;

		///<summary><![CDATA[FName]]></summary>
		public const int IconStateParamName = 0x02F0;

	}

	public class UEquipableItemIconBaseWidget
	{
		///<summary><![CDATA[EEquipSlotID]]></summary>
		public const int EquipSlotID = 0x02C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x02C9;

		///<summary><![CDATA[FDurabilityColorSet]]></summary>
		public const int DurabilityColorSet = 0x02D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseWrning = 0x02E0;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x02E1;

		///<summary><![CDATA[FFloatInterval]]></summary>
		public const int WarningRange = 0x02E4;

		///<summary><![CDATA[EEquipableItemIconVisibility]]></summary>
		public const int IconVisibilityType = 0x02EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x02ED;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int IconImageBinder = 0x02F0;

		///<summary><![CDATA[FName]]></summary>
		public const int IconTexParamName = 0x0318;

		///<summary><![CDATA[FName]]></summary>
		public const int IconColorParamName = 0x0320;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DefaultColor = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int WarningAnimBinder = 0x0338;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int NoBagSpaceAnimBinder = 0x0358;

	}

	public class UInteractionBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int MainLayer = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int InteractionMessageTextBinder = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int InteractionMessageTextBgBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int AdditionalTextBinder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int SuitableWeaponImageBinder = 0x0348;

		///<summary><![CDATA[float]]></summary>
		public const int SuitableWeaponImageHeight = 0x0370;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0374;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int KeyImageBinder = 0x0378;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int InteractionKeyTextBinder = 0x03A0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AdditionalMessageBlinkingBinder = 0x03C0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AdditionalMessageNormalBinder = 0x03E0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int ShowAnimationBinder = 0x0400;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int HiddenAnimationBinder = 0x0420;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int SwitchAnimationBinder = 0x0440;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int SwitchAnimationResetBinder = 0x0460;

		///<summary><![CDATA[FUmgWidgetBinder_WidgetSwitcher]]></summary>
		public const int InteractionInputMethodSwitcherBinder = 0x0480;

		///<summary><![CDATA[FName]]></summary>
		public const int InteractionKeyName = 0x04A0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int ProgressCircle_Binder = 0x04A8;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int InteractionTextColor_Interactable = 0x04D0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int InteractionTextShadowColor_Interactable = 0x04E0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int InteractionTextColor_NotInteractable = 0x04F0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int InteractionTextShadowColor_NotInteractable = 0x0500;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData01 = 0x0510;

	}

	public class UKillCountBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int KillCountTextBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int IncreasingAnimBinder = 0x02E8;

		///<summary><![CDATA[float]]></summary>
		public const int IncreasingKillCountDisplayTime = 0x0308;

		///<summary><![CDATA[int]]></summary>
		public const int LastKillCount = 0x030C;

		///<summary><![CDATA[bool]]></summary>
		public const int bLastWantShow = 0x0310;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0311;

		///<summary><![CDATA[float]]></summary>
		public const int IncreasingKillCountDisplayStartTime = 0x0314;

	}

	public class ULifeGaugeBaseWidget
	{
		///<summary><![CDATA[UTslHealthGaugeData *]]></summary>
		public const int LifeGaugeColorData = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int LifeGaugeImageBinder = 0x02D0;

		///<summary><![CDATA[FName]]></summary>
		public const int LifeGaugeRatioValueParamName = 0x02F8;

		///<summary><![CDATA[FName]]></summary>
		public const int LifeGaugeColorParamName = 0x0300;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int HealAmountImageBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_Overlay]]></summary>
		public const int HitEffectLayer = 0x0330;

		///<summary><![CDATA[FName]]></summary>
		public const int HealAmountRatioValueParamName = 0x0350;

		///<summary><![CDATA[FName]]></summary>
		public const int HealAmountRatioSartParamName = 0x0358;

		///<summary><![CDATA[FName]]></summary>
		public const int HealAmountRatioEndParamName = 0x0360;

		///<summary><![CDATA[FName]]></summary>
		public const int HealAmountColorParamName = 0x0368;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int HealEffectTimeCurve = 0x0370;

		///<summary><![CDATA[UClass *]]></summary>
		public const int HitEffectClass = 0x0378;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Item_Heal_FirstAid = 0x0380;

		///<summary><![CDATA[UClass *]]></summary>
		public const int Item_Heal_MedKit = 0x0388;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int WarningAnimationBinder = 0x0390;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int GroggyAnimationBinder = 0x03B0;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x03D0;

	}

	public class ULifeGaugeEffectBaseWidget
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x02C8;

		///<summary><![CDATA[FName]]></summary>
		public const int OldLifeRatioParamName = 0x02D8;

		///<summary><![CDATA[FName]]></summary>
		public const int CurrentLifeRatioParamName = 0x02E0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int LifeEffectBinder = 0x02E8;

		///<summary><![CDATA[TArray<FUiEffectAnimation_FloatCurve>]]></summary>
		public const int LifeEffectAnimationFloatCurveList = 0x0310;

		///<summary><![CDATA[TArray<FUiEffectAnimation_VectorCurve>]]></summary>
		public const int LifeEffectAnimationVectorCurveList = 0x0320;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int LifeEffectBackgroundBinder = 0x0330;

		///<summary><![CDATA[TArray<FUiEffectAnimation_FloatCurve>]]></summary>
		public const int LifeEffectBgAnimationFloatCurveList = 0x0358;

		///<summary><![CDATA[TArray<FUiEffectAnimation_VectorCurve>]]></summary>
		public const int LifeEffectBgAnimationVectorCurveList = 0x0368;

		///<summary><![CDATA[bool]]></summary>
		public const int bAutoDestroyOnEffectPlayFinish = 0x0378;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0379;

	}

	public class ULifeGaugeHitEffectBaseWidget
	{
		///<summary><![CDATA[TArray<FGaugeAlphaCurveType>]]></summary>
		public const int AlphaCurveList = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int HitEffectImage = 0x02D8;

		///<summary><![CDATA[FName]]></summary>
		public const int BaseColorParamName = 0x0300;

		///<summary><![CDATA[FName]]></summary>
		public const int ColorLerpParamName = 0x0308;

		///<summary><![CDATA[FName]]></summary>
		public const int BrightAlphaParamName = 0x0310;

		///<summary><![CDATA[FName]]></summary>
		public const int HitEffectAlphaParamName = 0x0318;

		///<summary><![CDATA[FName]]></summary>
		public const int HitEffectStartParamName = 0x0320;

		///<summary><![CDATA[FName]]></summary>
		public const int HitEffectEndParamName = 0x0328;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x0330;

	}

	public class ULifeGaugeTemplateBaseWidget
	{
		///<summary><![CDATA[UTslHealthGaugeData *]]></summary>
		public const int LifeGaugeColorData = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int LifeGaugeImageBinder = 0x02D0;

		///<summary><![CDATA[FName]]></summary>
		public const int LifeGaugeRatioValueParamName = 0x02F8;

		///<summary><![CDATA[FName]]></summary>
		public const int LifeGaugeColorParamName = 0x0300;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int WarningAnimationBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int BackgroundImageBinder = 0x0328;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideLifeGaugeMaterial = 0x0350;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0351;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int OverrideLifeGaugeMaterial = 0x0358;

		///<summary><![CDATA[bool]]></summary>
		public const int bOverrideBackgroundMaterial = 0x0360;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0361;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int OverrideBackgroundMaterial = 0x0368;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseEffect = 0x0370;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0371;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageEffectClass = 0x0378;

		///<summary><![CDATA[UClass *]]></summary>
		public const int HealEffectClass = 0x0380;

		///<summary><![CDATA[UClass *]]></summary>
		public const int HealAmountEffectClass = 0x0388;

		///<summary><![CDATA[FUmgWidgetBinder_Overlay]]></summary>
		public const int EffectLayerBinder = 0x0390;

		///<summary><![CDATA[int]]></summary>
		public const int DamageEffectMax = 0x03B0;

		///<summary><![CDATA[int]]></summary>
		public const int HealEffectMax = 0x03B4;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData03 = 0x03B8;

		///<summary><![CDATA[TArray<ULifeGaugeEffectBaseWidget * >]]></summary>
		public const int DamageEffects = 0x03D0;

		///<summary><![CDATA[TArray<ULifeGaugeEffectBaseWidget * >]]></summary>
		public const int HealEffects = 0x03E0;

		///<summary><![CDATA[ULifeGaugeEffectBaseWidget *]]></summary>
		public const int HealAmountEffect = 0x03F0;

	}

	public class UMapCarePackageItemIconBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int IconImageBorderBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int IconImageBinder = 0x02E8;

		///<summary><![CDATA[FName]]></summary>
		public const int IconStateParamName = 0x0310;

		///<summary><![CDATA[FName]]></summary>
		public const int IconColorParamName = 0x0318;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0320;

	}

	public class UMapCharacterIconBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int IconImageBorderBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int IconImageBinder = 0x02E8;

		///<summary><![CDATA[FName]]></summary>
		public const int IconStateParamName = 0x0310;

		///<summary><![CDATA[FName]]></summary>
		public const int IconRotationParamName = 0x0318;

		///<summary><![CDATA[FName]]></summary>
		public const int IconColorParamName = 0x0320;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int PlayerNameBoderBinder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int PlayerNameBinder = 0x0348;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int ObserverMuzzleFlashBoderBinder = 0x0368;

		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int ObserverMuzzleFlashWidgetBinder = 0x0388;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int LifeGaugeBorderBinder = 0x03A8;

		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int LifeGaugeWidgetBinder = 0x03C8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AttackedAnimBinder = 0x03E8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int HittedAnimBinder = 0x0408;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int GroggyAnimBinder = 0x0428;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeOutAnimBinder = 0x0448;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int ButtonBInder = 0x0468;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0488;

		///<summary><![CDATA[bool]]></summary>
		public const int bTeamNumber = 0x0498;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0499;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int TeamNumberText = 0x04A0;

		///<summary><![CDATA[FUmgWidgetBinder_Overlay]]></summary>
		public const int RiderLayerBinder = 0x04C0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int RiderIconClass = 0x04E0;

		///<summary><![CDATA[FText]]></summary>
		public const int DisplayNameFormatWithOtherPlayer = 0x04E8;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int MyDirectionIcon = 0x0500;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int TeamDirectionIcon = 0x0508;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int SpectatedIconBorder = 0x0510;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int NameTagColorImageBinder = 0x0530;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData02 = 0x0558;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int PendingIconMaterial = 0x0570;

		///<summary><![CDATA[TArray<URiderIconWidget * >]]></summary>
		public const int RiderIconList = 0x0578;

	}

	public class UMapGridWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int MapImageBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int MyMarkerLayerBinder = 0x02F0;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int TeamMarkerLayerBinder = 0x0310;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MapMarkerClass = 0x0330;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int MyMapIconLayerBinder = 0x0338;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int OtherMapIconLayerBinder = 0x0358;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CarePackageItemIconLayerBinder = 0x0378;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MapCharacterIconClass = 0x0398;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MapCarePackageItemIconClass = 0x03A0;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ObserverPlayerIconHitEffectClass = 0x03A8;

		///<summary><![CDATA[bool]]></summary>
		public const int bShowName = 0x03B0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsMinimap = 0x03B1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x03B2;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int RedzoneImageBinder = 0x03B8;

		///<summary><![CDATA[FName]]></summary>
		public const int RedzoneColorParamName = 0x03E0;

		///<summary><![CDATA[FColorBlindColorSet]]></summary>
		public const int RedzoneColorSet = 0x03E8;

		///<summary><![CDATA[FUmgWidgetBinder_SizeBox]]></summary>
		public const int ImageSizeBoxBinder = 0x03F8;

		///<summary><![CDATA[FColorBlindColorSet]]></summary>
		public const int BluezoneColorSet = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int Desaturation = 0x0428;

		///<summary><![CDATA[float]]></summary>
		public const int Contrast = 0x042C;

		///<summary><![CDATA[float]]></summary>
		public const int ZoomLevel = 0x0430;

		///<summary><![CDATA[float]]></summary>
		public const int ShowGridZoomLevel = 0x0434;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int ViewRatioCurve = 0x0438;

		///<summary><![CDATA[bool]]></summary>
		public const int bRectangleViewMode = 0x0440;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0441;

		///<summary><![CDATA[UFont *]]></summary>
		public const int GridFont = 0x0448;

		///<summary><![CDATA[FName]]></summary>
		public const int FontTypeFace = 0x0450;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int GridTextHorizentalArray = 0x0458;

		///<summary><![CDATA[TArray<FString>]]></summary>
		public const int GridTextVerticalArray = 0x0468;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorLargeGrid = 0x0478;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorSmallGrid = 0x0488;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorText = 0x0498;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorSafetyZone = 0x04A8;

		///<summary><![CDATA[float]]></summary>
		public const int ThicknessLargeGrid = 0x04B8;

		///<summary><![CDATA[float]]></summary>
		public const int ThicknessSmallGrid = 0x04BC;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int ColorPoisonGasWarning = 0x04C0;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawGridLine = 0x04D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawGridText = 0x04D1;

		///<summary><![CDATA[bool]]></summary>
		public const int bDrawNextPlayzoneGuideLine = 0x04D2;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseZOrderSort = 0x04D3;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseTeamMemberColor = 0x04D4;

		///<summary><![CDATA[bool]]></summary>
		public const int bRemoveDeadIcon = 0x04D5;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData02 = 0x04D6;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int DefaultIconNameTagColor = 0x04D8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData03 = 0x04E8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MatInst = 0x04F8;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData04 = 0x0500;

		///<summary><![CDATA[UMapMarkerBaseWidget *]]></summary>
		public const int MyMapMarker = 0x0518;

		///<summary><![CDATA[TMap<ATeam *,UMapMarkerBaseWidget * >]]></summary>
		public const int TeamPlayerMarkers = 0x0520;

		///<summary><![CDATA[UMapCharacterIconBaseWidget *]]></summary>
		public const int MyCharacterMapIcon = 0x0570;

		///<summary><![CDATA[TMap<AActor *,UMapCharacterIconBaseWidget * >]]></summary>
		public const int OtherCharacterMapIcons = 0x0578;

		///<summary><![CDATA[TMap<ACarePackageItem *,UMapCarePackageItemIconBaseWidget * >]]></summary>
		public const int MapCarePackageItemIcons = 0x05C8;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int ReplicatedCharacterListUpdateTimer = 0x0618;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int ReplicatedCarePackageItemListUpdateTimer = 0x0620;

		///<summary><![CDATA[TArray<ATslCharacter * >]]></summary>
		public const int ReplicatedCharacterList = 0x0628;

		///<summary><![CDATA[TArray<ACarePackageItem * >]]></summary>
		public const int ReplicatedCarePackageItemList = 0x0638;

		///<summary><![CDATA[TArray<ATeam * >]]></summary>
		public const int ShowMarkerOnwerList = 0x0648;

		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData05 = 0x0658;

		///<summary><![CDATA[UMaterialInstance *]]></summary>
		public const int MyOrTeamIconMaterial = 0x0678;

		///<summary><![CDATA[UMaterialInstance *]]></summary>
		public const int OtherCharacterIconMaterial = 0x0680;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int CloseMySelf = 0x0688;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnHideOwner = 0x0698;

	}

	public class UMapMarkerBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int MarkerImageBinder = 0x02C8;

		///<summary><![CDATA[FName]]></summary>
		public const int MarkerColorParmName = 0x02F0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int MarkerEmergingAnimBinder = 0x02F8;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0318;

	}

	public class UMiniMapBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int MapWidgetBinder = 0x02C8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x02E8;

	}

	public class UNetworkProblemBaseWidget
	{
		///<summary><![CDATA[int]]></summary>
		public const int CheckElapsedTime = 0x02C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02CC;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int IconBlinkingAnimBinder = 0x02D0;

	}

	public class UReplayProblemBaseWidget
	{
		///<summary><![CDATA[int]]></summary>
		public const int CheckElapsedTime = 0x02C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02CC;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int IconBlinkingAnimBinder = 0x02D0;

	}

	public class URiderIconWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int RiderIcon = 0x02C8;

	}

	public class UTeamMarkWidget
	{
		///<summary><![CDATA[ATeam *]]></summary>
		public const int TeamMember = 0x02C8;

		///<summary><![CDATA[float]]></summary>
		public const int OffsetZ = 0x02D0;

		///<summary><![CDATA[float]]></summary>
		public const int DeadMarkInvisibleTime = 0x02D4;

		///<summary><![CDATA[float]]></summary>
		public const int DeadMarkInvisibleDistance = 0x02D8;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultImageAlpha = 0x02DC;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultTextAlpha = 0x02E0;

		///<summary><![CDATA[float]]></summary>
		public const int AmingImageAlpha = 0x02E4;

		///<summary><![CDATA[float]]></summary>
		public const int ScopingImageAlpha = 0x02E8;

		///<summary><![CDATA[float]]></summary>
		public const int AmingTextAlpha = 0x02EC;

		///<summary><![CDATA[float]]></summary>
		public const int ScopingTextAlpha = 0x02F0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int OffScreenEdgeSize = 0x02F4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int OffScreenImageEdgeSize = 0x02FC;

		///<summary><![CDATA[float]]></summary>
		public const int AnimationMaxDistance = 0x0304;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int StateSwitcherBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int PlayerNameTextBinder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int OutLineImageBinder = 0x0348;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int DirectionImageBinder = 0x0370;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int NormalImageBinder = 0x0398;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int GroggyImageBinder = 0x03C0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int DeadImageBinder = 0x03E8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int VehicleImageBinder = 0x0410;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int ParachuteImageBinder = 0x0438;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int QuitterImageBinder = 0x0460;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int ScaleOpacityByDistanceAnim = 0x0488;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int ImageMarkBorderBinder = 0x04A8;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int OutScreenImage = 0x04C8;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int GroggyImage = 0x04D0;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int VehicleImage = 0x04D8;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int ParachuteImage = 0x04E0;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x04E8;

	}

	public class UTeamOverallKillCountBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int TeamOverallKillCountTextBinder = 0x02C8;

		///<summary><![CDATA[int]]></summary>
		public const int LastTeamOverallKillCount = 0x02E8;

		///<summary><![CDATA[bool]]></summary>
		public const int bLastWantShow = 0x02EC;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x02ED;

	}

	public class UTslAdaptiveCrosshairWidget
	{
		///<summary><![CDATA[EWeaponClass]]></summary>
		public const int WeaponClass = 0x02C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsShowWidget = 0x02C9;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x02CA;

		///<summary><![CDATA[FColorBlindColorSet]]></summary>
		public const int ColorBlindColors = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int AdaptiveCrosshair_Binder = 0x02E0;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CanvasBase_Binder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CenterCenter_Binder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CenterCrosshair_Binder = 0x0348;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CenterD_Binder = 0x0368;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int CenterDOT_Binder = 0x0388;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CenterL_Binder = 0x03B0;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CenterR_Binder = 0x03D0;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int CenterU_Binder = 0x03F0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Pistol_C_Binder = 0x0410;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Pistol_C_Gradient_Binder = 0x0438;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Pistol_L_Binder = 0x0460;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Pistol_R_Binder = 0x0488;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_D_Binder = 0x04B0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_D_Arrow_Binder = 0x04D8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_L_Binder = 0x0500;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_L_Arrow_Binder = 0x0528;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_R_Binder = 0x0550;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_R_Arrow_Binder = 0x0578;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_U_Binder = 0x05A0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Rifle_U_Arrow_Binder = 0x05C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Shotgun_D_Binder = 0x05F0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Shotgun_L_Binder = 0x0618;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Shotgun_R_Binder = 0x0640;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int Shotgun_U_Binder = 0x0668;

	}

	public class UTslAlivePlayerInfoWidget
	{
		///<summary><![CDATA[ATslGameState *]]></summary>
		public const int CachedTslGS = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int ColorOverlay_Binder = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Warning_Binder = 0x02F0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Increasing_Binder = 0x0310;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Decreasing_Binder = 0x0330;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Default_Binder = 0x0350;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int AdditionalInfo_Binder = 0x0370;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int SurvivorCount_Binder = 0x0390;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsReplaying = 0x03B0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHidden = 0x03B1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03B2;

		///<summary><![CDATA[int]]></summary>
		public const int CurrentCount = 0x03B4;

		///<summary><![CDATA[int]]></summary>
		public const int DisplayCount = 0x03B8;

		///<summary><![CDATA[int]]></summary>
		public const int WhileAnimCount = 0x03BC;

	}

	public class UTslKeyDisplayWidget
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKeyInputed = 0x02C8;

		///<summary><![CDATA[TArray<UTslKeyReceiverWidget * >]]></summary>
		public const int KeyReceiverWidgets = 0x02D8;

		///<summary><![CDATA[TArray<FUmgWidgetBinder_UserWidget>]]></summary>
		public const int KeyReceiverWidgetBinders = 0x02E8;

		///<summary><![CDATA[FName]]></summary>
		public const int InputName = 0x02F8;

		///<summary><![CDATA[FName]]></summary>
		public const int CategoryName = 0x0300;

		///<summary><![CDATA[FText]]></summary>
		public const int DisplayText = 0x0308;

		///<summary><![CDATA[bool]]></summary>
		public const int bGamepad = 0x0320;

		///<summary><![CDATA[bool]]></summary>
		public const int bAxisInput = 0x0321;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x0322;

		///<summary><![CDATA[float]]></summary>
		public const int AxisScale = 0x0324;

	}

	public class UTslKeyOptionWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int ScrollBox_Binder = 0x02C8;

		///<summary><![CDATA[TArray<UTslKeySettingWidget * >]]></summary>
		public const int KeySettingWidgets = 0x02E8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MouseSettingWidgetClass = 0x02F8;

		///<summary><![CDATA[UTslBaseOptionWidget *]]></summary>
		public const int MouseSettingWidget = 0x0300;

		///<summary><![CDATA[UClass *]]></summary>
		public const int KeySettingWidgetClass = 0x0308;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GamePadSettingWidgetClass = 0x0310;

		///<summary><![CDATA[UTslBaseOptionWidget *]]></summary>
		public const int GamePadSettingWidget = 0x0318;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int CategoryOrder = 0x0320;

	}

	public class UTslKeySettingWidget
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKeyChanged = 0x02C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int KeyDisplayWidgetClass = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int KeyScrollBoxBinder = 0x02E0;

		///<summary><![CDATA[TArray<UTslKeyDisplayWidget * >]]></summary>
		public const int KeyDisplayWidgets = 0x0300;

		///<summary><![CDATA[FText]]></summary>
		public const int DisplayText = 0x0310;

		///<summary><![CDATA[FName]]></summary>
		public const int CategoryName = 0x0328;

	}

	public class UTslBoostGaugeWidget
	{
		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MID_Gauge0_21 = 0x02C8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MID_Gauge20_61 = 0x02D0;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MID_Gauge60_91 = 0x02D8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MID_Gauge90_101 = 0x02E0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int VanishingAnimBinder = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int WarningAnimBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int EmergingAnimBinder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int Boost0_20ImageBinder = 0x0348;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int Boost20_60ImageBinder = 0x0368;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int Boost60_90ImageBinder = 0x0388;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int Boost90_100ImageBinder = 0x03A8;

		///<summary><![CDATA[float]]></summary>
		public const int DisplayingBoost = 0x03C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsWarning = 0x03CC;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVanished = 0x03CD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData00 = 0x03CE;

	}

	public class UTslBreatheBarWidget
	{
		///<summary><![CDATA[ATslHUD *]]></summary>
		public const int TslHudCached = 0x02C8;

		///<summary><![CDATA[ATslPlayerController *]]></summary>
		public const int TslPlayerControllerCached = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int BreathGaugeLayer_Binder = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int BreathGaugeBG_Binder = 0x02F8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Breathing_Binder = 0x0320;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Drowning_Binder = 0x0340;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Vanishing_Binder = 0x0360;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Emerging_Binder = 0x0380;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Cooldown_Binder = 0x03A0;

		///<summary><![CDATA[float]]></summary>
		public const int BreathRatioDisplay = 0x03C0;

		///<summary><![CDATA[float]]></summary>
		public const int BreathRatio = 0x03C4;

		///<summary><![CDATA[float]]></summary>
		public const int LerpTolerance = 0x03C8;

		///<summary><![CDATA[float]]></summary>
		public const int LerpTime = 0x03CC;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BreathImgColor_Less_101 = 0x03D0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BreathImgColor_Less_51 = 0x03E0;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int BreathImgColor_Less_11 = 0x03F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVanishing = 0x0400;

		///<summary><![CDATA[bool]]></summary>
		public const int bEventBound = 0x0401;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsCooldown = 0x0402;

		///<summary><![CDATA[unsigned char[0x5]]]></summary>
		public const int UnknownData00 = 0x0403;

	}

	public class UTslBuffIconListWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_SizeBox]]></summary>
		public const int RunBuffIconBlock_Binder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int RunBuffIcon_Binder = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_SizeBox]]></summary>
		public const int HealBuffIconBlock_Binder = 0x0310;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int HealBuffIcon_Binder = 0x0330;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int HealBuffIconTex = 0x0358;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int RunBuffIconTex = 0x0360;

	}

	public class UTslCastableItemIconWidget
	{
		///<summary><![CDATA[ECastableItemType]]></summary>
		public const int CastableItemType = 0x02C8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x02C9;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int ItemIcon = 0x02D0;

		///<summary><![CDATA[float]]></summary>
		public const int ItemIconRatio = 0x02D8;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int NormalColor = 0x02DC;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int NoItemColor = 0x02EC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x02FC;

		///<summary><![CDATA[FUmgWidgetBinder_Gerneral]]></summary>
		public const int Icon_Binder = 0x0300;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int ItemCountText_Binder = 0x0320;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int WidgetBorder_Binder = 0x0340;

		///<summary><![CDATA[FUmgWidgetBinder_SizeBox]]></summary>
		public const int IconSizeBox_Binder = 0x0360;

	}

	public class UTslCompassMarkerWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int CompassMarkerImageBinder = 0x02C8;

		///<summary><![CDATA[int]]></summary>
		public const int MarkerNumber = 0x02F0;

		///<summary><![CDATA[float]]></summary>
		public const int XViewSize = 0x02F4;

		///<summary><![CDATA[bool]]></summary>
		public const int bShow = 0x02F8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x02F9;

	}

	public class UTslCompassWidget
	{
		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MI_Compass = 0x02C8;

		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MID_Compass = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int CompassImageBinder = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int MarkerImageBinder = 0x0300;

		///<summary><![CDATA[FUmgWidgetBinder_Overlay]]></summary>
		public const int MyOverlayBinder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_Overlay]]></summary>
		public const int TeamOverlayBinder = 0x0348;

		///<summary><![CDATA[UClass *]]></summary>
		public const int CompassMarkerWidgetClass = 0x0368;

		///<summary><![CDATA[UTslCompassMarkerWidget *]]></summary>
		public const int MyCompassMarkerWidget = 0x0370;

		///<summary><![CDATA[TArray<UTslCompassMarkerWidget * >]]></summary>
		public const int TeamMarkerWidgetOfTeam = 0x0378;

		///<summary><![CDATA[float]]></summary>
		public const int DivisionLevel = 0x0388;

		///<summary><![CDATA[float]]></summary>
		public const int Offset = 0x038C;

		///<summary><![CDATA[bool]]></summary>
		public const int bClockwise = 0x0390;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0391;

		///<summary><![CDATA[float]]></summary>
		public const int Width = 0x0394;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsInitilzed = 0x0398;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0399;

	}

	public class UTslConfirmationDialogWidget
	{
		///<summary><![CDATA[unsigned char[0xE8]]]></summary>
		public const int UnknownData00 = 0x02C8;

	}

	public class UTslGroggyCircleWidget
	{
		///<summary><![CDATA[UMaterialInstanceDynamic *]]></summary>
		public const int MID_ProgressCircle = 0x02C8;

		///<summary><![CDATA[UMaterialInterface *]]></summary>
		public const int MI_ProgressCircle = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int CircleImageBinder = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int CrossImageBinder = 0x0300;

	}

	public class UTslHealItemSelectorWidget
	{
		///<summary><![CDATA[AInventory *]]></summary>
		public const int InventoryCached = 0x02C8;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int HealItemSelectorTimer = 0x02D0;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int WidgetHideTimer = 0x02D8;

		///<summary><![CDATA[ECastableItemType]]></summary>
		public const int LastSelectedHealItemType = 0x02E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x02E1;

		///<summary><![CDATA[TArray<FHealItemSelectorData>]]></summary>
		public const int HealItemDatas = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int ItemIcon_Binder = 0x02F8;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int InitialPosition = 0x0320;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int OffsetWhenTpsWeaponIconEnabled = 0x0328;

	}

	public class UTslInventoryCapacityWidget
	{
		///<summary><![CDATA[float]]></summary>
		public const int GameMaxSpace = 0x02C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02CC;

		///<summary><![CDATA[AInventory *]]></summary>
		public const int InventoryCached = 0x02D0;

	}

	public class UTslKeyReceiverWidget
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnKeyReceived = 0x02C8;

		///<summary><![CDATA[FTslInputKey]]></summary>
		public const int OriginKey = 0x02D8;

		///<summary><![CDATA[FKey]]></summary>
		public const int FirstDownKey = 0x02F8;

		///<summary><![CDATA[FTslInputKey]]></summary>
		public const int CurrentDownKey = 0x0310;

		///<summary><![CDATA[FTslInputKey]]></summary>
		public const int LastDownedKey = 0x0330;

		///<summary><![CDATA[bool]]></summary>
		public const int bFocused = 0x0350;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableInput = 0x0351;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsKeyUp = 0x0352;

		///<summary><![CDATA[bool]]></summary>
		public const int bAxisInput = 0x0353;

		///<summary><![CDATA[float]]></summary>
		public const int AxisScale = 0x0354;

		///<summary><![CDATA[TArray<FKey>]]></summary>
		public const int MouseButtons = 0x0358;

	}

	public class UTslKillMessageListWidget
	{
		///<summary><![CDATA[UClass *]]></summary>
		public const int KillMessageWidgetClass = 0x02C8;

		///<summary><![CDATA[TArray<UTslKillMessageWidget * >]]></summary>
		public const int KillMessageWidgetArray = 0x02D0;

		///<summary><![CDATA[float]]></summary>
		public const int FadeoutStartTime = 0x02E0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02E4;

	}

	public class UTslKillMessageWidget
	{
		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnVanishAnimationFinished = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int Vanish_Binder = 0x02D8;

		///<summary><![CDATA[TArray<FCauseOfDeathData>]]></summary>
		public const int CauseOfDeathDatas = 0x02F8;

		///<summary><![CDATA[TArray<FConditionOfDeathData>]]></summary>
		public const int ConditionOfDeathDatas = 0x0308;

	}

	public class UTslLobbyNameTagWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int NickName_Binder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int HostImage_Binder = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int ReadyImage_Binder = 0x0310;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int VoiceImage_Binder = 0x0338;

		///<summary><![CDATA[bool]]></summary>
		public const int bTestAlwaysShowIcons = 0x0360;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0361;

		///<summary><![CDATA[int]]></summary>
		public const int SlotIndex = 0x0364;

		///<summary><![CDATA[FVector]]></summary>
		public const int NameTagOffsetTranslation = 0x0368;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsHost = 0x0374;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsReady = 0x0375;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsSpeaking = 0x0376;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData01 = 0x0377;

	}

	public class UTslObserverPlayerInfoWidget
	{
		///<summary><![CDATA[TArray<FLinearColor>]]></summary>
		public const int TeamColorsCached = 0x02C8;

		///<summary><![CDATA[UTexture *]]></summary>
		public const int UnArmedIcon = 0x02D8;

		///<summary><![CDATA[float]]></summary>
		public const int UnArmedIconRatio = 0x02E0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02E4;

		///<summary><![CDATA[ATslCharacter *]]></summary>
		public const int CachedCharacter = 0x02E8;

		///<summary><![CDATA[int]]></summary>
		public const int OldAmmoCount = 0x02F0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x02F4;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AmmoIncreasingAnimBinder = 0x02F8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AmmoDecreasingAnimBinder = 0x0318;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int UserNameText_Binder = 0x0338;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int TeamNumberText_Binder = 0x0358;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int AmmoCountText_Binder = 0x0378;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int KillCountText_Binder = 0x0398;

		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int LifeGaugeTemplateWidget_Binder = 0x03B8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int WeaponIconImageBinder = 0x03D8;

		///<summary><![CDATA[FUmgWidgetBinder_SizeBox]]></summary>
		public const int WeaponIconImageSizeBoxBinder = 0x0400;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponIconTextureParmName = 0x0420;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponIconColorParmName = 0x0428;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int WeaponColor_Armed = 0x0430;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int WeaponColor_Normal = 0x0440;

		///<summary><![CDATA[FColorBlindColorSet]]></summary>
		public const int WeaponColorSet_NoReload = 0x0450;

	}

	public class UTslTeamInfoListWidget
	{
		///<summary><![CDATA[TArray<UTslTeamInfoWidget * >]]></summary>
		public const int TeamInfoWidgetList = 0x02C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int TeamInfoWidgetClass = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_VerticalBox]]></summary>
		public const int VerticalBoxBinder = 0x02E0;

	}

	public class UTslTeamInfoWidget
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bBindVoiceChatEvent = 0x02C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bSpeaking = 0x02C9;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData00 = 0x02CA;

		///<summary><![CDATA[FUmgWidgetBinder_HorizontalBox]]></summary>
		public const int TeamHpAreaBinder = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int TeamInfoAreaBinder = 0x02F0;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int InfoIconBorderBinder = 0x0310;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int InfoIconBinder = 0x0330;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int SpeakingImageBinder = 0x0358;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int MarkerIconBorderBinder = 0x0380;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int MarkerImageBinder = 0x03A0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int BoostImageBinder = 0x03C8;

		///<summary><![CDATA[bool]]></summary>
		public const int bUdateTeamNameColor = 0x03F0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x03F1;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int TeamNameBinder = 0x03F8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int OnSpeakAnimBinder = 0x0418;

		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int HealthGaugeWidgetBinder = 0x0438;

		///<summary><![CDATA[FColorBlindColorSet]]></summary>
		public const int ColorBlindColorSet = 0x0458;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int TeamMemberColorBinder = 0x0468;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int PlayerIconImageBinder = 0x0490;

		///<summary><![CDATA[ATeam *]]></summary>
		public const int Team = 0x04B8;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int QuitColor = 0x04C0;

	}

	public class UTslTeamWidget
	{
		///<summary><![CDATA[TArray<UTeamMarkWidget * >]]></summary>
		public const int TeamMarkWidgets = 0x02C8;

		///<summary><![CDATA[UClass *]]></summary>
		public const int TeamMarkWidgetClass = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_CanvasPanel]]></summary>
		public const int TeamMarkerLayerBinder = 0x02E0;

	}

	public class UTslXboxTeamManageInfoWidget
	{
		///<summary><![CDATA[int]]></summary>
		public const int MemberNumber = 0x02C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02CC;

		///<summary><![CDATA[FName]]></summary>
		public const int UserName = 0x02D0;

		///<summary><![CDATA[bool]]></summary>
		public const int bIsVoiceMute = 0x02D8;

		///<summary><![CDATA[unsigned char[0x17]]]></summary>
		public const int UnknownData01 = 0x02D9;

	}

	public class UVehicleFuelBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int OilGaugeImageBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int OilGaugeBgImageBinder = 0x02F0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int OilArrowImageBinder = 0x0318;

		///<summary><![CDATA[FUmgWidgetBinder_Overlay]]></summary>
		public const int GaugeBodyBinder = 0x0340;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int NormalColor = 0x0360;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int FuelEmptyColor = 0x0370;

		///<summary><![CDATA[FName]]></summary>
		public const int GaugePramName = 0x0380;

	}

	public class UVehicleSeatInfoBaseWidget
	{
		///<summary><![CDATA[int]]></summary>
		public const int SeatIndex = 0x02C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02CC;

		///<summary><![CDATA[FName]]></summary>
		public const int StateParamName = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int SeatImageBinder = 0x02D8;

		///<summary><![CDATA[APawn *]]></summary>
		public const int CachedVehiclePawn = 0x0300;

		///<summary><![CDATA[UTslVehicleSeatComponent *]]></summary>
		public const int CachedSeatComponent = 0x0308;

	}

	public class UVehicleStanceBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_VerticalBox]]></summary>
		public const int VehicleIconAreaBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int SpeedTextBinder = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int LifeGaugeWidgetBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int FuelGaugeWidgetBinder = 0x0328;

		///<summary><![CDATA[APawn *]]></summary>
		public const int CachedVehiclePawn = 0x0348;

		///<summary><![CDATA[UUserWidget *]]></summary>
		public const int CachedVehicleIconWidget = 0x0350;

	}

	public class UVehicleWheelInfoBaseWidget
	{
		///<summary><![CDATA[int]]></summary>
		public const int WheelIndex = 0x02C8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x02CC;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int WheelImageBinder = 0x02D0;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int PunctureImageBinder = 0x02F8;

		///<summary><![CDATA[ATslWheeledVehicle *]]></summary>
		public const int CachedVehiclePawn = 0x0320;

		///<summary><![CDATA[UTslWheeledVehicleMovement *]]></summary>
		public const int CachedVehicleMovement = 0x0328;

	}

	public class UVersionInfoBaseWidget
	{
		///<summary><![CDATA[FText]]></summary>
		public const int WithNickNameFormat = 0x02C8;

		///<summary><![CDATA[FText]]></summary>
		public const int WithOutNickNameFormat = 0x02E0;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int VersionInfoTextBinder = 0x02F8;

	}

	public class UWeaponSlotBaseWidget
	{
		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bListInSlot = 0x02C8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x02C9;

		///<summary><![CDATA[int]]></summary>
		public const int WeaponIndex = 0x02CC;

		///<summary><![CDATA[ENoReloadGuideType]]></summary>
		public const int ListSlotNoReloadGuideType = 0x02D0;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseWeaponIcon = 0x02D1;

		///<summary><![CDATA[unsigned char[0x6]]]></summary>
		public const int UnknownData01 = 0x02D2;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int WeaponIconImageBinder = 0x02D8;

		///<summary><![CDATA[FUmgWidgetBinder_SizeBox]]></summary>
		public const int WeaponIconImageSizeBoxBinder = 0x0300;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponIconImageSizeBoxHeight = 0x0320;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0324;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponIconTextureParmName = 0x0328;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponIconColorParmName = 0x0330;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int WeaponColor_Armed = 0x0338;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int WeaponColor_Normal = 0x0348;

		///<summary><![CDATA[FLinearColor]]></summary>
		public const int WeaponColor_Unarmed = 0x0358;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int ScaleUpAnimBinder = 0x0368;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int ScaleDownAnimBinder = 0x0388;

		///<summary><![CDATA[FColorBlindColorSet]]></summary>
		public const int WeaponColorSet_NoReload = 0x03A8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseAmmoTextAndIcon = 0x03B8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x03B9;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int WeaponHandsOnLoadedAmmoCountTextBinder = 0x03C0;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int WeaponListLoadedAmmoCountTextBinder = 0x03E0;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AmmoIncreasingAnimBinder = 0x0400;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int AmmoDecreasingAnimBinder = 0x0420;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int WeaponHandsOnUnloadedAmmoCountTextBinder = 0x0440;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int UnloadedAmmoIncreasingAnimBinder = 0x0460;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int UnloadedAmmoDecreasingAnimBinder = 0x0480;

		///<summary><![CDATA[FUmgWidgetBinder_Image]]></summary>
		public const int WeaponHandsOnAmmoIconBinder = 0x04A0;

		///<summary><![CDATA[FName]]></summary>
		public const int AmmoTexParamName = 0x04C8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bUseWeaponFiringModeTextBinder = 0x04D0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData04 = 0x04D1;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int WeaponFiringModeTextBinder = 0x04D8;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bZeroingDistancebUseText = 0x04F8;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData05 = 0x04F9;

		///<summary><![CDATA[FUmgWidgetBinder_VerticalBox]]></summary>
		public const int ZeroingDistanceBlockBinder = 0x0500;

		///<summary><![CDATA[FUmgWidgetBinder_TextBlock]]></summary>
		public const int ZeroingdistanceTextBinder = 0x0520;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int ZeroDistIncreasingAnimBinder = 0x0540;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int ZeroDistDecreasingAnimBinder = 0x0560;

		///<summary><![CDATA[FText]]></summary>
		public const int ZeroingTextFormat = 0x0580;

		///<summary><![CDATA[FText]]></summary>
		public const int ZeroingNA = 0x0598;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int WeaponIconBackground = 0x05B0;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int AmmoAndFringModeBackground = 0x05D0;

		///<summary><![CDATA[float]]></summary>
		public const int SlotBackgroundAlpha_Armed = 0x05F0;

		///<summary><![CDATA[float]]></summary>
		public const int SlotBackgroundAlpha_Unarmed = 0x05F4;

		///<summary><![CDATA[float]]></summary>
		public const int SlotBackgroundAlpha_Normal = 0x05F8;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData06 = 0x05FC;

	}

	public class UWeaponSlotHudBaseWidget
	{
		///<summary><![CDATA[FUmgWidgetBinder_UserWidget]]></summary>
		public const int CurrentWeaponSlotWidgetBinder = 0x02C8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeInWeaponSlotAnimBinder = 0x02E8;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeOutWeaponSlotAnimBinder = 0x0308;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeInUnarmedWeaponSlotAminBinder = 0x0328;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeOutUnarmedWeaponSlotAminBinder = 0x0348;

		///<summary><![CDATA[TArray<FUmgWidgetBinder_UserWidget>]]></summary>
		public const int WeaponSlotWidgetBinderList = 0x0368;

		///<summary><![CDATA[FUmgWidgetBinder_Border]]></summary>
		public const int WeaponSlotListBorderBinder = 0x0378;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeInSlotListAminBinder = 0x0398;

		///<summary><![CDATA[FUmgWidgetBinder_Animation]]></summary>
		public const int FadeOutSlotListAminBinder = 0x03B8;

		///<summary><![CDATA[float]]></summary>
		public const int SlotOffsetMultiply = 0x03D8;

		///<summary><![CDATA[float]]></summary>
		public const int SlotPadding = 0x03DC;

		///<summary><![CDATA[FSequence_Float]]></summary>
		public const int MovingSequence = 0x03E0;

		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x0480;

		///<summary><![CDATA[FTimerHandle]]></summary>
		public const int FinishTimer = 0x04B0;

		///<summary><![CDATA[AWeaponProcessor *]]></summary>
		public const int CachedWeaponProcessor = 0x04B8;

	}

	public class UTslVehicleAnimInstance
	{
		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x0890;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_Steering_Right = 0x0894;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_Steering_Final = 0x08A0;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_Speed_Left = 0x08AC;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_Speed_Right = 0x08B8;

		///<summary><![CDATA[float]]></summary>
		public const int SpeedMax = 0x08C4;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_Speed_Final = 0x08C8;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_RPM_Left = 0x08D4;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_RPM_Right = 0x08E0;

		///<summary><![CDATA[float]]></summary>
		public const int RPMMax = 0x08EC;

		///<summary><![CDATA[bool]]></summary>
		public const int bTickIndicators = 0x08F0;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseAbsoluteSteeringRotation = 0x08F1;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x08F2;

		///<summary><![CDATA[FRotator]]></summary>
		public const int Rot_RPM_Final = 0x08F4;

		///<summary><![CDATA[ATslWheeledVehicle *]]></summary>
		public const int VehicleRef = 0x0900;

		///<summary><![CDATA[UTslWheeledVehicleMovement *]]></summary>
		public const int VehicleMovementRef = 0x0908;

	}

	public class UTslVehicleCommonComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnRepair = 0x01E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDeath = 0x01F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnHealthChange = 0x0208;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnFuelChange = 0x0218;

		///<summary><![CDATA[FName]]></summary>
		public const int SimpleBodyBoneName = 0x0228;

		///<summary><![CDATA[TArray<FName>]]></summary>
		public const int ComplexBodyBoneNames = 0x0230;

		///<summary><![CDATA[FName]]></summary>
		public const int MainComplexBodyBoneName = 0x0240;

		///<summary><![CDATA[FName]]></summary>
		public const int ComplexCollisionProfileName = 0x0248;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsDying = 0x0250;

		///<summary><![CDATA[unsigned char:1]]></summary>
		public const int bIsBroken = 0x0250;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0251;

		///<summary><![CDATA[float]]></summary>
		public const int Health = 0x0254;

		///<summary><![CDATA[float]]></summary>
		public const int HealthMax = 0x0258;

		///<summary><![CDATA[float]]></summary>
		public const int Fuel = 0x025C;

		///<summary><![CDATA[float]]></summary>
		public const int FuelMax = 0x0260;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x0264;

		///<summary><![CDATA[UClass *]]></summary>
		public const int VehicleExplosionDamageType = 0x0268;

		///<summary><![CDATA[TArray<TEnumAsByte<EDamageTypeCategory>>]]></summary>
		public const int CharacterDamageIgnores = 0x0270;

		///<summary><![CDATA[UClass *]]></summary>
		public const int VehicleUI = 0x0280;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData03 = 0x0288;

	}

	public class UVehicleSurfaceAudioData
	{
		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int EventIn = 0x0030;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int EventOut = 0x0038;

	}

	public class UTslVehicleEffectComponent
	{
		///<summary><![CDATA[UMeshComponent *]]></summary>
		public const int MeshComponent = 0x01E0;

		///<summary><![CDATA[UAkComponent *]]></summary>
		public const int EngineSoundComponent = 0x01E8;

		///<summary><![CDATA[FVehicleEffectInfo]]></summary>
		public const int VehicleEffectInfo = 0x01F0;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int MufflerEffect = 0x02E0;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int Muffler2Effect = 0x02E8;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int BoostEffect = 0x02F0;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int Boost2Effect = 0x02F8;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int DamagedEffect = 0x0300;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int ExplosionEffect = 0x0308;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int FrontTrailEffect = 0x0310;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int RearTrailEffect = 0x0318;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int ThrusterEffect = 0x0320;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int Thruster2Effect = 0x0328;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int FrontFoamLeftEffect = 0x0330;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int FrontFoamRightEffect = 0x0338;

		///<summary><![CDATA[unsigned char[0x1C]]]></summary>
		public const int UnknownData00 = 0x0340;

		///<summary><![CDATA[float]]></summary>
		public const int TrailSpeedThreshold = 0x035C;

		///<summary><![CDATA[float]]></summary>
		public const int FrontFoamSpawnThreshold = 0x0360;

		///<summary><![CDATA[bool]]></summary>
		public const int bRPMOverride = 0x0364;

		///<summary><![CDATA[unsigned char[0x13]]]></summary>
		public const int UnknownData01 = 0x0365;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseNewChassisAudio = 0x0378;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData02 = 0x0379;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_EngineAudio = 0x0380;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseDopplerEffect = 0x0388;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData03 = 0x0389;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseNewSurfaceAudio = 0x03E0;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData04 = 0x03E1;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int MeasuredWheelIndices = 0x03E8;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int MeasuredWheelIndicesSlip = 0x03F8;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int MeasuredWheelIndicesSpin = 0x0408;

		///<summary><![CDATA[TArray<int>]]></summary>
		public const int MeasuredWheelIndicesBrake = 0x0418;

		///<summary><![CDATA[float]]></summary>
		public const int SuspenionOffsetForContact = 0x0428;

		///<summary><![CDATA[float]]></summary>
		public const int SurfaceActivationValue = 0x042C;

		///<summary><![CDATA[float]]></summary>
		public const int SurfaceDeactivationValue = 0x0430;

		///<summary><![CDATA[float]]></summary>
		public const int DT_Multiplier = 0x0434;

		///<summary><![CDATA[float]]></summary>
		public const int MinVelocityForSurfaceCheck = 0x0438;

		///<summary><![CDATA[float]]></summary>
		public const int MinSlip = 0x043C;

		///<summary><![CDATA[float]]></summary>
		public const int MinSpin = 0x0440;

		///<summary><![CDATA[float]]></summary>
		public const int MinVelocityForBreak = 0x0444;

		///<summary><![CDATA[float]]></summary>
		public const int BrakeNoDriverMultiplier = 0x0448;

		///<summary><![CDATA[int]]></summary>
		public const int VelocityInterpSpeed = 0x044C;

		///<summary><![CDATA[int]]></summary>
		public const int SlipInterpSpeed = 0x0450;

		///<summary><![CDATA[int]]></summary>
		public const int SpinInterpSpeed = 0x0454;

		///<summary><![CDATA[int]]></summary>
		public const int BreakInterpSpeed = 0x0458;

		///<summary><![CDATA[bool]]></summary>
		public const int bDebugVisualizedMeasuredWheels = 0x045C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData05 = 0x045D;

		///<summary><![CDATA[float]]></summary>
		public const int AngularVelocityCoefficient = 0x0460;

		///<summary><![CDATA[float]]></summary>
		public const int LateralVelocityCoeffictient = 0x0464;

		///<summary><![CDATA[float]]></summary>
		public const int LateralVelocityClamp = 0x0468;

		///<summary><![CDATA[bool]]></summary>
		public const int bProcessShiftStart = 0x046C;

		///<summary><![CDATA[bool]]></summary>
		public const int bProcessShiftEnd = 0x046D;

		///<summary><![CDATA[bool]]></summary>
		public const int bProcessReverse = 0x046E;

		///<summary><![CDATA[unsigned char[0x1]]]></summary>
		public const int UnknownData06 = 0x046F;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int GearUpSound_Start = 0x0470;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int GearDownSound_Start = 0x0478;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int GearUpSound_End = 0x0480;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int GearDownSound_End = 0x0488;

		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int GearReverseSound = 0x0490;

		///<summary><![CDATA[unsigned char[0x90]]]></summary>
		public const int UnknownData07 = 0x0498;

		///<summary><![CDATA[float]]></summary>
		public const int ApplyDestroyedMaterialDelay = 0x0578;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData08 = 0x057C;

	}

	public class UTslVehicleHitComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[UMeshComponent *]]></summary>
		public const int MeshComponent = 0x01E8;

		///<summary><![CDATA[float]]></summary>
		public const int HitCharacterDuration = 0x01F0;

		///<summary><![CDATA[unsigned char[0x54]]]></summary>
		public const int UnknownData01 = 0x01F4;

		///<summary><![CDATA[float]]></summary>
		public const int LeaveCharacterIgnoreDuration = 0x0248;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterHitMinimumVehicleSpeed = 0x024C;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterDamageVelocityUnitMultiplier = 0x0250;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterDamageMassUnitMultiplier = 0x0254;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CharacterDamageSpeedCurve = 0x0258;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int CharacterDamageMassCurve = 0x0260;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumCharacterDamage = 0x0268;

		///<summary><![CDATA[float]]></summary>
		public const int CharacterLaunchSpeedMultiplier = 0x026C;

		///<summary><![CDATA[float]]></summary>
		public const int MinimumCharacterLaunchSpeed = 0x0270;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpulseMultiplier = 0x0274;

		///<summary><![CDATA[UPhysicalMaterial *]]></summary>
		public const int VoidPhysicalMaterial = 0x0278;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactModifier = 0x0280;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactModifierUpsideDown = 0x0284;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactAbsorption = 0x0288;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactAbsorptionUpsideDown = 0x028C;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactAbsorptionRider = 0x0290;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactAbsorptionRiderUpsideDown = 0x0294;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactVehicleDamageMultiplier = 0x0298;

		///<summary><![CDATA[float]]></summary>
		public const int PhysicsImpactRiderDamageMultiplier = 0x029C;

		///<summary><![CDATA[UClass *]]></summary>
		public const int VehicleHitDamageType = 0x02A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x02A8;

		///<summary><![CDATA[float]]></summary>
		public const int ExplosionBaseDamage = 0x02AC;

		///<summary><![CDATA[float]]></summary>
		public const int ExplosionMinimumDamage = 0x02B0;

		///<summary><![CDATA[float]]></summary>
		public const int ExplosionRadiusInner = 0x02B4;

		///<summary><![CDATA[float]]></summary>
		public const int ExplosionRadiusOuter = 0x02B8;

		///<summary><![CDATA[float]]></summary>
		public const int ExplosionDamageFalloff = 0x02BC;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ExplosionDamageType = 0x02C0;

		///<summary><![CDATA[TEnumAsByte<ECollisionChannel>]]></summary>
		public const int ExplosionDamagePreventionChannel = 0x02C8;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData03 = 0x02C9;

		///<summary><![CDATA[float]]></summary>
		public const int ImpulseLimitationSpeedThreshold = 0x02D8;

		///<summary><![CDATA[float]]></summary>
		public const int CollectTime = 0x02DC;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData04 = 0x02E0;

		///<summary><![CDATA[TArray<FVehicleDebugHit>]]></summary>
		public const int DebugHitHistory = 0x02F0;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData05 = 0x0300;

		///<summary><![CDATA[TArray<UClass * >]]></summary>
		public const int HitAbsorberTypes = 0x0308;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData06 = 0x0318;

	}

	public class UTslVehicleSeatComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnLeave = 0x01E8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDriverRide = 0x01F8;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnDriverLeave = 0x0208;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPostDriverRide = 0x0218;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnPostDriverLeave = 0x0228;

		///<summary><![CDATA[TArray<FVehicleSeatInfo>]]></summary>
		public const int SeatInfos = 0x0238;

		///<summary><![CDATA[TArray<UVehicleSeatInteractionComponent * >]]></summary>
		public const int Seats = 0x0248;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseSeatCamera = 0x0258;

		///<summary><![CDATA[bool]]></summary>
		public const int bDoFlipCheck = 0x0259;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData01 = 0x025A;

		///<summary><![CDATA[float]]></summary>
		public const int FlipForce = 0x025C;

		///<summary><![CDATA[bool]]></summary>
		public const int bDoEntryAngleCheck = 0x0260;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0261;

		///<summary><![CDATA[float]]></summary>
		public const int MinEntryAngle = 0x0264;

		///<summary><![CDATA[bool]]></summary>
		public const int bDampenPlayerVelocityOnLeave = 0x0268;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData03 = 0x0269;

		///<summary><![CDATA[float]]></summary>
		public const int OnLeaveVelocityMultiplier = 0x026C;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseActiveStabilize = 0x0270;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x0271;

		///<summary><![CDATA[TWeakObjectPtr<ATslCharacter>]]></summary>
		public const int LastDriver = 0x0274;

		///<summary><![CDATA[unsigned char[0x64]]]></summary>
		public const int UnknownData05 = 0x027C;

	}

	public class UTslVehicleSyncComponent
	{
		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[float]]></summary>
		public const int MinCorrectionInterval = 0x01EC;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x01F0;

		///<summary><![CDATA[float]]></summary>
		public const int SendingToServerIntervalAtClient = 0x01F4;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x01F8;

		///<summary><![CDATA[float]]></summary>
		public const int SendingReliableHitToServerIntervalAtClient = 0x0200;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x0204;

		///<summary><![CDATA[float]]></summary>
		public const int AllowedMaxDistanceSqAtServer = 0x0208;

		///<summary><![CDATA[float]]></summary>
		public const int StationaryCorrectionIntervalAtClient = 0x020C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData04 = 0x0210;

		///<summary><![CDATA[float]]></summary>
		public const int StationaryCorrectionSpeedThresholdSq = 0x0214;

		///<summary><![CDATA[float]]></summary>
		public const int StationaryCorrectionThresholdDistanceSq = 0x0218;

		///<summary><![CDATA[unsigned char[0x14]]]></summary>
		public const int UnknownData05 = 0x021C;

	}

	public class UTslViewTargetTempComponent
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x01E0;

	}

	public class ATslWeapon_Trajectory
	{
		///<summary><![CDATA[float]]></summary>
		public const int TrajectoryGravityZ = 0x0AE0;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilSpreadScale = 0x0AE4;

		///<summary><![CDATA[bool]]></summary>
		public const int FireAtViewPoint = 0x0AE8;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0AE9;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultTimerFrequency = 0x0AEC;

		///<summary><![CDATA[float]]></summary>
		public const int CrouchSpreadModifier = 0x0AF0;

		///<summary><![CDATA[float]]></summary>
		public const int ProneSpreadModifier = 0x0AF4;

		///<summary><![CDATA[float]]></summary>
		public const int WalkSpread = 0x0AF8;

		///<summary><![CDATA[float]]></summary>
		public const int RunSpread = 0x0AFC;

		///<summary><![CDATA[float]]></summary>
		public const int JumpSpread = 0x0B00;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x0B04;

		///<summary><![CDATA[FTrajectoryWeaponData]]></summary>
		public const int TrajectoryConfig = 0x0B08;

		///<summary><![CDATA[FRecoilInfo]]></summary>
		public const int RecoilInfo = 0x0B88;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ImpactTemplate = 0x0BF0;

		///<summary><![CDATA[UParticleSystem *]]></summary>
		public const int TrailFX = 0x0BF8;

		///<summary><![CDATA[FName]]></summary>
		public const int TrailTargetParam = 0x0C50;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData02 = 0x0C58;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponSpread = 0x0C70;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilModifier_Stand = 0x0C74;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilModifier_Crouch = 0x0C78;

		///<summary><![CDATA[float]]></summary>
		public const int RecoilModifier_Prone = 0x0C7C;

		///<summary><![CDATA[float]]></summary>
		public const int VerticalRecoilMin = 0x0C80;

		///<summary><![CDATA[float]]></summary>
		public const int VerticalRecoilMax = 0x0C84;

		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData03 = 0x0C88;

	}

	public class ATslWeapon_Melee
	{
		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int AttackSoundAk = 0x07D8;

		///<summary><![CDATA[TArray<FMeleeWeaponAnim>]]></summary>
		public const int AttackAnims = 0x07E0;

		///<summary><![CDATA[float]]></summary>
		public const int Damage = 0x07F0;

		///<summary><![CDATA[float]]></summary>
		public const int WeaponImpact = 0x07F4;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DamageType = 0x07F8;

		///<summary><![CDATA[TEnumAsByte<EHitCheckType>]]></summary>
		public const int HitCheckType = 0x0800;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0801;

		///<summary><![CDATA[float]]></summary>
		public const int AllowedHitRangeLeeway = 0x0804;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ImpactTemplate = 0x0808;

		///<summary><![CDATA[UCapsuleComponent *]]></summary>
		public const int HitCapsuleComponent = 0x0810;

		///<summary><![CDATA[unsigned char[0x78]]]></summary>
		public const int UnknownData01 = 0x0818;

	}

	public class ATslWeapon_Throwable
	{
		///<summary><![CDATA[FThrowableWeaponData]]></summary>
		public const int ThrowableConfig = 0x07D8;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData00 = 0x0878;

		///<summary><![CDATA[TEnumAsByte<EThrowableState>]]></summary>
		public const int ThrowableState = 0x0890;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0891;

		///<summary><![CDATA[FName]]></summary>
		public const int ThrowWeaponSocketName = 0x0898;

		///<summary><![CDATA[FVector]]></summary>
		public const int PawnMotionContributionMultiplier = 0x08A0;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData02 = 0x08AC;

		///<summary><![CDATA[ATslParticle *]]></summary>
		public const int CookingEffect = 0x08B0;

		///<summary><![CDATA[AActor *]]></summary>
		public const int RingAttachment = 0x08B8;

	}

	public class ATslMotorbikeVehicle
	{
		///<summary><![CDATA[bool]]></summary>
		public const int bUseKickstandStabilize = 0x0728;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData00 = 0x0729;

		///<summary><![CDATA[float]]></summary>
		public const int MinSuspensionOffsetForContact = 0x072C;

		///<summary><![CDATA[bool]]></summary>
		public const int bStabilizeOnServer = 0x0730;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData01 = 0x0731;

		///<summary><![CDATA[float]]></summary>
		public const int KickstandStabilizeDamping = 0x0734;

		///<summary><![CDATA[float]]></summary>
		public const int KickstandMaxAngVelocity = 0x0738;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultAngularDamping = 0x073C;

		///<summary><![CDATA[float]]></summary>
		public const int KickstandStabilizeTorqueScalar = 0x0740;

		///<summary><![CDATA[float]]></summary>
		public const int KickstandStabilizeRollScalar = 0x0744;

		///<summary><![CDATA[float]]></summary>
		public const int KickstandStabilizeRollMinRange = 0x0748;

		///<summary><![CDATA[float]]></summary>
		public const int MinVelocityForStabilizeOverride = 0x074C;

		///<summary><![CDATA[FName]]></summary>
		public const int StabilizeBone_Low = 0x0750;

		///<summary><![CDATA[FName]]></summary>
		public const int StabilizeBone_High = 0x0758;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_Roll = 0x0760;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_RollReturn = 0x0768;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_Steer = 0x0770;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_Yaw = 0x0778;

		///<summary><![CDATA[UCurveFloat *]]></summary>
		public const int Curve_Torque = 0x0780;

		///<summary><![CDATA[FVector]]></summary>
		public const int StabStaticVector = 0x0788;

		///<summary><![CDATA[FVector]]></summary>
		public const int StabStaticVectorKickstand = 0x0794;

		///<summary><![CDATA[FVector]]></summary>
		public const int StabNoDriverVector = 0x07A0;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabX_Velocity_In = 0x07AC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabX_Velocity_Out = 0x07B4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabX_Pitch_In = 0x07BC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabX_Pitch_Out = 0x07C4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabZ_Velocity_In = 0x07CC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabZ_Velocity_Out = 0x07D4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabZ_Roll_In = 0x07DC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabZ_Roll_Out = 0x07E4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabZ_Pitch_In = 0x07EC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabZ_Pitch_Out = 0x07F4;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabTorque_In = 0x07FC;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabTorque_Out = 0x0804;

		///<summary><![CDATA[float]]></summary>
		public const int StabTorque_ForceScalar = 0x080C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabTorque_Pitch_In = 0x0810;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int StabTorque_Pitch_Out = 0x0818;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseFlipping = 0x0820;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData02 = 0x0821;

		///<summary><![CDATA[float]]></summary>
		public const int FlippingForce = 0x0824;

		///<summary><![CDATA[float]]></summary>
		public const int InitialFlipTimer = 0x0828;

		///<summary><![CDATA[float]]></summary>
		public const int MinVelocityForFlipping = 0x082C;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x0830;

		///<summary><![CDATA[float]]></summary>
		public const int ContactAlpha_RiseRate = 0x0834;

		///<summary><![CDATA[float]]></summary>
		public const int ContactAlpha_FallRate = 0x0838;

		///<summary><![CDATA[float]]></summary>
		public const int ContactAlpha_LowerClamp = 0x083C;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ContactAlpha_MapPitchIn = 0x0840;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int ContactAlpha_MapRollIn = 0x0848;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int AirControlF_VelMap = 0x0850;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int AirControlB_VelMap = 0x0858;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int AirControlL_VelMap = 0x0860;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int AirControlR_VelMap = 0x0868;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int AirControlQ_VelMap = 0x0870;

		///<summary><![CDATA[FVector2D]]></summary>
		public const int AirControlE_VelMap = 0x0878;

		///<summary><![CDATA[float]]></summary>
		public const int AirControl_FB_Torque = 0x0880;

		///<summary><![CDATA[float]]></summary>
		public const int AirControl_LR_Torque = 0x0884;

		///<summary><![CDATA[float]]></summary>
		public const int AirControl_QE_Torque = 0x0888;

		///<summary><![CDATA[bool]]></summary>
		public const int bStabilizeInAir = 0x088C;

		///<summary><![CDATA[unsigned char[0x3]]]></summary>
		public const int UnknownData04 = 0x088D;

		///<summary><![CDATA[float]]></summary>
		public const int StabilizeAirPercentage = 0x0890;

		///<summary><![CDATA[float]]></summary>
		public const int FC_PitchUp = 0x0894;

		///<summary><![CDATA[float]]></summary>
		public const int FC_PitchDown = 0x0898;

		///<summary><![CDATA[unsigned char[0x31]]]></summary>
		public const int UnknownData05 = 0x089C;

		///<summary><![CDATA[bool]]></summary>
		public const int bKickstandStabilize = 0x08CD;

		///<summary><![CDATA[unsigned char[0x2]]]></summary>
		public const int UnknownData06 = 0x08CE;

	}

	public class ATslMotorbikeVehicle_Sidecar
	{
		///<summary><![CDATA[float]]></summary>
		public const int Sidecar_COM_Y_Left = 0x08D0;

		///<summary><![CDATA[float]]></summary>
		public const int Sidecar_COM_Y_Right = 0x08D4;

		///<summary><![CDATA[FVector]]></summary>
		public const int Sidecar_StabilizerHigh_StaticCOM = 0x08D8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData00 = 0x08E4;

	}

	public class UTslWheelEffectType
	{
		///<summary><![CDATA[UAkAudioEvent *]]></summary>
		public const int Sound = 0x0030;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DefaultFxClass = 0x0038;

		///<summary><![CDATA[UClass *]]></summary>
		public const int ConcreteFxClass = 0x0040;

		///<summary><![CDATA[UClass *]]></summary>
		public const int DirtFxClass = 0x0048;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WaterFxClass = 0x0050;

		///<summary><![CDATA[UClass *]]></summary>
		public const int MetalFxClass = 0x0058;

		///<summary><![CDATA[UClass *]]></summary>
		public const int WoodFxClass = 0x0060;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GrassFxClass = 0x0068;

		///<summary><![CDATA[UClass *]]></summary>
		public const int GlassFxClass = 0x0070;

		///<summary><![CDATA[UClass *]]></summary>
		public const int RockFxClass = 0x0078;

		///<summary><![CDATA[UClass *]]></summary>
		public const int SandFxClass = 0x0080;

		///<summary><![CDATA[float]]></summary>
		public const int DefaultMinSpeed = 0x0088;

		///<summary><![CDATA[float]]></summary>
		public const int ConcreteMinSpeed = 0x008C;

		///<summary><![CDATA[float]]></summary>
		public const int DirtMinSpeed = 0x0090;

		///<summary><![CDATA[float]]></summary>
		public const int WaterMinSpeed = 0x0094;

		///<summary><![CDATA[float]]></summary>
		public const int MetalMinSpeed = 0x0098;

		///<summary><![CDATA[float]]></summary>
		public const int WoodMinSpeed = 0x009C;

		///<summary><![CDATA[float]]></summary>
		public const int GrassMinSpeed = 0x00A0;

		///<summary><![CDATA[float]]></summary>
		public const int GlassMinSpeed = 0x00A4;

		///<summary><![CDATA[float]]></summary>
		public const int RockMinSpeed = 0x00A8;

		///<summary><![CDATA[float]]></summary>
		public const int SandMinSpeed = 0x00AC;

	}

	public class UVehicleRiderComponent
	{
		///<summary><![CDATA[int]]></summary>
		public const int SeatIndex = 0x01E0;

		///<summary><![CDATA[unsigned char[0x3C]]]></summary>
		public const int UnknownData00 = 0x01E4;

		///<summary><![CDATA[APawn *]]></summary>
		public const int LastVehiclePawn = 0x0220;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x0228;

	}

	public class ATslVehicleSeatActor
	{
		///<summary><![CDATA[TEnumAsByte<ERiderType>]]></summary>
		public const int RiderType = 0x0438;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData00 = 0x0439;

	}

	public class UVivoxResponse
	{
		///<summary><![CDATA[unsigned char[0x70]]]></summary>
		public const int UnknownData00 = 0x0028;

	}

	public class USignInResponse
	{
		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UChannelResponse
	{
		///<summary><![CDATA[unsigned char[0x50]]]></summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UKeyRevokeResponse
	{
		///<summary><![CDATA[unsigned char[0x20]]]></summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UKeyAddResponse
	{
		///<summary><![CDATA[unsigned char[0x30]]]></summary>
		public const int UnknownData00 = 0x0098;

	}

	public class UVivoxBaseComponent
	{
		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x01E0;

		///<summary><![CDATA[FScriptMulticastDelegate]]></summary>
		public const int OnParticipantMuteChanged = 0x01E8;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData01 = 0x01F8;

		///<summary><![CDATA[FVivoxConnectionInfo]]></summary>
		public const int ConnectionInfo = 0x0200;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData02 = 0x0220;

		///<summary><![CDATA[FString]]></summary>
		public const int TeamChannelUrl = 0x0228;

		///<summary><![CDATA[FString]]></summary>
		public const int GlobalChannelUrl = 0x0238;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData03 = 0x0248;

		///<summary><![CDATA[float]]></summary>
		public const int ResetFailureDelaySeconds = 0x024C;

		///<summary><![CDATA[unsigned char[0x18]]]></summary>
		public const int UnknownData04 = 0x0250;

		///<summary><![CDATA[float]]></summary>
		public const int UpdatePositionIntervalSeconds = 0x0268;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData05 = 0x026C;

		///<summary><![CDATA[float]]></summary>
		public const int UserInputVolumeModifier = 0x0278;

		///<summary><![CDATA[float]]></summary>
		public const int UserOutputVolumeModifier = 0x027C;

	}

	public class UVivoxComponent
	{
		///<summary><![CDATA[unsigned char[0x2C]]]></summary>
		public const int UnknownData00 = 0x0280;

		///<summary><![CDATA[float]]></summary>
		public const int SuddenMovementDistance = 0x02AC;

		///<summary><![CDATA[float]]></summary>
		public const int SuddenMovementModifier = 0x02B0;

		///<summary><![CDATA[float]]></summary>
		public const int SuddenMovementModifierDuration = 0x02B4;

		///<summary><![CDATA[float]]></summary>
		public const int SuddenMovementModifierRestoreDuration = 0x02B8;

		///<summary><![CDATA[unsigned char[0x4]]]></summary>
		public const int UnknownData01 = 0x02BC;

		///<summary><![CDATA[bool]]></summary>
		public const int bEnableObserverTeamChat = 0x02C0;

		///<summary><![CDATA[unsigned char[0xF]]]></summary>
		public const int UnknownData02 = 0x02C1;

	}

	public class UVivoxLobbyComponent
	{
		///<summary><![CDATA[unsigned char[0x40]]]></summary>
		public const int UnknownData00 = 0x0280;

	}

	public class UVivoxManager
	{
		///<summary><![CDATA[UWorld *]]></summary>
		public const int World = 0x0028;

		///<summary><![CDATA[unsigned char[0x8]]]></summary>
		public const int UnknownData00 = 0x0030;

		///<summary><![CDATA[FVivoxConnectionInfo]]></summary>
		public const int ConnectionInfo = 0x0038;

		///<summary><![CDATA[bool]]></summary>
		public const int bUseEphmeralChannel = 0x0058;

		///<summary><![CDATA[unsigned char[0x7]]]></summary>
		public const int UnknownData01 = 0x0059;

		///<summary><![CDATA[FString]]></summary>
		public const int AuthId = 0x0060;

		///<summary><![CDATA[FString]]></summary>
		public const int AuthPwd = 0x0070;

		///<summary><![CDATA[int64_t]]></summary>
		public const int AccessTokenExpirationTime = 0x0080;

		///<summary><![CDATA[FString]]></summary>
		public const int Issuer = 0x0088;

		///<summary><![CDATA[FString]]></summary>
		public const int Key = 0x0098;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData02 = 0x00A8;

		///<summary><![CDATA[USignInResponse *]]></summary>
		public const int SignIn = 0x00B8;

		///<summary><![CDATA[UKeyAddResponse *]]></summary>
		public const int KeyAdd = 0x00C0;

		///<summary><![CDATA[UKeyRevokeResponse *]]></summary>
		public const int KeyRevoke = 0x00C8;

		///<summary><![CDATA[TArray<UChannelResponse * >]]></summary>
		public const int Channels = 0x00D0;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData03 = 0x00E0;

		///<summary><![CDATA[TArray<ATslPlayerController * >]]></summary>
		public const int PlayerControllers = 0x00F0;

		///<summary><![CDATA[int]]></summary>
		public const int ProximalMaxRange = 0x0100;

		///<summary><![CDATA[int]]></summary>
		public const int ProximalClampingDistance = 0x0104;

		///<summary><![CDATA[int]]></summary>
		public const int ProximalDistanceModel = 0x0108;

		///<summary><![CDATA[unsigned char[0xC]]]></summary>
		public const int UnknownData04 = 0x010C;

	}

	public class UWeaponAnimInfoComponent
	{
		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointRifle = 0x01E0;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointThrowable = 0x01E8;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointMelee = 0x01F0;

		///<summary><![CDATA[USkeletalMeshComponent *]]></summary>
		public const int MeshComponent = 0x01F8;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Primary = 0x0200;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Secondary = 0x0208;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Sidearm = 0x0210;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Melee = 0x0218;

		///<summary><![CDATA[UTslAccessoryComponent *]]></summary>
		public const int CharacterAccessory_Thrown = 0x0220;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponLeftHandIKAttachPoint = 0x0228;

		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0230;

	}

	public class UCharacterWeaponAnimInfoComponent
	{
		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointPistolSitting = 0x0240;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointRifleDriving = 0x0248;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointRifleSitting = 0x0250;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointRifleAim = 0x0258;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointThrowableDriving = 0x0260;

		///<summary><![CDATA[FName]]></summary>
		public const int WeaponAttachPointMeleeDriving = 0x0268;

	}

	public class UWeaponClone
	{
		///<summary><![CDATA[unsigned char[0x10]]]></summary>
		public const int UnknownData00 = 0x0028;

		///<summary><![CDATA[ATslWeapon *]]></summary>
		public const int ClonedWeapon = 0x0038;

	}

	public class UWeaponsPenetrationConfig
	{
		///<summary><![CDATA[TMap<UPhysicalMaterial *,FPhysicalMaterialPenetrationConfig>]]></summary>
		public const int MaterialConfigOverrides = 0x0080;

		///<summary><![CDATA[TMap<UClass *,FWeaponPenetrationConfig>]]></summary>
		public const int WeaponConfigOverrides = 0x0120;

		///<summary><![CDATA[float]]></summary>
		public const int DeflectionRange = 0x01C0;

		///<summary><![CDATA[int]]></summary>
		public const int MaxSurfacesNum = 0x01C4;

		///<summary><![CDATA[float]]></summary>
		public const int MinImpactAngleDeg = 0x01C8;

		///<summary><![CDATA[float]]></summary>
		public const int MinDetectableHollowSize = 0x01CC;

		///<summary><![CDATA[float]]></summary>
		public const int MinOutSpeed = 0x01D0;

		///<summary><![CDATA[float]]></summary>
		public const int MinWaterSpeed = 0x01D4;

	}

}
