import emoji

input = input("Input: ")
input = emoji.emojize(input, language='alias')

print(emoji.emojize(input, variant="emoji_type"))