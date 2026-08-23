# Cohesive Storage

RimWorld 1.6 patch mod that folds [Path of The Muffalo](https://steamcommunity.com/sharedfiles/filedetails/?id=3541722499) storage into vanilla-style era research, then trims duplicate buildings and evens out stack density.

Fork of Progression: Storage Lite (Kobe / ferny). Incompatible with [Progression: Storage](https://steamcommunity.com/sharedfiles/filedetails/?id=3292746186).

Requires [Adaptive Storage Framework](https://steamcommunity.com/sharedfiles/filedetails/?id=3033901359).

## What this mod does

- Adds four Main-tab research projects: neolithic, medieval, industrial, spacer.
- Points supported storage buildings at those projects and removes the extra storage techs those mods add.
- Moves vanilla and selected modded storage into the Adaptive Storage **Storage** architect tab.
- Hides overlapping buildings. Twins are only hidden when both mods are loaded; a few extras are hidden even from a single mod.
- Rebalances stack density, a few filters, and a few costs so medieval boxes, industrial bulk, and fridges sit on a shared curve.
- Forces Adaptive Storage Neolithic Module to count as 1.6-compatible (that module is still tagged 1.5 and otherwise shows a version warning).

## Research

All four projects sit on the **Main** research tab, near complex furniture.

| Project | Cost | Prerequisites | Unlocks |
|---|---|---|---|
| Neolithic storage | 200 | none (Classic and Tribal starts) | Adaptive Neolithic buildings, Phaneron pot |
| Medieval storage | 500 | Neolithic storage + Complex furniture | Phaneron and Neat crates, pallets, food, racks, displays |
| Industrial storage | 1000 | Medieval storage + Electricity | Metal crate, dumpster, cargo, fuel tank, safe, drum, fridges |
| Spacer storage | 2000 | Industrial storage | Gravship storage; cryogenic tanks also need Cryptosleep |

Extra research those mods add is removed:

- Adaptive Neolithic’s storage projects and its extra Storage research tab
- Phaneron’s Basic Storage / Neolithic Storage projects

Other extra unlocks kept as second prerequisites:

- Phaneron fuel tank also needs **Biofuel refining**
- Cryogenic tanks also need **Cryptosleep**

## Storage tab

Vanilla shelves and bookcases move to the Adaptive Storage **Storage** tab. Stockpile and dumping zone designators are added there.

These buildings also move onto that tab when their mods are loaded:

- Vanilla Furniture Expanded weapon rack (relabelled **small weapon rack** if Neat Storage is present, so it is not confused with Neat’s rack)
- Vanilla Recycling Expanded waste crate
- Vanilla Factions Expanded - Medieval 2 ailments shelf
- Vanilla Furniture Expanded - Spacer Module repair rack

## Overlap

Hidden buildings are blanked out of the architect menu. Existing copies in a save stay on the map.

**Prefer Phaneron** when a Phaneron building and a Neat twin both exist, except meat storage, where Neat’s 2×1 hook wins.

### Always hidden (even if the competing mod is not loaded)

| Building | Mod | Why |
|---|---|---|
| Large crate | Phaneron | Same job as the large pallet |
| Large bundle | Phaneron | Same job as the large pallet / sack |
| Tall crate | Neat | Same 2×2 crate as Neat’s large container |
| Corpse dump spot | Neat | Unpowered corpse dump; corpse fridge covers that later |
| Open shelf, tall display, narrow tall display, display cabinets, round pedestal | Neat | Extra skins of shelves already kept |

### Hidden only when both mods are loaded

**Neolithic**

| Hidden | Kept | When |
|---|---|---|
| Adaptive large pot | Phaneron pot | Adaptive Neolithic + Phaneron |
| Adaptive plinths | Neat display case / shelves | Adaptive Neolithic + Neat Storage |

**Medieval (Phaneron + Neat Storage)**

| Hidden | Kept |
|---|---|
| Neat small container | Phaneron small crate (and sack) |
| Neat mini / half / full pallets | Phaneron small and large pallets |
| Neat weapon rack | Phaneron weapon rack |
| Phaneron meat hook | Neat meat hook (2×1, meat and corpses) |

**Industrial (Phaneron + Neat Storage)**

| Hidden | Kept |
|---|---|
| Neat horizontal and vertical weapon racks | Phaneron weapon rack |

Drum, safe, dumpster, cargo, fuel tank, and every fridge stay.

### Spacer

Nothing is hidden. Gravship crates, shelves, and weapon rack all stay, as do all four cryogenic tanks.

The extra-large cryogenic tank is put back on the **Misc** tab (upstream blanks its category).

## Buildings that stay

### Neolithic storage

- Adaptive: basket, meal shelf, hay pile, wood pile, textile bundle, stacked chunks
- Phaneron: pot (if Phaneron is loaded; otherwise Adaptive’s large pot stays)

### Medieval storage

- Phaneron: small crate, medium crate, small pallet, large pallet, cask, food barrel, sack, pantry shelf, meal cupboard, weapon rack
- Neat: medium container, large container, small / normal / 2-tier display shelves, hanger shelves, display case, meat hook, textile rack
- VFE Medieval 2: ailments shelf (on the Storage tab)

If Phaneron is **not** loaded, Neat’s small container, pallets, and weapon rack stay visible.

### Industrial storage

- Phaneron: metal crate, industrial dumpster, cargo container, fuel tank
- Neat: safe, drum
- Fridge: standing fridge, large fridge, single and double chest fridges, single and double wall fridges, corpse fridge

### Spacer storage

- Gravship: crate, large crate, long crate, small shelf, shelf, 2-tier shelf, glass shelf, weapon rack
- Cryogenic Tank: small, medium, large, extra-large

Gravship furniture requires **gravship substructure**.

## Rebalance

Items per cell unless noted. Totals assume the building’s footprint.

### Density

| Building | Was | Now |
|---|---|---|
| Phaneron small / medium / metal crates | 5–6 | 8 |
| Phaneron small / large pallets | 5 | 8 |
| Phaneron cask, food barrel, sack | 5 | 8 |
| Phaneron dumpster, cargo container, fuel tank | 4–6 | 8 |
| Neat crate parent (medium and large containers) | 6 | 8 |
| Neat drum | 6 | 15 |
| Neat safe | 6 | 18 |
| All fridges (standing, large, chest, wall, corpse) | 2–5 | 6 |
| VFE Medieval 2 ailments shelf | 4 | 6 |

Cargo at 8 / cell is **64** stacks on a 2×4 pad, so industrial bulk is not worse than a medieval 2×2 crate at 32.

The standing fridge’s Adaptive graphics are scaled so six stacks fit the sprite.

Left alone: Adaptive baskets and piles, display shelves, hangers, weapon / meat / textile racks, gravship crates (already 8).

### Filters and stats

- **Neat medium container** — materials only (everything except foods, meals, corpses, and chunks).
- **Neat drum** — raw resources and foods only.
- **Neat safe** — silver only; 5000 HP; 200 metal.
- **Neat crate labels** — small / medium / large **container** so they read as boxes, not the same word as Phaneron’s crates.

## Other supported mods

These do not add era buildings, but they still get a light touch:

- **Hospitality: Vending machines** — Adaptive graphics so stored items are not drawn inside the machine.
- **Vanilla Furniture Expanded** — weapon rack on the Storage tab.
- **Vanilla Furniture Expanded - Spacer Module** — repair rack on the Storage tab.
- **Vanilla Recycling Expanded** — waste crate on the Storage tab.
- **Vanilla Factions Expanded - Medieval 2** — ailments shelf on the Storage tab, 6 items per cell.

## Adaptive Neolithic on 1.6

Adaptive Storage Neolithic Module is still marked 1.5-only. A small Harmony patch treats that one package as version-compatible so RimWorld will load it for 1.6 without the red warning. The module itself is unchanged.

## Credits

Kobe Riddle, ferny, Cruesoe.
