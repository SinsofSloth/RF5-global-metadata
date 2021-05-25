public class AdvBustupResManager : SingletonMonoBehaviour<AdvBustupResManager> // TypeDefIndex: 8401
{
	// Fields
	public static float[] BustupScaleTable; // 0x0
	private Dictionary<int, int> LoaderDictionary; // 0x18
	private BustupDataList BustupDataList; // 0x20

	// Methods

	// RVA: 0x1BF5850 Offset: 0x1BF5951 VA: 0x1BF5850
	private BUSTUPID CheckChangeBUSTUPID(BUSTUPID npcid, int poseId, int costumeId) { }

	// RVA: 0x1BF5C90 Offset: 0x1BF5D91 VA: 0x1BF5C90
	private void CheckInit() { }

	// RVA: 0x1BF5DE0 Offset: 0x1BF5EE1 VA: 0x1BF5DE0
	private int ChildColor(int ChildNo) { }

	// RVA: 0x1BF5E80 Offset: 0x1BF5F81 VA: 0x1BF5E80
	public int GetLoaderID(BUSTUPID npcid, int poseId, int costumeId, AdvCharaImageControl advCharaImageControl) { }

	// RVA: 0x1BF6220 Offset: 0x1BF6321 VA: 0x1BF6220
	public BustupDataList.MouthTable GetDefaultMouthID(BUSTUPID bustupId, int poseId, int costumeId) { }

	// RVA: 0x1BF6420 Offset: 0x1BF6521 VA: 0x1BF6420
	public static void SetLoader(int loaderId, AdvCharaImageControl advCharaImageControl) { }

	// RVA: 0x1BF65E0 Offset: 0x1BF66E1 VA: 0x1BF65E0
	public static void RemoveLoader(int loaderId, GameObject go) { }

	// RVA: 0x1BF6720 Offset: 0x1BF6821 VA: 0x1BF6720
	public static string GetShortName(BUSTUPID npcid, int val1, int val2, int poseId, int costumeId) { }

	// RVA: 0x1BF5A90 Offset: 0x1BF5B91 VA: 0x1BF5A90
	private static bool IsLucusWearingGlasses() { }

	// RVA: 0x1BF6CB0 Offset: 0x1BF6DB1 VA: 0x1BF6CB0
	public void .ctor() { }

	// RVA: 0x1BF6D00 Offset: 0x1BF6E01 VA: 0x1BF6D00
	private static void .cctor() { }
}

