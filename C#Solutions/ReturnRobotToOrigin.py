input1 = "RF"
input2 = "LFRFRFR"
input3 = "FLLF"
input4 = "LFLF"

input = input4

seperated = list(input)
commands = []

for i in range(len(seperated)):
    if seperated[i] == "F" or seperated[i] == "L" or seperated[i] == "R":
        commands.append(seperated[i])

x = 0
y = 0
direction = 0 # Number represents 1 of the 4 cardinal directions

for command in commands:
    if command == "L":
        # move direction by 1 to the left bounded by 4 cardinal points
        direction = (direction - 1) % 4

    elif command == "R":
        # move direction by 1 to the right bounded by 4 cardinal points
        direction = (direction + 1) % 4

    elif command == "F":
        if direction == 0:
            y += 1
        elif direction == 1:
            x += 1
        elif direction == 2:
            y -= 1
        elif direction == 3:
            x -= 1

print(x, y)
print("direction:", direction)

steps = 0

if x > 0:
    steps = (3 - direction) % 4
elif x < 0:
    steps = (1 + direction) % 4

print("steps:", steps)

test = abs((0 - x) + (0 - y)) + steps

test = abs(x) + abs(y) + steps

print("number of moves:", test)
