namespace Demos.FSharp.Encog

open Encog
open ExtCore
open FSharpPlus
open FSharpx
open FsControl

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = 42
