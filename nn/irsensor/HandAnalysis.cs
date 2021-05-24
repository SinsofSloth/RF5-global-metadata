public static class HandAnalysis // TypeDefIndex: 11492
{
	// Fields
	public const int ProcessorStateCountMax = 5;
	public const int ShapePointCountMax = 512;
	public const int ShapeCountMax = 16;
	public const int ProtrusionCountMax = 8;
	public const int HandCountMax = 2;
	public const int ImageWidth = 40;
	public const int ImageHeight = 30;

	// Methods

	// RVA: 0x34E9B20 Offset: 0x34E9C21 VA: 0x34E9B20
	public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config) { }

	// RVA: 0x34E9B40 Offset: 0x34E9C41 VA: 0x34E9B40
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x34E9B60 Offset: 0x34E9C61 VA: 0x34E9B60
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BA0 Offset: 0x34E9CA1 VA: 0x34E9BA0
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BD0 Offset: 0x34E9CD1 VA: 0x34E9BD0
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C00 Offset: 0x34E9D01 VA: 0x34E9C00
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C10 Offset: 0x34E9D11 VA: 0x34E9C10
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C30 Offset: 0x34E9D31 VA: 0x34E9C30
	public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C60 Offset: 0x34E9D61 VA: 0x34E9C60
	public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9CA0 Offset: 0x34E9DA1 VA: 0x34E9CA0
	private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }
}

public static class HandAnalysis // TypeDefIndex: 11492
{
	// Fields
	public const int ProcessorStateCountMax = 5;
	public const int ShapePointCountMax = 512;
	public const int ShapeCountMax = 16;
	public const int ProtrusionCountMax = 8;
	public const int HandCountMax = 2;
	public const int ImageWidth = 40;
	public const int ImageHeight = 30;

	// Methods

	// RVA: 0x34E9B20 Offset: 0x34E9C21 VA: 0x34E9B20
	public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config) { }

	// RVA: 0x34E9B40 Offset: 0x34E9C41 VA: 0x34E9B40
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x34E9B60 Offset: 0x34E9C61 VA: 0x34E9B60
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BA0 Offset: 0x34E9CA1 VA: 0x34E9BA0
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BD0 Offset: 0x34E9CD1 VA: 0x34E9BD0
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C00 Offset: 0x34E9D01 VA: 0x34E9C00
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C10 Offset: 0x34E9D11 VA: 0x34E9C10
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C30 Offset: 0x34E9D31 VA: 0x34E9C30
	public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C60 Offset: 0x34E9D61 VA: 0x34E9C60
	public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9CA0 Offset: 0x34E9DA1 VA: 0x34E9CA0
	private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }
}

public static class HandAnalysis // TypeDefIndex: 11492
{
	// Fields
	public const int ProcessorStateCountMax = 5;
	public const int ShapePointCountMax = 512;
	public const int ShapeCountMax = 16;
	public const int ProtrusionCountMax = 8;
	public const int HandCountMax = 2;
	public const int ImageWidth = 40;
	public const int ImageHeight = 30;

	// Methods

	// RVA: 0x34E9B20 Offset: 0x34E9C21 VA: 0x34E9B20
	public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config) { }

	// RVA: 0x34E9B40 Offset: 0x34E9C41 VA: 0x34E9B40
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x34E9B60 Offset: 0x34E9C61 VA: 0x34E9B60
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BA0 Offset: 0x34E9CA1 VA: 0x34E9BA0
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BD0 Offset: 0x34E9CD1 VA: 0x34E9BD0
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C00 Offset: 0x34E9D01 VA: 0x34E9C00
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C10 Offset: 0x34E9D11 VA: 0x34E9C10
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C30 Offset: 0x34E9D31 VA: 0x34E9C30
	public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C60 Offset: 0x34E9D61 VA: 0x34E9C60
	public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9CA0 Offset: 0x34E9DA1 VA: 0x34E9CA0
	private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }
}

public static class HandAnalysis // TypeDefIndex: 11492
{
	// Fields
	public const int ProcessorStateCountMax = 5;
	public const int ShapePointCountMax = 512;
	public const int ShapeCountMax = 16;
	public const int ProtrusionCountMax = 8;
	public const int HandCountMax = 2;
	public const int ImageWidth = 40;
	public const int ImageHeight = 30;

	// Methods

	// RVA: 0x34E9B20 Offset: 0x34E9C21 VA: 0x34E9B20
	public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config) { }

	// RVA: 0x34E9B40 Offset: 0x34E9C41 VA: 0x34E9B40
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x34E9B60 Offset: 0x34E9C61 VA: 0x34E9B60
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BA0 Offset: 0x34E9CA1 VA: 0x34E9BA0
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BD0 Offset: 0x34E9CD1 VA: 0x34E9BD0
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C00 Offset: 0x34E9D01 VA: 0x34E9C00
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C10 Offset: 0x34E9D11 VA: 0x34E9C10
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C30 Offset: 0x34E9D31 VA: 0x34E9C30
	public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C60 Offset: 0x34E9D61 VA: 0x34E9C60
	public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9CA0 Offset: 0x34E9DA1 VA: 0x34E9CA0
	private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }
}

public static class HandAnalysis // TypeDefIndex: 11492
{
	// Fields
	public const int ProcessorStateCountMax = 5;
	public const int ShapePointCountMax = 512;
	public const int ShapeCountMax = 16;
	public const int ProtrusionCountMax = 8;
	public const int HandCountMax = 2;
	public const int ImageWidth = 40;
	public const int ImageHeight = 30;

	// Methods

	// RVA: 0x34E9B20 Offset: 0x34E9C21 VA: 0x34E9B20
	public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config) { }

	// RVA: 0x34E9B40 Offset: 0x34E9C41 VA: 0x34E9B40
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle) { }

	// RVA: 0x34E9B60 Offset: 0x34E9C61 VA: 0x34E9B60
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BA0 Offset: 0x34E9CA1 VA: 0x34E9BA0
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9BD0 Offset: 0x34E9CD1 VA: 0x34E9BD0
	public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C00 Offset: 0x34E9D01 VA: 0x34E9C00
	public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C10 Offset: 0x34E9D11 VA: 0x34E9C10
	private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9C30 Offset: 0x34E9D31 VA: 0x34E9C30
	public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle) { }

	// RVA: 0x34E9C60 Offset: 0x34E9D61 VA: 0x34E9C60
	public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) { }

	// RVA: 0x34E9CA0 Offset: 0x34E9DA1 VA: 0x34E9CA0
	private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle) { }
}

