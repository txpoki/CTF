word = []
def dfs(maze, x, y, path,word,n_w):

    if x < 0 or x >= len(maze) or y < 0 or y >= len(maze[0]) or maze[x][y] == 0:
        return False

    path.append((x, y))
    word.append(n_w)

    if maze[x][y] == 7:
        return True

    maze[x][y] = 0  # Mark the current cell as visited

    # Try moving in different directions
    if dfs(maze, x, y + 1, path,word,'3') or dfs(maze, x + 1, y, path,word,'2') or dfs(maze, x, y - 1, path,word,'1') or dfs(maze, x - 1, y, path,word,'0'):
        return True

    path.pop()  # Backtrack if none of the directions lead to the target
    word.pop()
    return False

def depth_first_search(maze):
    start_x, start_y = 0, 0
    path = []

    if dfs(maze, start_x, start_y, path,word,'x'):
        return word 
    else:
        return None

if __name__ == "__main__":
    maze = [
[1,0,0,0,0,0,1,1,1,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0],
[1,1,0,0,0,1,1,0,1,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0],
[0,1,0,0,0,1,0,0,1,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0],
[0,1,0,0,0,1,0,0,1,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0],
[0,1,0,0,0,1,0,0,1,1,1,1,1,1,1,1,0,0,0,1,0,0,0,0],
[0,1,1,0,1,1,0,0,1,0,0,0,1,0,0,1,0,0,1,1,0,0,0,0],
[0,0,1,0,1,0,0,0,1,0,0,1,1,0,0,1,0,0,1,0,0,0,1,0],
[0,0,1,1,1,0,0,0,1,0,1,1,0,0,0,1,0,0,1,0,0,0,1,0],
[0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,7],
[0,0,0,1,0,0,1,0,1,0,0,0,1,1,0,1,0,0,0,0,1,0,0,0],
[0,0,0,1,0,1,1,0,1,0,0,0,1,0,0,1,0,0,0,1,1,0,0,0],
[0,1,0,1,1,1,0,0,1,1,1,1,1,1,1,1,0,0,1,1,0,0,0,0],
[0,1,1,1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,0,0],
[0,0,0,1,0,0,0,1,1,1,1,0,0,0,1,1,0,0,0,1,1,0,0,0],
[0,0,0,1,0,0,0,1,0,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0],
[0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0]
    ]

    result = depth_first_search(maze)

    if result:
        str1 = ''.join(result)
        print(str1)

    else:
        print("未找到路径。")
