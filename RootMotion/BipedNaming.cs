public static class BipedNaming // TypeDefIndex: 9310
{
	// Fields
	public static string[] typeLeft; // 0x0
	public static string[] typeRight; // 0x8
	public static string[] typeSpine; // 0x10
	public static string[] typeHead; // 0x18
	public static string[] typeArm; // 0x20
	public static string[] typeLeg; // 0x28
	public static string[] typeTail; // 0x30
	public static string[] typeEye; // 0x38
	public static string[] typeExclude; // 0x40
	public static string[] typeExcludeSpine; // 0x48
	public static string[] typeExcludeHead; // 0x50
	public static string[] typeExcludeArm; // 0x58
	public static string[] typeExcludeLeg; // 0x60
	public static string[] typeExcludeTail; // 0x68
	public static string[] typeExcludeEye; // 0x70
	public static string[] pelvis; // 0x78
	public static string[] hand; // 0x80
	public static string[] foot; // 0x88

	// Methods

	// RVA: 0x26B5BC0 Offset: 0x26B5CC1 VA: 0x26B5BC0
	public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones) { }

	// RVA: 0x26B5F30 Offset: 0x26B6031 VA: 0x26B5F30
	public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x26B61C0 Offset: 0x26B62C1 VA: 0x26B61C0
	public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x26B6250 Offset: 0x26B6351 VA: 0x26B6250
	public static Transform GetFirstBoneOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x26B6360 Offset: 0x26B6461 VA: 0x26B6360
	public static Transform GetNamingMatch(Transform[] transforms, string[][] namings) { }

	// RVA: 0x26B5D90 Offset: 0x26B5E91 VA: 0x26B5D90
	public static BipedNaming.BoneType GetBoneType(string boneName) { }

	// RVA: 0x26B6100 Offset: 0x26B6201 VA: 0x26B6100
	public static BipedNaming.BoneSide GetBoneSide(string boneName) { }

	// RVA: 0x26B6FA0 Offset: 0x26B70A1 VA: 0x26B6FA0
	public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = 0, string[][] namings) { }

	// RVA: 0x26B6C80 Offset: 0x26B6D81 VA: 0x26B6C80
	private static bool isLeft(string boneName) { }

	// RVA: 0x26B6E10 Offset: 0x26B6F11 VA: 0x26B6E10
	private static bool isRight(string boneName) { }

	// RVA: 0x26B65C0 Offset: 0x26B66C1 VA: 0x26B65C0
	private static bool isSpine(string boneName) { }

	// RVA: 0x26B66E0 Offset: 0x26B67E1 VA: 0x26B66E0
	private static bool isHead(string boneName) { }

	// RVA: 0x26B6800 Offset: 0x26B6901 VA: 0x26B6800
	private static bool isArm(string boneName) { }

	// RVA: 0x26B6920 Offset: 0x26B6A21 VA: 0x26B6920
	private static bool isLeg(string boneName) { }

	// RVA: 0x26B6A40 Offset: 0x26B6B41 VA: 0x26B6A40
	private static bool isTail(string boneName) { }

	// RVA: 0x26B6B60 Offset: 0x26B6C61 VA: 0x26B6B60
	private static bool isEye(string boneName) { }

	// RVA: 0x26B7230 Offset: 0x26B7331 VA: 0x26B7230
	private static bool isTypeExclude(string boneName) { }

	// RVA: 0x26B6490 Offset: 0x26B6591 VA: 0x26B6490
	private static bool matchesNaming(string boneName, string[] namingConvention) { }

	// RVA: 0x26B7190 Offset: 0x26B7291 VA: 0x26B7190
	private static bool excludesNaming(string boneName, string[] namingConvention) { }

	// RVA: 0x26B72A0 Offset: 0x26B73A1 VA: 0x26B72A0
	private static bool matchesLastLetter(string boneName, string[] namingConvention) { }

	// RVA: 0x26B73C0 Offset: 0x26B74C1 VA: 0x26B73C0
	private static bool LastLetterIs(string boneName, string letter) { }

	// RVA: 0x26B7110 Offset: 0x26B7211 VA: 0x26B7110
	private static string firstLetter(string boneName) { }

	// RVA: 0x26B7090 Offset: 0x26B7191 VA: 0x26B7090
	private static string lastLetter(string boneName) { }

	// RVA: 0x26B7400 Offset: 0x26B7501 VA: 0x26B7400
	private static void .cctor() { }
}

