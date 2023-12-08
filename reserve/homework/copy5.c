
// 这是主函数的内容
#include <stdio.h>
#include <stdlib.h>

int check = 0; // 全局变量，用于检查后序遍历的结果
char tmp = 0; // 全局变量，用于存储后序遍历的上一个节点的值

// 定义一个二叉树的结构体
typedef struct TreeNode {
    char val; // 节点的值，是一个字符
    struct TreeNode *left; // 左子节点的指针
    struct TreeNode *right; // 右子节点的指针
} TreeNode;

// 声明后序遍历和创建二叉树的函数
void postorderTraversal(TreeNode *root);
TreeNode *createTreeByLevelOrder(char **arr, int size);

// 定义一个异或函数，用于对字符进行加密
char xoR(char a, char b) {
    return a ^ b;
}

int main(int argc, char **argv) {
    char *arr[32]= {"f","l","a","g","{","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","}"}; // 定义一个字符指针数组，用于存储输入的32个字符
    /* for (int i = 0; i < 32; i++) {
         arr[i] = (char *)malloc(sizeof(char)); // 为每个字符分配内存空间
         scanf("%c", arr[i]); // 从标准输入读取一个字符
     }*/
    TreeNode *root = createTreeByLevelOrder(arr, 32); // 根据输入的字符数组，按层次顺序创建一个二叉树
    postorderTraversal(root); // 对二叉树进行后序遍历
    putchar('\n'); // 输出一个换行符
    if (check == 32) // 如果后序遍历的结果和预期的一致，输出祝贺信息
        printf("Congratulation!");
    return 0;
}

// 这是后序遍历函数的内容
void postorderTraversal(TreeNode *root) {
    unsigned char a;
    int b;
    if (root == NULL) // 如果根节点为空，直接返回
        return;
    postorderTraversal(root->left); // 递归遍历左子树
    postorderTraversal(root->right); // 递归遍历右子树
    if (check){ // 如果check不为0，说明已经遍历了至少一个节点
        b = "\x7D\xE1\x80\x34\x2A\x24\x4D\xC1\x8E\x70\x79\x89\xB6\x6A\x4E\x4B\x90\x17\xD4\x5E\x70\x4D\x97\xFE\x4F\x92\x3C\x2F\xF2\x4C\x47\xC5"[check];
        a = tmp ^ b;              
        root->val= a;
        printf("%c", a);
        root->val = xoR(root->val, tmp);} // 对当前节点的值和上一个节点的值进行异或操作，作为加密
    tmp = root->val; // 更新tmp为当前节点的值
    if (tmp != "\x7D\xE1\x80\x34\x2A\x24\x4D\xC1\x8E\x70\x79\x89\xB6\x6A\x4E\x4B\x90\x17\xD4\x5E\x70\x4D\x97\xFE\x4F\x92\x3C\x2F\xF2\x4C\x47\xC5"[check]) // 如果当前节点的值和预期的不一致，退出程序
        exit(0);
    check++; // 更新check为已经遍历的节点数
}

// 这是创建二叉树的函数的内容
TreeNode *createTreeByLevelOrder(char **arr, int size) {
    if (size <= 0) // 如果数组的大小为0或负数，直接返回空指针
        return NULL;
    TreeNode *root = (TreeNode *)malloc(sizeof(TreeNode)); // 为根节点分配内存空间
    root->val = *arr[0]; // 将数组的第一个元素作为根节点的值
    root->left = NULL; // 初始化根节点的左子节点为空指针
    root->right = NULL; // 初始化根节点的右子节点为空指针
    TreeNode *queue[size]; // 定义一个队列，用于存储二叉树的节点
    queue[0] = root; // 将根节点入队
    int front = 0; // 定义队头指针
    int rear = 1; // 定义队尾指针
    int index = 1; // 定义数组的索引
    while (index < size) { // 当数组还有元素未处理时
        TreeNode *node = queue[front]; // 取出队头的节点
        front = (front + 1) % size; // 更新队头指针
        if (index < size) { // 如果数组还有元素未处理
            TreeNode *left = (TreeNode *)malloc(sizeof(TreeNode)); // 为左子节点分配内存空间
            left->val = *arr[index]; // 将数组的当前元素作为左子节点的值
            left->left = NULL; // 初始化左子节点的左子节点为空指针
            left->right = NULL; // 初始化左子节点的右子节点为空指针
            node->left = left; // 将左子节点连接到父节点
            queue[rear] = left; // 将左子节点入队
            rear = (rear + 1) % size; // 更新队尾指针
            index++; // 更新数组的索引
        }
        if (index < size) { // 如果数组还有元素未处理
            TreeNode *right = (TreeNode *)malloc(sizeof(TreeNode)); // 为右子节点分配内存空间
            right->val = *arr[index]; // 将数组的当前元素作为右子节点的值
            right->left = NULL; // 初始化右子节点的左子节点为空指针
            right->right = NULL; // 初始化右子节点的右子节点为空指针
            node->right = right; // 将右子节点连接到父节点
            queue[rear] = right; // 将右子节点入队
            rear = (rear + 1) % size; // 更新队尾指针
            index++; // 更新数组的索引
        }
    }
    return root; // 返回根节点的指针
}
