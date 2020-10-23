class Solution:
    def asteroidCollision(self, asteroids: List[int]) -> List[int]:
        moving_left, moving_right = [], []
        for asteroid in asteroids:
            if asteroid < 0:

                while len(moving_right) > 0 and -asteroid > moving_right[-1]:
                    moving_right.pop()
                    
                # We deleted everyone on right
                if len(moving_right) == 0:
                    moving_left.append(asteroid)
                
                # There are elements we didn't delete.
                if len(moving_right) > 0 and -asteroid == moving_right[-1]:
                    moving_right.pop()

            else: # positive
                moving_right.append(asteroid)
        return moving_left + moving_right
