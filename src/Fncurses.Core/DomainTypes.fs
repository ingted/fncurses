namespace Fncurses.Core

[<AutoOpen>]
module DomainTypes =

    open System
    open System.Runtime.InteropServices

    // ----------------------------------------------------------------------
    // C Data Types
        
    type ChType = System.UInt32
    type ChTypeBuf = ChType array
    type Args = obj array
    type Attr_t = ChType
    type CBool = bool
    type CChar = sbyte
    type CCharBuf = byte array
    type CCharPtr = string
    type CChar_t = ChType
    type CFilePtr = IntPtr
    type CInt = int16
    type CShort = int16
    type CShortPtr = IntPtr
    type CVoid = unit
    type CVoidPtr = IntPtr
    type ChTypePtr = string
    type ScrPtr = IntPtr
    type WinPtr = IntPtr

    // ----------------------------------------------------------------------
    // Delegates

    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type Attr_t_CShort_CVoidPtr_CInt = delegate of Attr_t * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type Attr_t_CVoidPtr_CInt = delegate of Attr_t * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type Attr_tRef_CShortRef_CVoidRef_CInt = delegate of Attr_t byref * CShort byref * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CBool_CVoid = delegate of CBool -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharPtr_Args_CInt = delegate of CCharPtr * Args -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharPtr_CInt = delegate of CCharPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharPtr_CInt_CInt = delegate of CCharPtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharBuf_CInt = delegate of CCharBuf -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharBuf_CInt_CInt = delegate of CCharBuf * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharPtr_CVoid = delegate of CCharPtr -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CCharPtr_CFilePtr_CFilePtr_ScrPtr = delegate of CCharPtr * CFilePtr * CFilePtr -> ScrPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CFilePtr_WinPtr = delegate of CFilePtr -> WinPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChType_ChType_ChType_ChType_ChType_ChType_ChType_ChType_CInt = delegate of ChType * ChType * ChType * ChType * ChType * ChType * ChType * ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChType_CInt = delegate of ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChType_CInt_CInt = delegate of ChType * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChType_CVoid = delegate of ChType -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChTypeBuf_CInt = delegate of ChTypeBuf -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChTypeBuf_CInt_CInt = delegate of ChTypeBuf * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChTypePtr_CInt = delegate of ChTypePtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ChTypePtr_CInt_CInt = delegate of ChTypePtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_Attr_t_CShort_CVoidPtr_CInt = delegate of CInt * Attr_t * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CChar = delegate of CInt -> CChar
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CCharPtr = delegate of CInt -> CCharPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CCharPtr_CInt_CInt = delegate of CInt * CCharPtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt = delegate of CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CCharBuf_CInt = delegate of CInt * CInt * CCharBuf -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CCharBuf_CInt_CInt = delegate of CInt * CInt * CCharBuf * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CCharPtr_Args_CInt = delegate of CInt * CInt * CCharPtr * Args -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CCharPtr_CInt = delegate of CInt * CInt * CCharPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CCharPtr_CInt_CInt = delegate of CInt * CInt * CCharPtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_ChType = delegate of CInt * CInt -> ChType
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_ChType_CInt = delegate of CInt * CInt * ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_ChType_CInt_CInt = delegate of CInt * CInt * ChType * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_ChTypePtr_CInt = delegate of CInt * CInt * ChTypePtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_ChTypePtr_CInt_CInt = delegate of CInt * CInt * ChTypePtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CInt = delegate of CInt * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CInt_Attr_t_CShort_CVoidPtr_CInt = delegate of CInt * CInt * CInt * Attr_t * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CInt_CInt_CInt = delegate of CInt * CInt * CInt * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CInt_CInt_WinPtr = delegate of CInt * CInt * CInt * CInt -> WinPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_CVoid = delegate of CInt * CInt -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CInt_WinPtr = delegate of CInt * CInt -> WinPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CInt_CVoid = delegate of CInt -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CIntRef_CIntRef_CVoid = delegate of CInt byref * CInt byref -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CShort_CInt = delegate of CShort -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CShort_CShort_CShort_CInt = delegate of CShort * CShort * CShort -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CShort_CShort_CShort_CShort_CInt = delegate of CShort * CShort * CShort * CShort -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CShort_CShortRef_CShortRef_CInt = delegate of CShort * CShort byref * CShort byref -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CShort_CShortRef_CShortRef_CShortRef_CInt = delegate of CShort * CShort byref * CShort byref * CShort byref -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CShort_CVoidPtr_CInt = delegate of CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_Attr_t = delegate of CVoid -> Attr_t
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_CBool = delegate of CVoid -> CBool
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_CChar = delegate of CVoid -> CChar
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_CCharPtr = delegate of CVoid -> CCharPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_ChType = delegate of CVoid -> ChType
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_CInt = delegate of CVoid -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_CVoid = delegate of CVoid -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type CVoid_WinPtr = delegate of CVoid -> WinPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ScrPtr_CVoid = delegate of ScrPtr -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type ScrPtr_ScrPtr = delegate of ScrPtr -> ScrPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChType_CInt = delegate of WinPtr * ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_Attr_t_CShort_CVoidPtr_CInt = delegate of WinPtr * Attr_t * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_Attr_t_CVoidPtr_CInt = delegate of WinPtr * Attr_t * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_Attr_tRef_CShortRef_CVoidPtr_CInt = delegate of WinPtr * Attr_t byref * CShort byref * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CBool = delegate of WinPtr -> CBool
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CBool_CInt = delegate of WinPtr * CBool -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CCharBuf_CInt = delegate of WinPtr * byte array -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CCharBuf_CInt_CInt = delegate of WinPtr * byte array * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CCharPtr_Args_CInt = delegate of WinPtr * CCharPtr * Args -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CCharPtr_CInt = delegate of WinPtr * CCharPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CCharPtr_CInt_CInt = delegate of WinPtr * CCharPtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChType = delegate of WinPtr -> ChType
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChType_ChType_ChType_ChType_ChType_ChType_ChType_ChType_CInt = delegate of WinPtr * ChType * ChType * ChType * ChType * ChType * ChType * ChType * ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChType_ChType_CInt = delegate of WinPtr * ChType * ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChType_CInt_CInt = delegate of WinPtr * ChType * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChType_CVoid = delegate of WinPtr * ChType -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChTypePtr_CInt = delegate of WinPtr * ChTypePtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_ChTypePtr_CInt_CInt = delegate of WinPtr * ChTypePtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt = delegate of WinPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_Attr_t_CShort_CVoidPtr_CInt = delegate of WinPtr * CInt * Attr_t * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CBool = delegate of WinPtr * CInt -> CBool
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt = delegate of WinPtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CCharPtr_Args_CInt = delegate of WinPtr * CInt * CInt * CCharPtr * Args -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CCharBuf_CInt = delegate of WinPtr * CInt * CInt * CCharBuf -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CCharBuf_CInt_CInt = delegate of WinPtr * CInt * CInt * CCharBuf * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CCharPtr_CInt = delegate of WinPtr * CInt * CInt * CCharPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CCharPtr_CInt_CInt = delegate of WinPtr * CInt * CInt * CCharPtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_ChType = delegate of WinPtr * CInt * CInt -> ChType
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_ChType_CInt = delegate of WinPtr * CInt * CInt * ChType -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_ChType_CInt_CInt = delegate of WinPtr * CInt * CInt * ChType * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_ChTypePtr_CInt = delegate of WinPtr * CInt * CInt * ChTypePtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_ChTypePtr_CInt_CInt = delegate of WinPtr * CInt * CInt * ChTypePtr * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CInt = delegate of WinPtr * CInt * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CInt_Attr_t_CShort_CVoidPtr_CInt = delegate of WinPtr * CInt * CInt * CInt * Attr_t * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CInt_CInt = delegate of WinPtr * CInt * CInt * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CInt_CInt_CInt = delegate of WinPtr * CInt * CInt * CInt * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CInt_CInt_CInt_CInt_CInt = delegate of WinPtr * CInt * CInt * CInt * CInt * CInt * CInt -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CInt_CInt_CInt_WinPtr = delegate of WinPtr * CInt * CInt * CInt * CInt -> WinPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CInt_CVoid = delegate of WinPtr * CInt -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CIntRef_CIntRef_CVoid = delegate of WinPtr * CInt byref * CInt byref -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CShort_CVoidPtr_CInt = delegate of WinPtr * CShort * CVoidPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CVoid = delegate of WinPtr -> CVoid
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_CFilePtr_CInt = delegate of WinPtr * CFilePtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_WinPtr = delegate of WinPtr -> WinPtr
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_WinPtr_CInt = delegate of WinPtr * WinPtr -> CInt
    [<UnmanagedFunctionPointer(CallingConvention.Cdecl)>]
    type WinPtr_WinPtr_CInt_CInt_CInt_CInt_CInt_CInt_CInt_CInt = delegate of WinPtr * WinPtr * CInt * CInt * CInt * CInt * CInt * CInt * CInt -> CInt

    // ----------------------------------------------------------------------
    // Screen Coordinate Types

    type Boundary =
        { Top : CInt
          Right : CInt
          Bottom : CInt
          Left : CInt }

    type Coordinate =
        { Y : CInt
          X : CInt }

    type Position =
        |    TopLeft = 0 |    Top = 1 |    TopRight = 2
        |       Left = 3 | Normal = 4 |       Right = 5
        | BottomLeft = 6 | Bottom = 7 | BottomRight = 8


