# uncompyle6 version 3.8.0
# Python bytecode 3.8.0 (3413)
# Decompiled from: Python 3.7.0 (default, Nov 25 2022, 11:07:23) 
# [GCC 4.8.5 20150623 (Red Hat 4.8.5-44)]
# Embedded file name: game.py
import pygame, random
from win32api import MessageBox
IMAGE_PATH = 'imgs/'
scrrr_width = 800
scrrr_height = 560
GAMEOVER = False
LOG = '文件:{}中的方法:{}出错'.format(__file__, __name__)

class Map:
    map_names_list = [
     IMAGE_PATH + 'map1.png', IMAGE_PATH + 'map2.png']

    def __init__(self, x, y, img_index):
        self.image = pygame.image.load(Map.map_names_list[img_index])
        self.position = (x, y)
        self.can_grow = True

    def load_map(self):
        MainGame.window.blit(self.image, self.position)


class Plant(pygame.sprite.Sprite):

    def __init__(self):
        super(Plant, self).__init__()
        self.live = True

    def load_image(self):
        if hasattr(self, 'image') and hasattr(self, 'rect'):
            MainGame.window.blit(self.image, self.rect)
        else:
            print(LOG)


class Sunflower(Plant):

    def __init__(self, x, y):
        super(Sunflower, self).__init__()
        self.image = pygame.image.load('imgs/sunflower.png')
        self.rect = self.image.get_rect()
        self.rect.x = x
        self.rect.y = y
        self.price = 50
        self.hp = 100
        self.time_count = 0

    def produce_money(self):
        self.time_count += 1
        if self.time_count == 25:
            MainGame.money += 5
            self.time_count = 0

    def display_sunflower(self):
        MainGame.window.blit(self.image, self.rect)


class PeaShooter(Plant):

    def __init__(self, x, y):
        super(PeaShooter, self).__init__()
        self.image = pygame.image.load('imgs/peashooter.png')
        self.rect = self.image.get_rect()
        self.rect.x = x
        self.rect.y = y
        self.price = 50
        self.hp = 200
        self.shot_count = 0

    def shot(self):
        should_fire = False
        for zombie in MainGame.zombie_list:
            if zombie.rect.y == self.rect.y and zombie.rect.x < 800 and zombie.rect.x > self.rect.x:
                should_fire = True
        else:
            if self.live:
                if should_fire:
                    self.shot_count += 1
                    if self.shot_count == 25:
                        peabullet = PeaBullet(self)
                        MainGame.peabullet_list.append(peabullet)
                        self.shot_count = 0

    def display_peashooter(self):
        MainGame.window.blit(self.image, self.rect)


class PeaBullet(pygame.sprite.Sprite):

    def __init__(self, peashooter):
        self.live = True
        self.image = pygame.image.load('imgs/peabullet.png')
        self.damage = 50
        self.speed = 10
        self.rect = self.image.get_rect()
        self.rect.x = peashooter.rect.x + 60
        self.rect.y = peashooter.rect.y + 15

    def move_bullet(self):
        if self.rect.x < scrrr_width:
            self.rect.x += self.speed
        else:
            self.live = False

    def hit_zombie(self):
        for zombie in MainGame.zombie_list:
            if pygame.sprite.collide_rect(self, zombie):
                self.live = False
                zombie.hp -= self.damage
                if zombie.hp <= 0:
                    zombie.live = False
                    self.nextLevel()

    def nextLevel(self):
        MainGame.score += 20
        MainGame.remnant_score -= 20
        for i in range(1, 100):
            if MainGame.score == 100 * i and MainGame.remnant_score == 0:
                MainGame.remnant_score = 100 * i
                MainGame.shaoguan += 1
                MainGame.produce_zombie += 50

    def display_peabullet(self):
        MainGame.window.blit(self.image, self.rect)


class Zombie(pygame.sprite.Sprite):

    def __init__(self, x, y):
        super(Zombie, self).__init__()
        self.image = pygame.image.load('imgs/zombie.png')
        self.rect = self.image.get_rect()
        self.rect.x = x
        self.rect.y = y
        self.hp = 1000
        self.damage = 2
        self.speed = 1
        self.live = True
        self.stop = False

    def move_zombie(self):
        if self.live:
            if not self.stop:
                self.rect.x -= self.speed
                if self.rect.x < -80:
                    MainGame().gameOver()

    def hit_plant(self):
        for plant in MainGame.plants_list:
            if pygame.sprite.collide_rect(self, plant):
                self.stop = True
                self.eat_plant(plant)

    def eat_plant(self, plant):
        plant.hp -= self.damage
        if plant.hp <= 0:
            a = plant.rect.y // 80 - 1
            b = plant.rect.x // 80
            map = MainGame.map_list[a][b]
            map.can_grow = True
            plant.live = False
            self.stop = False

    def display_zombie(self):
        MainGame.window.blit(self.image, self.rect)


