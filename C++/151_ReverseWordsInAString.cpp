class Solution {
public:
    string reverseWords(string s) {
        char * pch = strtok (&s[0]," ");
        if (pch == NULL) return "";
        std::list<string> list; 
        while (pch != NULL){
           list.push_front(string(pch));
           pch = strtok(NULL, " ");
        }
        string ans = "";
        for (auto word : list) 
            ans += ( word + " "); 
        ans.pop_back();
        return ans;
    }
};
