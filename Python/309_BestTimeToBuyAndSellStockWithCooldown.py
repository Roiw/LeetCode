class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        # Considering state machines..
        # There are 3 states that we check.
        # 1 - Hold or Buy stock
        # 2 - On cooldown
        # 3 - Sold stock
        
        # We evaluate the 3 states, for each state maximizing the results.
        # That means:
        #   For buy stock: we buy if today will give us an increase in income.  
        #   For cooldown: we increase our value if there was a sell.
        #   For sell: we always sell (it always increase our value).
        
        sell_state, buy_state, cooldown_state = 0, -math.inf, 0 
        
        for day_stock in prices:
            
            prev_sell_state, prev_buy_state, prev_cooldown_state = sell_state, buy_state, cooldown_state
            
            # cooldown state changes only: if we sold yesterday or if we are in cooldown
            cooldown_state = max(prev_cooldown_state, prev_sell_state)
            
            # sell state changes only: if we sell, sell is good, we always sell.
            sell_state = day_stock + prev_buy_state
            
            # buy state changes only: if today yields income if we buy.
            buy_state = max(prev_buy_state,  prev_cooldown_state - day_stock)
            
        return max(cooldown_state, sell_state)
            