[<RequireQualifiedAccess>]
module Boundary =

    let make (top, right, bottom, left) =
        { Top = top
          Right = right
          Bottom = bottom
          Left = left }    
  
    let contains boundary coordinate =
        coordinate.Y >= boundary.Top && coordinate.Y <= boundary.Bottom &&
        coordinate.X >= boundary.Left && coordinate.X <= boundary.Right


[<RequireQualifiedAccess>]
module Coordinate =

    let make (y, x) =
        { Y = y
          X = x }
        
    let empty = make (-1s, -1s)

    let (|Position|_|) boundary coordinate =
        if Boundary.contains boundary coordinate then
            match coordinate.Y, coordinate.X with
            | 0s, 0s                                                -> Position.TopLeft
            |  y, 0s when y = boundary.Bottom                       -> Position.BottomLeft
            |  _, 0s                                                -> Position.Left
            | 0s,  x when x = boundary.Right                        -> Position.TopRight
            |  y,  x when x = boundary.Right && y = boundary.Bottom -> Position.BottomRight
            |  _,  x when x = boundary.Right                        -> Position.Right
            | 0s,  _                                                -> Position.Top
            |  y,  _ when y = boundary.Bottom                       -> Position.Bottom
            |  _,  _                                                -> Position.Normal
            |> Some
        else
            None

[<RequireQualifiedAccess>]
module ChType =

    open System
    
    let ofChar (ch: char) : ChType = Convert.ToUInt32 ch
    let ofInt (ch: int) : ChType = uint32 ch
    let ofCInt (ch: CInt) : ChType = uint32 ch
    let zero = ofInt 0
    let one = ofInt 1


[<RequireQualifiedAccess>]
module CChar_t =

    open System
        
    let toCChar_t (ch: char) : CChar_t = Convert.ToUInt32 ch


[<RequireQualifiedAccess>]
module CInt =

    open System
        
    let ofChType (a: ChType) : CInt = int16 a
    let ofInt (a: int) : CInt = int16 a
    let zero = ofInt 0
    let one = ofInt 1
