using System.Runtime.InteropServices;

namespace YogaSharp;

public static unsafe partial class Interop
{
    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeCopyStyle(YGNode* dstNode, YGNode* srcNode);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetDirection(YGNode* node, YGDirection value);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGDirection YGNodeStyleGetDirection(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexDirection(YGNode* node, YGFlexDirection flexDirection);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGFlexDirection YGNodeStyleGetFlexDirection(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetJustifyContent(YGNode* node, YGJustify justifyContent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGJustify YGNodeStyleGetJustifyContent(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetAlignContent(YGNode* node, YGAlign alignContent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGAlign YGNodeStyleGetAlignContent(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetAlignItems(YGNode* node, YGAlign alignItems);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGAlign YGNodeStyleGetAlignItems(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetAlignSelf(YGNode* node, YGAlign alignSelf);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGAlign YGNodeStyleGetAlignSelf(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetPositionType(YGNode* node, YGPositionType positionType);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGPositionType YGNodeStyleGetPositionType(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexWrap(YGNode* node, YGWrap flexWrap);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGWrap YGNodeStyleGetFlexWrap(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetOverflow(YGNode* node, YGOverflow overflow);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGOverflow YGNodeStyleGetOverflow(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetDisplay(YGNode* node, YGDisplay display);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGDisplay YGNodeStyleGetDisplay(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlex(YGNode* node, float flex);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern float YGNodeStyleGetFlex(YGNode* nodeRef);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexGrow(YGNode* node, float flexGrow);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern float YGNodeStyleGetFlexGrow(YGNode* nodeRef);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexShrink(YGNode* node, float flexShrink);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern float YGNodeStyleGetFlexShrink(YGNode* nodeRef);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexBasis(YGNode* node, float flexBasis);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexBasisPercent(YGNode* node, float flexBasisPercent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetFlexBasisAuto(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetFlexBasis(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetPosition(YGNode* node, YGEdge edge, float points);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetPositionPercent(YGNode* node, YGEdge edge, float percent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetPositionAuto(YGNode* node, YGEdge edge);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetPosition(YGNode* node, YGEdge edge);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMargin(YGNode* node, YGEdge edge, float points);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMarginPercent(YGNode* node, YGEdge edge, float percent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMarginAuto(YGNode* node, YGEdge edge);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetMargin(YGNode* node, YGEdge edge);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetPadding(YGNode* node, YGEdge edge, float points);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetPaddingPercent(YGNode* node, YGEdge edge, float percent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetPadding(YGNode* node, YGEdge edge);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetBorder(YGNode* node, YGEdge edge, float border);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern float YGNodeStyleGetBorder(YGNode* node, YGEdge edge);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetGap(YGNode* node, YGGutter gutter, float gapLength);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetGapPercent(YGNode* node, YGGutter gutter, float gapLength);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern float YGNodeStyleGetGap(YGNode* node, YGGutter gutter);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetBoxSizing(YGNode* node, YGBoxSizing boxSizing);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGBoxSizing YGNodeStyleGetBoxSizing(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetAspectRatio(YGNode* node, float aspectRatio);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern float YGNodeStyleGetAspectRatio(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetWidth(YGNode* node, float points);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetWidthPercent(YGNode* node, float percent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetWidthAuto(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetWidth(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetHeight(YGNode* node, float points);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetHeightPercent(YGNode* node, float percent);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetHeightAuto(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetHeight(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMinWidth(YGNode* node, float minWidth);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMinWidthPercent(YGNode* node, float minWidth);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetMinWidth(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMinHeight(YGNode* node, float minHeight);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMinHeightPercent(YGNode* node, float minHeight);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetMinHeight(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMaxWidth(YGNode* node, float maxWidth);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMaxWidthPercent(YGNode* node, float maxWidth);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetMaxWidth(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMaxHeight(YGNode* node, float maxHeight);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMaxHeightPercent(YGNode* node, float maxHeight);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern void YGNodeStyleSetMaxHeightPercent(YGNode* node);

    [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
    public static extern YGValue YGNodeStyleGetMaxHeight(YGNode* node);
}
