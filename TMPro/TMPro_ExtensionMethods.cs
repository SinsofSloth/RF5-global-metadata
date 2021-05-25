[ExtensionAttribute] // RVA: 0x13EEA0 Offset: 0x13EFA1 VA: 0x13EEA0
public static class TMPro_ExtensionMethods // TypeDefIndex: 5886
{
	// Methods

	[ExtensionAttribute] // RVA: 0x140710 Offset: 0x140811 VA: 0x140710
	// RVA: 0x15A4140 Offset: 0x15A4241 VA: 0x15A4140
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x140720 Offset: 0x140821 VA: 0x140720
	// RVA: 0x15A4210 Offset: 0x15A4311 VA: 0x15A4210
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x140730 Offset: 0x140831 VA: 0x140730
	// RVA: 0x15A42D0 Offset: 0x15A43D1 VA: 0x15A42D0
	internal static string UintToString(List<uint> unicodes) { }

	[ExtensionAttribute] // RVA: 0x140740 Offset: 0x140841 VA: 0x140740
	// RVA: 0x15A43B0 Offset: 0x15A44B1 VA: 0x15A43B0
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x140750 Offset: 0x140851 VA: 0x140750
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255DD40 Offset: 0x255DE41 VA: 0x255DD40
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x140760 Offset: 0x140861 VA: 0x140760
	// RVA: 0x15A4500 Offset: 0x15A4601 VA: 0x15A4500
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x140770 Offset: 0x140871 VA: 0x140770
	// RVA: 0x15A4540 Offset: 0x15A4641 VA: 0x15A4540
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x140780 Offset: 0x140881 VA: 0x140780
	// RVA: 0x15A4570 Offset: 0x15A4671 VA: 0x15A4570
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x140790 Offset: 0x140891 VA: 0x140790
	// RVA: 0x15A45A0 Offset: 0x15A46A1 VA: 0x15A45A0
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x1407A0 Offset: 0x1408A1 VA: 0x1407A0
	// RVA: 0x15A45D0 Offset: 0x15A46D1 VA: 0x15A45D0
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x1407B0 Offset: 0x1408B1 VA: 0x1407B0
	// RVA: 0x15A46A0 Offset: 0x15A47A1 VA: 0x15A46A0
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x1407C0 Offset: 0x1408C1 VA: 0x1407C0
	// RVA: 0x15A4770 Offset: 0x15A4871 VA: 0x15A4770
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x1407D0 Offset: 0x1408D1 VA: 0x1407D0
	// RVA: 0x15A48E0 Offset: 0x15A49E1 VA: 0x15A48E0
	public static Color MinAlpha(Color c1, Color c2) { }

	[ExtensionAttribute] // RVA: 0x1407E0 Offset: 0x1408E1 VA: 0x1407E0
	// RVA: 0x15A4920 Offset: 0x15A4A21 VA: 0x15A4920
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x1407F0 Offset: 0x1408F1 VA: 0x1407F0
	// RVA: 0x15A4980 Offset: 0x15A4A81 VA: 0x15A4980
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}

