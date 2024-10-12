using System;
using System.Collections;

namespace Tree
{

    [TestClass]
    public class TrieNode
    {
    private TrieNode[] Nodes;
    public TrieNode(){
        Nodes = new TrieNode[26];
    }
    public void Put(char ch, TrieNode node){
        Nodes[ch-'a'] = node;
    }
    public bool ContainsKey(char ch){
        return Nodes[ch-'a'] != null;
    }
    public TrieNode Get(char ch){
        return Nodes[ch-'a'];
    }
    private bool _isEnd = false;
    public void SetEnd(){
        _isEnd = true;
    }
    public bool IsEnd(){
        return this._isEnd;
    }
    }
}