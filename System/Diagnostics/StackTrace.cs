[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

[MonoTODOAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[ComVisibleAttribute] // RVA: 0xB40B0 Offset: 0xB41B1 VA: 0xB40B0
[Serializable]
public class StackTrace // TypeDefIndex: 1476
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x19B5300 Offset: 0x19B5401 VA: 0x19B5300
	public void .ctor() { }

	// RVA: 0x19B54E0 Offset: 0x19B55E1 VA: 0x19B54E0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x19B5520 Offset: 0x19B5621 VA: 0x19B5520
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5330 Offset: 0x19B5431 VA: 0x19B5330
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5560 Offset: 0x19B5661 VA: 0x19B5560
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5570 Offset: 0x19B5671 VA: 0x19B5570
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x19B5580 Offset: 0x19B5681 VA: 0x19B5580
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x19B5690 Offset: 0x19B5791 VA: 0x19B5690 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x19B56B0 Offset: 0x19B57B1 VA: 0x19B56B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x19B5740 Offset: 0x19B5841 VA: 0x19B5740
	private static string GetAotId() { }

	// RVA: 0x19B5830 Offset: 0x19B5931 VA: 0x19B5830
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x19B5CA0 Offset: 0x19B5DA1 VA: 0x19B5CA0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x19B60B0 Offset: 0x19B61B1 VA: 0x19B60B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B6220 Offset: 0x19B6321 VA: 0x19B6220
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

