namespace MySDL2

open System
open System.Runtime.InteropServices

module Api =
    // Uint32 ?

    // SDL.h
    [<DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)>]
    extern int SDL_Init(uint32 flags)

    // SDL_video.h
    [<DllImport("SDL2.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)>]
    extern IntPtr SDL_CreateWindow(string title, int x, int y, int w, int h, uint32 flags)

    let hello name =
        printfn "Hello %s" name
