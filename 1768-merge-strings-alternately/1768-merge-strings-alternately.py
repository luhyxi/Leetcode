"""
:type word1: str
:type word2: str
:rtype: str
"""

class Solution(object):
    def mergeAlternately(self, word1, word2):
        final_word = ""
        if len(word1) > len(word2) :
            word2 += ' ' * (len(word1) - len(word2))
        elif len(word2) > len(word1) :
            word1 += ' ' * (len(word2) - len(word1))
            
        for a, b in zip(word1, word2):
            final_word += a
            final_word += b
        return final_word.replace(" ", "")