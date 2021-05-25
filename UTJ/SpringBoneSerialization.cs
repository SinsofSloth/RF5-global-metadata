public static class SpringBoneSerialization // TypeDefIndex: 9128
{
	// Methods

	// RVA: 0x2003E30 Offset: 0x2003F31 VA: 0x2003E30
	public static string BuildDynamicsSetupString(GameObject rootObject, SpringBoneSerialization.ExportSettings exportSettings) { }

	// RVA: 0x20040A0 Offset: 0x20041A1 VA: 0x20040A0
	private static SpringBoneSerialization.AngleLimitSerializer AngleLimitsToSerializer(AngleLimits sourceLimits) { }

	// RVA: 0x2004140 Offset: 0x2004241 VA: 0x2004140
	private static SpringBoneSerialization.SpringBoneBaseSerializer SpringBoneToBaseSerializer(SpringBone sourceBone) { }

	// RVA: 0x2004510 Offset: 0x2004611 VA: 0x2004510
	private static SpringBoneSerialization.PivotSerializer PivotToSerializer(Transform sourcePivot) { }

	// RVA: 0x2004640 Offset: 0x2004741 VA: 0x2004640
	private static void AppendSpringBones(CSVBuilder builder, IEnumerable<SpringBone> springBones) { }

	// RVA: 0x2005720 Offset: 0x2005821 VA: 0x2005720
	private static void AppendPivots(CSVBuilder builder, IEnumerable<SpringBone> springBones) { }

	// RVA: 0x2003F80 Offset: 0x2004081 VA: 0x2003F80
	private static string BuildSpringBoneSetupString(GameObject rootObject) { }

	// RVA: 0x2005F20 Offset: 0x2006021 VA: 0x2005F20
	private static IEnumerable<SpringBoneSerialization.PivotSerializer> SerializePivotRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x20063C0 Offset: 0x20064C1 VA: 0x20063C0
	private static IEnumerable<SpringBoneSerialization.SpringBoneSerializer> SerializeSpringBoneRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x2006A10 Offset: 0x2006B11 VA: 0x2006A10
	private static bool VerifyPivotRecords(IEnumerable<SpringBoneSerialization.PivotSerializer> sourceRecords, IEnumerable<string> validParentNames, List<SpringBoneSerialization.PivotSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x2007010 Offset: 0x2007111 VA: 0x2007010
	private static bool VerifySpringBoneRecords(IEnumerable<SpringBoneSerialization.SpringBoneSerializer> sourceRecords, IEnumerable<string> validBoneNames, IEnumerable<string> validPivotNames, IEnumerable<string> validColliderNames, List<SpringBoneSerialization.SpringBoneSerializer> validRecords, out bool hasMissingColliders, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x2007860 Offset: 0x2007961 VA: 0x2007860
	private static AngleLimits BuildAngleLimitsFromSerializer(SpringBoneSerialization.AngleLimitSerializer serializer) { }

	// RVA: 0x20078F0 Offset: 0x20079F1 VA: 0x20078F0
	private static Transform FindChildByName(Transform parent, string name) { }

	// RVA: 0x20079F0 Offset: 0x2007AF1 VA: 0x20079F0
	private static bool BuildPivotFromSerializer(Dictionary<string, Transform> transforms, SpringBoneSerialization.PivotSerializer serializer) { }

	// RVA: 0x2007C10 Offset: 0x2007D11 VA: 0x2007C10
	private static bool BuildSpringBoneFromSerializer(SpringBoneSerialization.SpringBoneSetupMaps setupMaps, SpringBoneSerialization.SpringBoneSerializer serializer) { }
}

