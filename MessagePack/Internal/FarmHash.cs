internal static class FarmHash // TypeDefIndex: 5292
{
	// Fields
	private const uint c1 = 3432918353;
	private const uint c2 = 461845907;
	private const ulong k0 = 14097894508562428199;
	private const ulong k1 = 13011662864482103923;
	private const ulong k2 = 11160318154034397263;

	// Methods

	// RVA: 0x167D3E0 Offset: 0x167D4E1 VA: 0x167D3E0
	public static uint Hash32(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167D590 Offset: 0x167D691 VA: 0x167D590
	private static uint Fetch32(byte* p) { }

	// RVA: 0x167D5A0 Offset: 0x167D6A1 VA: 0x167D5A0
	private static uint Rotate32(uint val, int shift) { }

	// RVA: 0x167D5B0 Offset: 0x167D6B1 VA: 0x167D5B0
	private static uint fmix(uint h) { }

	// RVA: 0x167D5E0 Offset: 0x167D6E1 VA: 0x167D5E0
	private static uint Mur(uint a, uint h) { }

	// RVA: 0x167D620 Offset: 0x167D721 VA: 0x167D620
	private static uint Hash32Len0to4(ReadOnlySpan<byte> s) { }

	// RVA: 0x167D740 Offset: 0x167D841 VA: 0x167D740
	private static uint Hash32Len5to12(byte* s, uint len) { }

	// RVA: 0x167D800 Offset: 0x167D901 VA: 0x167D800
	private static uint Hash32Len13to24(byte* s, uint len) { }

	// RVA: 0x167D8E0 Offset: 0x167D9E1 VA: 0x167D8E0
	private static uint Hash32(byte* s, uint len) { }

	// RVA: 0x167DBF0 Offset: 0x167DCF1 VA: 0x167DBF0
	public static ulong Hash64(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167DC50 Offset: 0x167DD51 VA: 0x167DC50
	private static void swap(ref ulong x, ref ulong z) { }

	// RVA: 0x167DC70 Offset: 0x167DD71 VA: 0x167DC70
	private static ulong Fetch64(byte* p) { }

	// RVA: 0x167DC80 Offset: 0x167DD81 VA: 0x167DC80
	private static ulong Rotate64(ulong val, int shift) { }

	// RVA: 0x167DC90 Offset: 0x167DD91 VA: 0x167DC90
	private static ulong ShiftMix(ulong val) { }

	// RVA: 0x167DCA0 Offset: 0x167DDA1 VA: 0x167DCA0
	private static ulong HashLen16(ulong u, ulong v, ulong mul) { }

	// RVA: 0x167DCC0 Offset: 0x167DDC1 VA: 0x167DCC0
	private static ulong Hash64(byte* s, uint len) { }

	// RVA: 0x167DF40 Offset: 0x167E041 VA: 0x167DF40
	private static ulong HashLen0to16(byte* s, uint len) { }

	// RVA: 0x167E040 Offset: 0x167E141 VA: 0x167E040
	private static ulong HashLen17to32(byte* s, uint len) { }

	// RVA: 0x167E0C0 Offset: 0x167E1C1 VA: 0x167E0C0
	private static ulong H32(byte* s, uint len, ulong mul, ulong seed0 = 0, ulong seed1 = 0) { }

	// RVA: 0x167E140 Offset: 0x167E241 VA: 0x167E140
	private static ulong HashLen33to64(byte* s, uint len) { }

	// RVA: 0x167E220 Offset: 0x167E321 VA: 0x167E220
	private static ulong HashLen65to96(byte* s, uint len) { }

	// RVA: 0x167E360 Offset: 0x167E461 VA: 0x167E360
	private static void WeakHashLen32WithSeeds(ulong w, ulong x, ulong y, ulong z, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3A0 Offset: 0x167E4A1 VA: 0x167E3A0
	private static void WeakHashLen32WithSeeds(byte* s, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3E0 Offset: 0x167E4E1 VA: 0x167E3E0
	private static ulong Hash64NA(byte* s, uint len) { }

	// RVA: 0x167E650 Offset: 0x167E751 VA: 0x167E650
	private static ulong H(ulong x, ulong y, ulong mul, int r) { }

	// RVA: 0x167E680 Offset: 0x167E781 VA: 0x167E680
	private static ulong Hash64UO(byte* s, uint len) { }
}

internal static class FarmHash // TypeDefIndex: 5292
{
	// Fields
	private const uint c1 = 3432918353;
	private const uint c2 = 461845907;
	private const ulong k0 = 14097894508562428199;
	private const ulong k1 = 13011662864482103923;
	private const ulong k2 = 11160318154034397263;

	// Methods

	// RVA: 0x167D3E0 Offset: 0x167D4E1 VA: 0x167D3E0
	public static uint Hash32(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167D590 Offset: 0x167D691 VA: 0x167D590
	private static uint Fetch32(byte* p) { }

	// RVA: 0x167D5A0 Offset: 0x167D6A1 VA: 0x167D5A0
	private static uint Rotate32(uint val, int shift) { }

	// RVA: 0x167D5B0 Offset: 0x167D6B1 VA: 0x167D5B0
	private static uint fmix(uint h) { }

	// RVA: 0x167D5E0 Offset: 0x167D6E1 VA: 0x167D5E0
	private static uint Mur(uint a, uint h) { }

	// RVA: 0x167D620 Offset: 0x167D721 VA: 0x167D620
	private static uint Hash32Len0to4(ReadOnlySpan<byte> s) { }

	// RVA: 0x167D740 Offset: 0x167D841 VA: 0x167D740
	private static uint Hash32Len5to12(byte* s, uint len) { }

	// RVA: 0x167D800 Offset: 0x167D901 VA: 0x167D800
	private static uint Hash32Len13to24(byte* s, uint len) { }

	// RVA: 0x167D8E0 Offset: 0x167D9E1 VA: 0x167D8E0
	private static uint Hash32(byte* s, uint len) { }

	// RVA: 0x167DBF0 Offset: 0x167DCF1 VA: 0x167DBF0
	public static ulong Hash64(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167DC50 Offset: 0x167DD51 VA: 0x167DC50
	private static void swap(ref ulong x, ref ulong z) { }

	// RVA: 0x167DC70 Offset: 0x167DD71 VA: 0x167DC70
	private static ulong Fetch64(byte* p) { }

	// RVA: 0x167DC80 Offset: 0x167DD81 VA: 0x167DC80
	private static ulong Rotate64(ulong val, int shift) { }

	// RVA: 0x167DC90 Offset: 0x167DD91 VA: 0x167DC90
	private static ulong ShiftMix(ulong val) { }

	// RVA: 0x167DCA0 Offset: 0x167DDA1 VA: 0x167DCA0
	private static ulong HashLen16(ulong u, ulong v, ulong mul) { }

	// RVA: 0x167DCC0 Offset: 0x167DDC1 VA: 0x167DCC0
	private static ulong Hash64(byte* s, uint len) { }

	// RVA: 0x167DF40 Offset: 0x167E041 VA: 0x167DF40
	private static ulong HashLen0to16(byte* s, uint len) { }

	// RVA: 0x167E040 Offset: 0x167E141 VA: 0x167E040
	private static ulong HashLen17to32(byte* s, uint len) { }

	// RVA: 0x167E0C0 Offset: 0x167E1C1 VA: 0x167E0C0
	private static ulong H32(byte* s, uint len, ulong mul, ulong seed0 = 0, ulong seed1 = 0) { }

	// RVA: 0x167E140 Offset: 0x167E241 VA: 0x167E140
	private static ulong HashLen33to64(byte* s, uint len) { }

	// RVA: 0x167E220 Offset: 0x167E321 VA: 0x167E220
	private static ulong HashLen65to96(byte* s, uint len) { }

	// RVA: 0x167E360 Offset: 0x167E461 VA: 0x167E360
	private static void WeakHashLen32WithSeeds(ulong w, ulong x, ulong y, ulong z, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3A0 Offset: 0x167E4A1 VA: 0x167E3A0
	private static void WeakHashLen32WithSeeds(byte* s, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3E0 Offset: 0x167E4E1 VA: 0x167E3E0
	private static ulong Hash64NA(byte* s, uint len) { }

	// RVA: 0x167E650 Offset: 0x167E751 VA: 0x167E650
	private static ulong H(ulong x, ulong y, ulong mul, int r) { }

	// RVA: 0x167E680 Offset: 0x167E781 VA: 0x167E680
	private static ulong Hash64UO(byte* s, uint len) { }
}

internal static class FarmHash // TypeDefIndex: 5292
{
	// Fields
	private const uint c1 = 3432918353;
	private const uint c2 = 461845907;
	private const ulong k0 = 14097894508562428199;
	private const ulong k1 = 13011662864482103923;
	private const ulong k2 = 11160318154034397263;

	// Methods

	// RVA: 0x167D3E0 Offset: 0x167D4E1 VA: 0x167D3E0
	public static uint Hash32(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167D590 Offset: 0x167D691 VA: 0x167D590
	private static uint Fetch32(byte* p) { }

	// RVA: 0x167D5A0 Offset: 0x167D6A1 VA: 0x167D5A0
	private static uint Rotate32(uint val, int shift) { }

	// RVA: 0x167D5B0 Offset: 0x167D6B1 VA: 0x167D5B0
	private static uint fmix(uint h) { }

	// RVA: 0x167D5E0 Offset: 0x167D6E1 VA: 0x167D5E0
	private static uint Mur(uint a, uint h) { }

	// RVA: 0x167D620 Offset: 0x167D721 VA: 0x167D620
	private static uint Hash32Len0to4(ReadOnlySpan<byte> s) { }

	// RVA: 0x167D740 Offset: 0x167D841 VA: 0x167D740
	private static uint Hash32Len5to12(byte* s, uint len) { }

	// RVA: 0x167D800 Offset: 0x167D901 VA: 0x167D800
	private static uint Hash32Len13to24(byte* s, uint len) { }

	// RVA: 0x167D8E0 Offset: 0x167D9E1 VA: 0x167D8E0
	private static uint Hash32(byte* s, uint len) { }

	// RVA: 0x167DBF0 Offset: 0x167DCF1 VA: 0x167DBF0
	public static ulong Hash64(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167DC50 Offset: 0x167DD51 VA: 0x167DC50
	private static void swap(ref ulong x, ref ulong z) { }

	// RVA: 0x167DC70 Offset: 0x167DD71 VA: 0x167DC70
	private static ulong Fetch64(byte* p) { }

	// RVA: 0x167DC80 Offset: 0x167DD81 VA: 0x167DC80
	private static ulong Rotate64(ulong val, int shift) { }

	// RVA: 0x167DC90 Offset: 0x167DD91 VA: 0x167DC90
	private static ulong ShiftMix(ulong val) { }

	// RVA: 0x167DCA0 Offset: 0x167DDA1 VA: 0x167DCA0
	private static ulong HashLen16(ulong u, ulong v, ulong mul) { }

	// RVA: 0x167DCC0 Offset: 0x167DDC1 VA: 0x167DCC0
	private static ulong Hash64(byte* s, uint len) { }

	// RVA: 0x167DF40 Offset: 0x167E041 VA: 0x167DF40
	private static ulong HashLen0to16(byte* s, uint len) { }

	// RVA: 0x167E040 Offset: 0x167E141 VA: 0x167E040
	private static ulong HashLen17to32(byte* s, uint len) { }

	// RVA: 0x167E0C0 Offset: 0x167E1C1 VA: 0x167E0C0
	private static ulong H32(byte* s, uint len, ulong mul, ulong seed0 = 0, ulong seed1 = 0) { }

	// RVA: 0x167E140 Offset: 0x167E241 VA: 0x167E140
	private static ulong HashLen33to64(byte* s, uint len) { }

	// RVA: 0x167E220 Offset: 0x167E321 VA: 0x167E220
	private static ulong HashLen65to96(byte* s, uint len) { }

	// RVA: 0x167E360 Offset: 0x167E461 VA: 0x167E360
	private static void WeakHashLen32WithSeeds(ulong w, ulong x, ulong y, ulong z, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3A0 Offset: 0x167E4A1 VA: 0x167E3A0
	private static void WeakHashLen32WithSeeds(byte* s, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3E0 Offset: 0x167E4E1 VA: 0x167E3E0
	private static ulong Hash64NA(byte* s, uint len) { }

	// RVA: 0x167E650 Offset: 0x167E751 VA: 0x167E650
	private static ulong H(ulong x, ulong y, ulong mul, int r) { }

	// RVA: 0x167E680 Offset: 0x167E781 VA: 0x167E680
	private static ulong Hash64UO(byte* s, uint len) { }
}

internal static class FarmHash // TypeDefIndex: 5292
{
	// Fields
	private const uint c1 = 3432918353;
	private const uint c2 = 461845907;
	private const ulong k0 = 14097894508562428199;
	private const ulong k1 = 13011662864482103923;
	private const ulong k2 = 11160318154034397263;

	// Methods

	// RVA: 0x167D3E0 Offset: 0x167D4E1 VA: 0x167D3E0
	public static uint Hash32(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167D590 Offset: 0x167D691 VA: 0x167D590
	private static uint Fetch32(byte* p) { }

	// RVA: 0x167D5A0 Offset: 0x167D6A1 VA: 0x167D5A0
	private static uint Rotate32(uint val, int shift) { }

	// RVA: 0x167D5B0 Offset: 0x167D6B1 VA: 0x167D5B0
	private static uint fmix(uint h) { }

	// RVA: 0x167D5E0 Offset: 0x167D6E1 VA: 0x167D5E0
	private static uint Mur(uint a, uint h) { }

	// RVA: 0x167D620 Offset: 0x167D721 VA: 0x167D620
	private static uint Hash32Len0to4(ReadOnlySpan<byte> s) { }

	// RVA: 0x167D740 Offset: 0x167D841 VA: 0x167D740
	private static uint Hash32Len5to12(byte* s, uint len) { }

	// RVA: 0x167D800 Offset: 0x167D901 VA: 0x167D800
	private static uint Hash32Len13to24(byte* s, uint len) { }

	// RVA: 0x167D8E0 Offset: 0x167D9E1 VA: 0x167D8E0
	private static uint Hash32(byte* s, uint len) { }

	// RVA: 0x167DBF0 Offset: 0x167DCF1 VA: 0x167DBF0
	public static ulong Hash64(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167DC50 Offset: 0x167DD51 VA: 0x167DC50
	private static void swap(ref ulong x, ref ulong z) { }

	// RVA: 0x167DC70 Offset: 0x167DD71 VA: 0x167DC70
	private static ulong Fetch64(byte* p) { }

	// RVA: 0x167DC80 Offset: 0x167DD81 VA: 0x167DC80
	private static ulong Rotate64(ulong val, int shift) { }

	// RVA: 0x167DC90 Offset: 0x167DD91 VA: 0x167DC90
	private static ulong ShiftMix(ulong val) { }

	// RVA: 0x167DCA0 Offset: 0x167DDA1 VA: 0x167DCA0
	private static ulong HashLen16(ulong u, ulong v, ulong mul) { }

	// RVA: 0x167DCC0 Offset: 0x167DDC1 VA: 0x167DCC0
	private static ulong Hash64(byte* s, uint len) { }

	// RVA: 0x167DF40 Offset: 0x167E041 VA: 0x167DF40
	private static ulong HashLen0to16(byte* s, uint len) { }

	// RVA: 0x167E040 Offset: 0x167E141 VA: 0x167E040
	private static ulong HashLen17to32(byte* s, uint len) { }

	// RVA: 0x167E0C0 Offset: 0x167E1C1 VA: 0x167E0C0
	private static ulong H32(byte* s, uint len, ulong mul, ulong seed0 = 0, ulong seed1 = 0) { }

	// RVA: 0x167E140 Offset: 0x167E241 VA: 0x167E140
	private static ulong HashLen33to64(byte* s, uint len) { }

	// RVA: 0x167E220 Offset: 0x167E321 VA: 0x167E220
	private static ulong HashLen65to96(byte* s, uint len) { }

	// RVA: 0x167E360 Offset: 0x167E461 VA: 0x167E360
	private static void WeakHashLen32WithSeeds(ulong w, ulong x, ulong y, ulong z, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3A0 Offset: 0x167E4A1 VA: 0x167E3A0
	private static void WeakHashLen32WithSeeds(byte* s, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3E0 Offset: 0x167E4E1 VA: 0x167E3E0
	private static ulong Hash64NA(byte* s, uint len) { }

	// RVA: 0x167E650 Offset: 0x167E751 VA: 0x167E650
	private static ulong H(ulong x, ulong y, ulong mul, int r) { }

	// RVA: 0x167E680 Offset: 0x167E781 VA: 0x167E680
	private static ulong Hash64UO(byte* s, uint len) { }
}

internal static class FarmHash // TypeDefIndex: 5292
{
	// Fields
	private const uint c1 = 3432918353;
	private const uint c2 = 461845907;
	private const ulong k0 = 14097894508562428199;
	private const ulong k1 = 13011662864482103923;
	private const ulong k2 = 11160318154034397263;

	// Methods

	// RVA: 0x167D3E0 Offset: 0x167D4E1 VA: 0x167D3E0
	public static uint Hash32(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167D590 Offset: 0x167D691 VA: 0x167D590
	private static uint Fetch32(byte* p) { }

	// RVA: 0x167D5A0 Offset: 0x167D6A1 VA: 0x167D5A0
	private static uint Rotate32(uint val, int shift) { }

	// RVA: 0x167D5B0 Offset: 0x167D6B1 VA: 0x167D5B0
	private static uint fmix(uint h) { }

	// RVA: 0x167D5E0 Offset: 0x167D6E1 VA: 0x167D5E0
	private static uint Mur(uint a, uint h) { }

	// RVA: 0x167D620 Offset: 0x167D721 VA: 0x167D620
	private static uint Hash32Len0to4(ReadOnlySpan<byte> s) { }

	// RVA: 0x167D740 Offset: 0x167D841 VA: 0x167D740
	private static uint Hash32Len5to12(byte* s, uint len) { }

	// RVA: 0x167D800 Offset: 0x167D901 VA: 0x167D800
	private static uint Hash32Len13to24(byte* s, uint len) { }

	// RVA: 0x167D8E0 Offset: 0x167D9E1 VA: 0x167D8E0
	private static uint Hash32(byte* s, uint len) { }

	// RVA: 0x167DBF0 Offset: 0x167DCF1 VA: 0x167DBF0
	public static ulong Hash64(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x167DC50 Offset: 0x167DD51 VA: 0x167DC50
	private static void swap(ref ulong x, ref ulong z) { }

	// RVA: 0x167DC70 Offset: 0x167DD71 VA: 0x167DC70
	private static ulong Fetch64(byte* p) { }

	// RVA: 0x167DC80 Offset: 0x167DD81 VA: 0x167DC80
	private static ulong Rotate64(ulong val, int shift) { }

	// RVA: 0x167DC90 Offset: 0x167DD91 VA: 0x167DC90
	private static ulong ShiftMix(ulong val) { }

	// RVA: 0x167DCA0 Offset: 0x167DDA1 VA: 0x167DCA0
	private static ulong HashLen16(ulong u, ulong v, ulong mul) { }

	// RVA: 0x167DCC0 Offset: 0x167DDC1 VA: 0x167DCC0
	private static ulong Hash64(byte* s, uint len) { }

	// RVA: 0x167DF40 Offset: 0x167E041 VA: 0x167DF40
	private static ulong HashLen0to16(byte* s, uint len) { }

	// RVA: 0x167E040 Offset: 0x167E141 VA: 0x167E040
	private static ulong HashLen17to32(byte* s, uint len) { }

	// RVA: 0x167E0C0 Offset: 0x167E1C1 VA: 0x167E0C0
	private static ulong H32(byte* s, uint len, ulong mul, ulong seed0 = 0, ulong seed1 = 0) { }

	// RVA: 0x167E140 Offset: 0x167E241 VA: 0x167E140
	private static ulong HashLen33to64(byte* s, uint len) { }

	// RVA: 0x167E220 Offset: 0x167E321 VA: 0x167E220
	private static ulong HashLen65to96(byte* s, uint len) { }

	// RVA: 0x167E360 Offset: 0x167E461 VA: 0x167E360
	private static void WeakHashLen32WithSeeds(ulong w, ulong x, ulong y, ulong z, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3A0 Offset: 0x167E4A1 VA: 0x167E3A0
	private static void WeakHashLen32WithSeeds(byte* s, ulong a, ulong b, out ulong first, out ulong second) { }

	// RVA: 0x167E3E0 Offset: 0x167E4E1 VA: 0x167E3E0
	private static ulong Hash64NA(byte* s, uint len) { }

	// RVA: 0x167E650 Offset: 0x167E751 VA: 0x167E650
	private static ulong H(ulong x, ulong y, ulong mul, int r) { }

	// RVA: 0x167E680 Offset: 0x167E781 VA: 0x167E680
	private static ulong Hash64UO(byte* s, uint len) { }
}