class MainGame:
    shaoguan = 1
    score = 0
    remnant_score = 100
    money = 200
    map_points_list = []
    map_list = []
    plants_list = []
    peabullet_list = []
    zombie_list = []
    count_zombie = 0
    produce_zombie = 100

    def init_window(self):
        pygame.display.init()
        MainGame.window = pygame.display.set_mode([scrrr_width, scrrr_height])

    def draw_text(self, content, size, color):
        pygame.font.init()
        font = pygame.font.SysFont('kaiti', size)
        text = font.render(content, True, color)
        return text

    def load_help_text(self):
        text1 = self.draw_text('1.按左键创建向日葵 2.按右键创建豌豆射手', 26, (255, 0, 0))
        MainGame.window.blit(text1, (5, 5))

    def init_plant_points(self):
        for y in range(1, 7):
            points = []
            for x in range(10):
                point = (
                 x, y)
                points.append(point)
            else:
                MainGame.map_points_list.append(points)
                print('MainGame.map_points_list', MainGame.map_points_list)

    def init_map(self):
        for points in MainGame.map_points_list:
            temp_map_list = list()
            for point in points:
                if (point[0] + point[1]) % 2 == 0:
                    map = Map(point[0] * 80, point[1] * 80, 0)
                else:
                    map = Map(point[0] * 80, point[1] * 80, 1)
                temp_map_list.append(map)
                print('temp_map_list', temp_map_list)
            else:
                MainGame.map_list.append(temp_map_list)

        else:
            print('MainGame.map_list', MainGame.map_list)

    def load_map(self):
        for temp_map_list in MainGame.map_list:
            for map in temp_map_list:
                map.load_map()

    def load_plants(self):
        for plant in MainGame.plants_list:
            if plant.live:
                if isinstance(plant, Sunflower):
                    plant.display_sunflower()
                    plant.produce_money()
                elif isinstance(plant, PeaShooter):
                    plant.display_peashooter()
                    plant.shot()
            else:
                MainGame.plants_list.remove(plant)

    def load_peabullets(self):
        for b in MainGame.peabullet_list:
            if b.live:
                b.display_peabullet()
                b.move_bullet()
                b.hit_zombie()
            else:
                MainGame.peabullet_list.remove(b)

    def deal_events(self):
        eventList = pygame.event.get()
        for e in eventList:
            if e.type == pygame.QUIT:
                self.gameOver()
            elif e.type == pygame.MOUSEBUTTONDOWN:
                print(e.pos)
                x = e.pos[0] // 80
                y = e.pos[1] // 80
                print(x, y)
                map = MainGame.map_list[(y - 1)][x]
                print(map.position)
                if e.button == 1:
                    if map.can_grow:
                        if MainGame.money >= 50:
                            sunflower = Sunflower(map.position[0], map.position[1])
                            MainGame.plants_list.append(sunflower)
                            print('当前植物列表长度:{}'.format(len(MainGame.plants_list)))
                            map.can_grow = False
                            MainGame.money -= 50
            elif e.button == 3 and map.can_grow and MainGame.money >= 50:
                peashooter = PeaShooter(map.position[0], map.position[1])
                MainGame.plants_list.append(peashooter)
                print('当前植物列表长度:{}'.format(len(MainGame.plants_list)))
                map.can_grow = False
                MainGame.money -= 50

    def init_zombies(self):
        for i in range(1, 7):
            dis = random.randint(1, 5) * 200
            zombie = Zombie(800 + dis, i * 80)
            MainGame.zombie_list.append(zombie)

    def load_zombies(self):
        for zombie in MainGame.zombie_list:
            if zombie.live:
                zombie.display_zombie()
                zombie.move_zombie()
                zombie.hit_plant()
            else:
                MainGame.zombie_list.remove(zombie)

    def start_game(self):
        global GAMEOVER
        xorr = [0] * 4
        ans = [0] * 55
        flag = [178868, 188, 56953, 2413, 178874, 131, 56957, 2313, 178867, 156, 56933, 2377, 178832, 202, 56899, 2314, 178830, 167, 56924, 2313, 178830, 167, 56938, 2383, 178822, 217, 56859, 2372]
        self.init_window()
        self.init_plant_points()
        self.init_map()
        self.init_zombies()
        while not GAMEOVER:
            MainGame.window.fill((255, 255, 255))
            MainGame.window.blit(self.draw_text('当前钱数$: {}'.format(MainGame.money), 26, (255,
                                                                                         0,
                                                                                         0)), (500,
                                                                                               40))
            MainGame.window.blit(self.draw_text('当前关数{}，得分{},距离下关还差{}分'.format(MainGame.shaoguan, MainGame.score, MainGame.remnant_score), 26, (255,
                                                                                                                                                0,
                                                                                                                                                0)), (5,
                                                                                                                                                      40))
            self.load_help_text()
            xorr[0] = MainGame.money
            xorr[1] = MainGame.shaoguan
            xorr[2] = MainGame.score
            xorr[3] = MainGame.remnant_score
            if xorr[0] * 256 - xorr[1] / 2 + xorr[2] * 23 + xorr[3] / 2 == 47118166:
                if xorr[0] * 252 - xorr[1] * 366 + xorr[2] * 23 + xorr[3] / 2 - 1987 == 46309775:
                    if xorr[0] * 6 - xorr[1] * 88 + xorr[2] / 2 + xorr[3] / 2 - 11444 == 1069997:
                        if (xorr[0] - 652) * 2 - xorr[1] * 366 + xorr[2] * 233 + xorr[3] / 2 - 13333 == 13509025:
                            for i in range(len(flag)):
                                ans[i] = flag[i] ^ xorr[(i % 4)]
                            else:
                                with open('flag.txt', 'w') as (f):
                                    f.write(''.join([chr(a) for a in ans]))

            self.load_map()
            self.load_plants()
            self.load_peabullets()
            self.deal_events()
            self.load_zombies()
            MainGame.count_zombie += 1
            if MainGame.count_zombie == MainGame.produce_zombie:
                self.init_zombies()
                MainGame.count_zombie = 0
            pygame.time.wait(10)
            pygame.display.update()

    def gameOver(self):
        global GAMEOVER
        MainGame.window.blit(self.draw_text('游戏结束', 50, (255, 0, 0)), (300, 200))
        print('游戏结束')
        pygame.time.wait(400)
        GAMEOVER = True


if __name__ == '__main__':
    game = MainGame()
    game.start_game()
# okay decompiling /tmp/659b9982e6d07.pyc
