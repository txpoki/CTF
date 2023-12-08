#include <stdio.h>
#include <stdlib.h>

// 全局变量，用于存储异或操作的临时结果
unsigned char tmp; //
int check = 0; // 用于验证是否所有节点都已访问

// 定义二叉树节点结构
typedef struct TreeNode {
    unsigned char value;
    struct TreeNode *left;
    struct TreeNode *right;
} TreeNode;

// 创建二叉树节点
TreeNode* createNode(unsigned char value) {
    TreeNode* node = (TreeNode*)malloc(sizeof(TreeNode));
    node->value = value;
     node->left = NULL;
    node->right = NULL;
    return node;
}

// 后序遍历并进行异或操作
unsigned __int64 __fastcall postorderTraversal(TreeNode* root) {
    unsigned __int64 result = 0xFE974D705ED41790LL;
    __int64 v3[5];
    v3[0] = 0xC14D242A3480E17DLL;
    v3[1] = 0x4B4E6AB68979708ELL;
    v3[2] = 0xFE974D705ED41790LL;
    v3[3] = 0xC5474CF22F3C924FLL;
    if (root == NULL) return result;
    postorderTraversal(root->left);
    postorderTraversal(root->right);
    // 进行异或操作
    if (check) {
        root->value ^= tmp; // 如果不是第一个节点，就和tmp异或
    }
    tmp = root->value; // 更新tmp
    if (tmp != *((unsigned char*)v3+ check)) { // 如果和隐藏字符串不匹配，就退出程序
        printf("不匹配\n");
        exit(0);
    }
    return ++check; // 更新check
}

// 根据层序遍历的数组创建完全二叉树
TreeNode* createTreeByLevelOrder(unsigned char* values, int size) {
    if (size == 0) return NULL;
    TreeNode** nodes = (TreeNode**)malloc(size * sizeof(TreeNode*));
    for (int i = 0; i < size; ++i) {
        nodes[i] = createNode(values[i]);
    }
    for (int i = 0; i < size; ++i) {
        if (2 * i + 1 < size) nodes[i]->left = nodes[2 * i + 1];
        if (2 * i + 2 < size) nodes[i]->right = nodes[2 * i + 2];
    }
    TreeNode* root = nodes[0];
    free(nodes);
    return root;
}

// 主函数
int main() {
    unsigned char values[32]="flag{abcdefghijklmnopqrstuvwxyz}";
    printf("启动\n");
    // 读取32个字符
    //for (int i = 0; i < 32; ++i) {
       // scanf("%c", &values[i]);
   // }
    // 创建二叉树
    TreeNode* root = createTreeByLevelOrder(values, 32);
    // 后序遍历并进行异或操作
    postorderTraversal(root);
    // 输出结果
    for (int i = 0; i < 32; ++i) {
        printf("%c", values[i]);
    }
    printf("\n");
    if (check == 32) { // 如果所有节点都匹配，就输出"Congratulation!"和flag
        printf("Congratulation!\n");
        printf("flag{%s}\n", values);
    }
    else 
    {
        printf("wrong");
    }
    
    return 0;
}
