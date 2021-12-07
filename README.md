# Lumina.Excel

WIP shit for a new schema format, typed sheet generator and introspection tooling.

## Overview

* `docs` - documentation for tooling and schema format
* `schema` - game excel sheet schema definition files, e.g., Item.yml
* `src` - generator & tooling documentation

## WIP Schema Example

	sheet: Item
	type: column

	definition:
	  - Singular
	  - Adjective
	  - Plural
	  - PossessivePronoun
	  - StartsWithVowel
	  - unknown:
	  - Pronoun
	  - Article
	  - Description
	  - Name
	  - Icon
	  - sheet: ItemLevel
	  - Rarity
	  - FilterGroup
	  - AdditionalData
	  - sheet: ItemUICategory
	  - sheet: ItemSearchCategory
	  - sheet: EquipSlotCategory
	  - sheet: ItemSortCategory
	  - unknown:
	  - StackSize
	  - IsUnique
	  - IsUntradable
	  - unknown: 35
	  - struct: BaseParam[6]
	    definition:
	      - sheet: BaseParam
	      - Value
	  - sheet: ItemSpecialBonus
	  - ItemSpecialBonusParam
	  - struct: SpecialParam[6]
	    definition:
	      - sheet: BaseParam
	      - Value
