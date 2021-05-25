[TypeForwardedFromAttribute] // RVA: 0xAC910 Offset: 0xACA11 VA: 0xAC910
[Serializable]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 323
{
	// Fields
	private TimeSpan baseUtcOffset; // 0x10
	private string daylightDisplayName; // 0x18
	private string displayName; // 0x20
	private string id; // 0x28
	private static TimeZoneInfo local; // 0x0
	private List<KeyValuePair<DateTime, TimeType>> transitions; // 0x30
	private static bool readlinkNotFound; // 0x8
	private string standardDisplayName; // 0x38
	private bool supportsDaylightSavingTime; // 0x40
	private static TimeZoneInfo utc; // 0x10
	private static string timeZoneDirectory; // 0x18
	private TimeZoneInfo.AdjustmentRule[] adjustmentRules; // 0x48
	private static RegistryKey timeZoneKey; // 0x20
	private static RegistryKey localZoneKey; // 0x28
	private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; // 0x30

	// Properties
	public TimeSpan BaseUtcOffset { get; }
	public string DisplayName { get; }
	public string Id { get; }
	public static TimeZoneInfo Local { get; }
	public bool SupportsDaylightSavingTime { get; }
	public static TimeZoneInfo Utc { get; }
	private static string TimeZoneDirectory { get; }
	private static bool IsWindows { get; }
	private static RegistryKey TimeZoneKey { get; }
	private static RegistryKey LocalZoneKey { get; }

	// Methods

	// RVA: 0x1592120 Offset: 0x1592221 VA: 0x1592120
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x1592150 Offset: 0x1592251 VA: 0x1592150
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	// RVA: 0x1592830 Offset: 0x1592931 VA: 0x1592830
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x1592DC0 Offset: 0x1592EC1 VA: 0x1592DC0
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x1592EE0 Offset: 0x1592FE1 VA: 0x1592EE0
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1592FF0 Offset: 0x15930F1 VA: 0x1592FF0
	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1593100 Offset: 0x1593201 VA: 0x1593100
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x1593230 Offset: 0x1593331 VA: 0x1593230
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x15933F0 Offset: 0x15934F1 VA: 0x15933F0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x15936B0 Offset: 0x15937B1 VA: 0x15936B0
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x1593850 Offset: 0x1593951 VA: 0x1593850
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x15944C0 Offset: 0x15945C1 VA: 0x15944C0
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x15947E0 Offset: 0x15948E1 VA: 0x15947E0
	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	// RVA: 0x15949F0 Offset: 0x1594AF1 VA: 0x15949F0
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x1594DB0 Offset: 0x1594EB1 VA: 0x1594DB0
	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	// RVA: 0x15951E0 Offset: 0x15952E1 VA: 0x15951E0
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x15951F0 Offset: 0x15952F1 VA: 0x15951F0
	public string get_DisplayName() { }

	// RVA: 0x1595200 Offset: 0x1595301 VA: 0x1595200
	public string get_Id() { }

	// RVA: 0x1595210 Offset: 0x1595311 VA: 0x1595210
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x15958D0 Offset: 0x15959D1 VA: 0x15958D0
	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	// RVA: 0x1595990 Offset: 0x1595A91 VA: 0x1595990
	private static string readlink(string path) { }

	// RVA: 0x1595BC0 Offset: 0x1595CC1 VA: 0x1595BC0
	private static bool TryGetNameFromPath(string path, out string name) { }

	// RVA: 0x15952D0 Offset: 0x15953D1 VA: 0x15952D0
	private static TimeZoneInfo CreateLocal() { }

	// RVA: 0x15965C0 Offset: 0x15966C1 VA: 0x15965C0
	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	// RVA: 0x15966A0 Offset: 0x15967A1 VA: 0x15966A0
	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	// RVA: 0x1597530 Offset: 0x1597631 VA: 0x1597530
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x15946F0 Offset: 0x15947F1 VA: 0x15946F0
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x1595EE0 Offset: 0x1595FE1 VA: 0x1595EE0
	private static string get_TimeZoneDirectory() { }

	// RVA: 0x1595F70 Offset: 0x1596071 VA: 0x1595F70
	private static bool get_IsWindows() { }

	// RVA: 0x1596160 Offset: 0x1596261 VA: 0x1596160
	private static string TrimSpecial(string str) { }

	// RVA: 0x1597390 Offset: 0x1597491 VA: 0x1597390
	private static RegistryKey get_TimeZoneKey() { }

	// RVA: 0x1595FC0 Offset: 0x15960C1 VA: 0x1595FC0
	private static RegistryKey get_LocalZoneKey() { }

	// RVA: 0x15975E0 Offset: 0x15976E1 VA: 0x15975E0
	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	// RVA: 0x1597760 Offset: 0x1597861 VA: 0x1597760
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1597BA0 Offset: 0x1597CA1 VA: 0x1597BA0
	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	// RVA: 0x1597B00 Offset: 0x1597C01 VA: 0x1597B00
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1597D40 Offset: 0x1597E41 VA: 0x1597D40
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1597AF0 Offset: 0x1597BF1 VA: 0x1597AF0
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x1597D70 Offset: 0x1597E71 VA: 0x1597D70
	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x1597FE0 Offset: 0x15980E1 VA: 0x1597FE0
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1597540 Offset: 0x1597641 VA: 0x1597540
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x15980C0 Offset: 0x15981C1 VA: 0x15980C0
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x1592D10 Offset: 0x1592E11 VA: 0x1592D10
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1598170 Offset: 0x1598271 VA: 0x1598170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1598210 Offset: 0x1598311 VA: 0x1598210 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x15962D0 Offset: 0x15963D1 VA: 0x15962D0
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x1596440 Offset: 0x1596541 VA: 0x1596440
	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	// RVA: 0x1598460 Offset: 0x1598561 VA: 0x1598460
	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	// RVA: 0x15989E0 Offset: 0x1598AE1 VA: 0x15989E0
	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	// RVA: 0x1598F10 Offset: 0x1599011 VA: 0x1598F10
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x1598FC0 Offset: 0x15990C1 VA: 0x1598FC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15990F0 Offset: 0x15991F1 VA: 0x15990F0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1594CC0 Offset: 0x1594DC1 VA: 0x1594CC0
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x1597D10 Offset: 0x1597E11 VA: 0x1597D10
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1597F10 Offset: 0x1598011 VA: 0x1597F10
	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	// RVA: 0x1599260 Offset: 0x1599361 VA: 0x1599260
	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	// RVA: 0x1598260 Offset: 0x1598361 VA: 0x1598260
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1599B30 Offset: 0x1599C31 VA: 0x1599B30
	public bool IsAmbiguousTime(DateTime dateTime) { }

	// RVA: 0x1599A90 Offset: 0x1599B91 VA: 0x1599A90
	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	// RVA: 0x1599EF0 Offset: 0x1599FF1 VA: 0x1599EF0
	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	// RVA: 0x15979A0 Offset: 0x1597AA1 VA: 0x15979A0
	public bool IsInvalidTime(DateTime dateTime) { }

	// RVA: 0x159A190 Offset: 0x159A291 VA: 0x159A190 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x159A290 Offset: 0x159A391 VA: 0x159A290
	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x159A900 Offset: 0x159AA01 VA: 0x159A900 Slot: 3
	public override string ToString() { }

	// RVA: 0x159A910 Offset: 0x159AA11 VA: 0x159A910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1593D80 Offset: 0x1593E81 VA: 0x1593D80
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x15998D0 Offset: 0x15999D1 VA: 0x15998D0
	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	// RVA: 0x1599640 Offset: 0x1599741 VA: 0x1599640
	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	// RVA: 0x1599D20 Offset: 0x1599E21 VA: 0x1599D20
	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	// RVA: 0x1598DC0 Offset: 0x1598EC1 VA: 0x1598DC0
	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	// RVA: 0x1598820 Offset: 0x1598921 VA: 0x1598820
	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	// RVA: 0x159AC60 Offset: 0x159AD61 VA: 0x159AC60
	private static bool ValidTZFile(byte[] buffer, int length) { }

	// RVA: 0x159BAC0 Offset: 0x159BBC1 VA: 0x159BAC0
	private static int SwapInt32(int i) { }

	// RVA: 0x159BAD0 Offset: 0x159BBD1 VA: 0x159BAD0
	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	// RVA: 0x159ADA0 Offset: 0x159AEA1 VA: 0x159ADA0
	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	// RVA: 0x159BB70 Offset: 0x159BC71 VA: 0x159BB70
	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	// RVA: 0x159BDA0 Offset: 0x159BEA1 VA: 0x159BDA0
	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	// RVA: 0x159C010 Offset: 0x159C111 VA: 0x159C010
	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	// RVA: 0x159C290 Offset: 0x159C391 VA: 0x159C290
	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	// RVA: 0x159C2E0 Offset: 0x159C3E1 VA: 0x159C2E0
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x159C320 Offset: 0x159C421 VA: 0x159C320
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1598050 Offset: 0x1598151 VA: 0x1598050
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x159C350 Offset: 0x159C451 VA: 0x159C350
	internal void .ctor() { }
}

