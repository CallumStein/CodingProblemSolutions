# Define a function decode() that reads an encrypted message from a text file and outputs the decode message
def decode(message_file):

  # Initialize a dictionary to store each encoded word from the txt file (key: int, val: word)
  encoded_words = {}

  # Read the words from the text file and add them to the dictionary
  with open(message_file, 'r') as file:
    for line in file:
      key, word = line.split(" ") # Split each line into its key and word values
      encoded_words[int(key)] = word # Add the key value and word to the dictionary

  # Initialize an output string and position tracker
  output = ""
  position = 1
  row = 1

  # Loop through the encoded words checking whether their key is an end of pyramid value (1, 3, 6, 10, 15, ...)
  while position in encoded_words:
        
    # Check if that value is in the encoded words, if not break the sequence
    if position not in encoded_words:
      print("Break")
      break

    # format the word to match the output
    output += f'{position}: {encoded_words[position]}'

    # Increase the position to the next number in the pyramid sequence based on the row
    position = position + (row + 1)
    row += 1

  # Return the formatted output
  return output

if __name__ == "__main__":
  print("test")
  result = decode("coding_qual_input.txt")
  print(result)