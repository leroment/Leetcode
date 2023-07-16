/**
 * @param {number[]} nums
 * @return {number}
 */
var rob = function(nums) {
    let evenHousesTotal = 0;
    let oddHousesTotal = 0;

    // Compare sum of current house value with previous odd house total and updates odd/even total
    for (let i = 0; i < nums.length; i++) {
        // even
        if(i % 2 == 0){
            evenHousesTotal = Math.max(evenHousesTotal+nums[i], oddHousesTotal)
        }
        // odd
        if(i % 2 == 1){
            oddHousesTotal = Math.max(oddHousesTotal+nums[i], evenHousesTotal)
        }
    }

    if(evenHousesTotal > oddHousesTotal){
        return evenHousesTotal;
    }
    else{
        return oddHousesTotal;
    }
};