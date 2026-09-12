# Rock-Paper-Scissors-in-WPF

A small desktop Rock–Paper–Scissors game built with WPF — the author's first little
WPF game. You pick rock, paper or scissors and play against the computer.

## Features

- Click rock, paper or scissors to play a round against a computer opponent.
- Separate windows for the start screen and for winning / losing outcomes
  (`Start`, `Gewonnen`, `Verloren`).
- Image-based UI with icons for each choice.

## Tech

- C#, WPF (XAML), .NET Framework 4.7.2.

## Run

Open `Rock Paper Scissors.sln` in Visual Studio and run (F5), or build from the
command line:

```bash
msbuild "Rock Paper Scissors.sln"
```

Then launch the produced `Rock Paper Scissors.exe`. Requires Windows with the
.NET Framework 4.7.2.
