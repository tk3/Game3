﻿open MySDL2

[<EntryPoint>]
let main argv =
    let SDL_INIT_VIDEO = 0x00000020u
    let _ = Api.SDL_Init(SDL_INIT_VIDEO)

    let SDL_WINDOWPOS_CENTERED_MASK = 0x2FFF0000
    let SDL_WINDOWPOS_CENTERED_DISPLAY x = SDL_WINDOWPOS_CENTERED_MASK ||| x
    let SDL_WINDOWPOS_CENTERED = SDL_WINDOWPOS_CENTERED_DISPLAY 0

    let _ = Api.SDL_CreateWindow("Game3", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 1280, 720, 0u)

    0
