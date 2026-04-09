/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    
    const groups = {};
    //We are using the groups object to carry an key of sorted strings

    for (const s of strs){
        const word = s.split('').sort().join('') //'eat' -> 'aet'

        if (!groups[word]){
            groups[word] = []
        }

        groups[word].push(s)

        
    }
    return Object.values(groups)
    
};