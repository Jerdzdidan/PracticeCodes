player_weapons = [
    {"player" : "player_1", "primary_weapon" : "AK47", "secondary_weapon" : "glock"},
    {"player" : "player_2", "primary_weapon" : "M4A1", "secondary_weapon" : "deagle"},
    {"player" : "player_3", "primary_weapon" : "Double_Barrel", "secondary_weapon" : "five_seven"},
    {"player" : "player_4", "primary_weapon" : "Knives", "secondary_weapon" : "tec_9"},
    {"player" : "player_5", "primary_weapon" : "Rail_Gun", "secondary_weapon" : None}
]

for player in player_weapons:
    print(player["player"], player["primary_weapon"], player["secondary_weapon"], sep=", ")