# CupkekGames TextPopup

Single kind-driven popup interface (`IPopupManager`) for floating-text effects: damage, heal, shield, status effects, mood, EXP — anything a game wants to spawn as a number/text popup.

Kinds are designer-defined string keys (see `PopupKinds` for reserved framework kinds). Per-call extras travel via `IPopupContext` payloads: `DamagePopupContext` says how a hit landed (crit, kill, overkill), `TextPopupContext` overrides the text.

Extracted from HeroManager (Phase A, 2026-04-30). Unified onto a single kind-driven interface (Phase B, 2026-05-04).
