#include <iostream>
#include <sstream>
#include <string>
#include <string.h>
using namespace std;

string reversestring(string str){

    int n = str.length();
    for(int i = 0; i < n/2; i++)
    {
         swap(str[i], str[n - 1 - i]);
    }
    return str;

}



string addNumString(string a, string b){
    if(a.length() > b.length())
        swap(a, b);
    string ans = "";
    if(a.length() != b.length())
    {
        while(a.length() < b.length())
        {

            a.insert(0, "0");

        }

    }
    a = reversestring(a);
    b = reversestring(b);


    int m = a.length();
    int n = b.length();
    //312 + 452

    int rem = 0, x;
    for(int i = 0; i < m; i++)
    {
        x = (a[i] - '0') + (b[i] - '0') + rem;
        ans.push_back(x%10 + '0');
        rem = x/10;
    }
    for(int i = m; i < n; i++)
    {
        x = (b[i] - '0') + rem;
        ans.push_back(x%10 + '0');
        rem = x/10;
    }
    if(rem > 0)
    {
        ans.push_back(rem + '0');
    }
    ans = reversestring(ans);
    return ans;

}
int CompareNumString(string a, string b){
    if(a.length() < b.length())
        return -1;
    if(a.length() > b.length())
        return 1;
    for(int i = 0; i < a.length(); i++)
    {
        if(a[i] < b[i])
            return -1;
        if(a[i] > b[i])
            return 1;
    }
    return 0;

}
string subNumString(string a, string b){
    string ans = "";
    if(CompareNumString(a, b) >= 0)
    {
        int n1 = a.length();
        int n2 = b.length();
        a = reversestring(a);
        b = reversestring(b);
        //dao nguoc chuoi de de dang cong tru
        int rem = 0;//phan du
        for(int i = 0; i < n2; i++)
        {
            int sub = (a[i] - '0') - (b[i] - '0') - rem;
            if(sub < 0){
                sub += 10;
                rem = 1;

            }
            else
            {
                rem = 0;
            }
            if((sub == 0) && (i == n2 - 1) && (n1 == n2)){}
            else
                ans.push_back(sub + '0');

        }
        for(int i = n2; i < n1; i++)
        {
            int sub = (a[i] - '0') - rem;
            if(sub < 0){
                sub += 10;
                rem = 1;
            }
            else
                rem = 0;
            if(sub > 0 || i != n1 - 1)
                ans.push_back(sub + '0');
        }
        ans = reversestring(ans);
        int i = 0;
        int l = ans.length();
        while(i < l){

            if(ans[i] == '0')
                ans.erase(ans.begin());
            else break;
            i++;
        }

    }
    else
    {
        ans.push_back('-');
        ans.insert(1, subNumString(b, a));

    }
    return ans;

}
bool IsPalindrome(string str){
    int n = str.length();
    for(int i = 0; i < n/2; i++)
    {
        if(str[i] != str[n - 1 - i])
            return 0;
    }
    return 1;

}
int main()
{
    int t;//test cases
    string str;

    cin>>t;
    int n;





    for(int i = 1; i <= t; i++){
        cin>>n;
        do
        {
            cin>>str;
        }while(str.length() != n);
        string extra = "";
        if(str[0] == '9')
        {
            int m = str.length();
            for(int i = 0; i <= m; i++)
                extra.push_back('1');

        }
        else
        {
            int m = str.length();
            for(int i = 1; i <= m; i++)
                extra.push_back('9');

        }
        cout<<subNumString(extra, str)<<endl;
    }





    return 0;
}
